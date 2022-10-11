using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4_AD_DP
{
    internal class NavigationSystem
    {
        char[,] gameMap;
        byte Row = 0;
        byte Col = 0;
        string printMap = "";
        string userGuess = "";
        int guessCount = 0;
        //MessageBox messageBox = new MessageBox;

        public NavigationSystem(int row, int col)
        {
            gameMap = new char[row, col];

            // generate random values for the islands location
            Random random = new Random();
            Row = (byte)random.Next(0, gameMap.GetLength(0) - 1);
            Col = (byte)random.Next(0, gameMap.GetLength(1) - 1);

            
            // fill the map with waves to display to user
            for (int i = 0; i < gameMap.GetLength(0); i++)
            {
                for (int j = 0; j < gameMap.GetLength(1); j++)
                {
                    gameMap[i, j] = '~';
                }
            }
            guessCount = 0;
        }

        // this function is to print the map to the user
        // it will be called and updated after each guess
        public string PrintMap()
        {
            byte x = 0;
            printMap = "";
            // formatting output for column identifiers
            for (int i = 0; i < gameMap.GetLength(1); i++)
            {
                if (x == 20)
                {
                    x = 0;
                }
                printMap += x.ToString() + "  ";
                x++;
            }

            printMap += "\n";

            for (int j = 0; j < gameMap.GetLength(0); j++)
            {
                for (int h = 0; h < gameMap.GetLength(1); h++)
                {
                    printMap += gameMap[j, h].ToString();
                    printMap += " ";
                }
                printMap += (j + ((j < 15) ? " " : " ")).ToString() + "\n";
            }
            return printMap;
        }

        // fx evaluate guess will take the user input values for row and column
        // compare them to the hidden islands locations and detemermine where
        // the island is in relation to their guess
        public string EvalGuess(int guessRow, int guessColumn)
        {
            userGuess = "";

            // winning message box output if user guesses island coords correctly
            if ((guessRow == Row) && (guessColumn == Col))
            {

                gameMap[guessRow, guessColumn] = 'I';
                userGuess = PrintMap();
                MessageBox.Show("Land Ho!" ,"Prepare for Landing");
                    
                printMap = "";

            }
            // if not correct then determin which direction to send the user next
            else if (guessCount % 2 == 0)
            {
                if (guessRow < Row)
                {
                    gameMap[guessRow, guessColumn] = 'S';
                    userGuess = PrintMap();
                }
                else if (guessRow > Row)
                {
                    gameMap[guessRow, guessColumn] = 'N';
                    userGuess = PrintMap();
                }
                else
                {
                    gameMap[guessRow, guessColumn] = 'R';
                    userGuess = PrintMap();
                }
            }
            else
            {
                if (guessColumn < Col)
                {
                    gameMap[guessRow, guessColumn] = 'E';
                    userGuess = PrintMap();
                }
                else if (guessColumn > Col)
                {
                    gameMap[guessRow, guessColumn] = 'W';
                    userGuess = PrintMap();
                }
                else
                {
                    gameMap[guessRow, guessColumn] = 'C';
                    userGuess = PrintMap();
                }

            }
            return userGuess;
        }
    }
}
