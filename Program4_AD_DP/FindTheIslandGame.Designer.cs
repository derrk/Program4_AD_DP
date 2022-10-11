namespace Program4_AD_DP
{
    partial class FindTheIslandGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindTheIslandGame));
            this.guessBox = new System.Windows.Forms.GroupBox();
            this.GuessCountBoxLabel = new System.Windows.Forms.Label();
            this.guessCountBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.colGuessBox = new System.Windows.Forms.NumericUpDown();
            this.rowGuessBox = new System.Windows.Forms.NumericUpDown();
            this.mapBox = new System.Windows.Forms.GroupBox();
            this.MapSizeBox = new System.Windows.Forms.GroupBox();
            this.colAmountBox = new System.Windows.Forms.TextBox();
            this.rowAmountBox = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guessBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colGuessBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowGuessBox)).BeginInit();
            this.MapSizeBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guessBox
            // 
            this.guessBox.Controls.Add(this.label4);
            this.guessBox.Controls.Add(this.label3);
            this.guessBox.Controls.Add(this.GuessCountBoxLabel);
            this.guessBox.Controls.Add(this.guessCountBox);
            this.guessBox.Controls.Add(this.guessButton);
            this.guessBox.Controls.Add(this.colGuessBox);
            this.guessBox.Controls.Add(this.rowGuessBox);
            this.guessBox.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBox.Location = new System.Drawing.Point(12, 12);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(412, 101);
            this.guessBox.TabIndex = 0;
            this.guessBox.TabStop = false;
            this.guessBox.Text = "Guess Location";
            // 
            // GuessCountBoxLabel
            // 
            this.GuessCountBoxLabel.AutoSize = true;
            this.GuessCountBoxLabel.Location = new System.Drawing.Point(302, 22);
            this.GuessCountBoxLabel.Name = "GuessCountBoxLabel";
            this.GuessCountBoxLabel.Size = new System.Drawing.Size(58, 15);
            this.GuessCountBoxLabel.TabIndex = 4;
            this.GuessCountBoxLabel.Text = "Guess #";
            // 
            // guessCountBox
            // 
            this.guessCountBox.Location = new System.Drawing.Point(366, 19);
            this.guessCountBox.Name = "guessCountBox";
            this.guessCountBox.Size = new System.Drawing.Size(26, 22);
            this.guessCountBox.TabIndex = 3;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(306, 49);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 2;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // colGuessBox
            // 
            this.colGuessBox.Location = new System.Drawing.Point(167, 51);
            this.colGuessBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.colGuessBox.Name = "colGuessBox";
            this.colGuessBox.Size = new System.Drawing.Size(120, 22);
            this.colGuessBox.TabIndex = 1;
            this.colGuessBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rowGuessBox
            // 
            this.rowGuessBox.Location = new System.Drawing.Point(24, 52);
            this.rowGuessBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.rowGuessBox.Name = "rowGuessBox";
            this.rowGuessBox.Size = new System.Drawing.Size(120, 22);
            this.rowGuessBox.TabIndex = 0;
            this.rowGuessBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mapBox
            // 
            this.mapBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.mapBox.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapBox.Location = new System.Drawing.Point(12, 156);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(412, 268);
            this.mapBox.TabIndex = 1;
            this.mapBox.TabStop = false;
            this.mapBox.Text = "Map";
            // 
            // MapSizeBox
            // 
            this.MapSizeBox.Controls.Add(this.label2);
            this.MapSizeBox.Controls.Add(this.label1);
            this.MapSizeBox.Controls.Add(this.colAmountBox);
            this.MapSizeBox.Controls.Add(this.rowAmountBox);
            this.MapSizeBox.Controls.Add(this.playButton);
            this.MapSizeBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapSizeBox.Location = new System.Drawing.Point(453, 12);
            this.MapSizeBox.Name = "MapSizeBox";
            this.MapSizeBox.Size = new System.Drawing.Size(176, 101);
            this.MapSizeBox.TabIndex = 2;
            this.MapSizeBox.TabStop = false;
            this.MapSizeBox.Text = "Map Size";
            // 
            // colAmountBox
            // 
            this.colAmountBox.Location = new System.Drawing.Point(6, 72);
            this.colAmountBox.Name = "colAmountBox";
            this.colAmountBox.Size = new System.Drawing.Size(56, 21);
            this.colAmountBox.TabIndex = 4;
            this.colAmountBox.TextChanged += new System.EventHandler(this.colAmountBox_ValueChanged);
            this.colAmountBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.colAmountBox_KeyPress);
            // 
            // rowAmountBox
            // 
            this.rowAmountBox.Location = new System.Drawing.Point(6, 30);
            this.rowAmountBox.Name = "rowAmountBox";
            this.rowAmountBox.Size = new System.Drawing.Size(56, 21);
            this.rowAmountBox.TabIndex = 3;
            this.rowAmountBox.TextChanged += new System.EventHandler(this.rowAmountBox_ValueChanged);
            this.rowAmountBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rowAmountBox_KeyPress);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.LawnGreen;
            this.playButton.Location = new System.Drawing.Point(97, 25);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(64, 63);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox6);
            this.groupBox1.Controls.Add(this.maskedTextBox5);
            this.groupBox1.Controls.Add(this.maskedTextBox4);
            this.groupBox1.Controls.Add(this.maskedTextBox3);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(453, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 268);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Columns";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "How To Play : Start by entering the # of Rows and Columns";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 118);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.Text = "N = Island is North";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.maskedTextBox2.Location = new System.Drawing.Point(12, 144);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 2;
            this.maskedTextBox2.Text = "S = Island is South";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.maskedTextBox3.Location = new System.Drawing.Point(12, 196);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 3;
            this.maskedTextBox3.Text = "W = Island is West";
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.maskedTextBox4.Location = new System.Drawing.Point(12, 170);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox4.TabIndex = 4;
            this.maskedTextBox4.Text = "E = Island is East";
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.maskedTextBox5.Location = new System.Drawing.Point(118, 118);
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBox5.TabIndex = 5;
            this.maskedTextBox5.Text = "C = Island is in same Column";
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.maskedTextBox6.Location = new System.Drawing.Point(118, 170);
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBox6.TabIndex = 6;
            this.maskedTextBox6.Text = "R = Island is in same Row";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox2.Location = new System.Drawing.Point(28, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Adjust the Guess Location Row x Column";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Row ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Column";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(635, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FindTheIslandGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MapSizeBox);
            this.Controls.Add(this.mapBox);
            this.Controls.Add(this.guessBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindTheIslandGame";
            this.Text = "Island Finder Game";
            this.guessBox.ResumeLayout(false);
            this.guessBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colGuessBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowGuessBox)).EndInit();
            this.MapSizeBox.ResumeLayout(false);
            this.MapSizeBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox guessBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.NumericUpDown colGuessBox;
        private System.Windows.Forms.NumericUpDown rowGuessBox;
        private System.Windows.Forms.GroupBox mapBox;
        private System.Windows.Forms.GroupBox MapSizeBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.MessageBox messageBox;
        private System.Windows.Forms.Label GuessCountBoxLabel;
        private System.Windows.Forms.TextBox guessCountBox;
        private System.Windows.Forms.TextBox colAmountBox;
        private System.Windows.Forms.TextBox rowAmountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

