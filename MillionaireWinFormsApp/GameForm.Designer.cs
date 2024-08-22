namespace MillionaireWinFormsApp
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            questionTextLabel = new Label();
            answerTextButton1 = new Button();
            answerTextButton2 = new Button();
            answerTextButton3 = new Button();
            answerTextButton4 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            radioButton15 = new RadioButton();
            radioButton14 = new RadioButton();
            radioButton13 = new RadioButton();
            radioButton12 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // questionTextLabel
            // 
            questionTextLabel.BackColor = Color.SteelBlue;
            questionTextLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questionTextLabel.ForeColor = SystemColors.ControlLightLight;
            questionTextLabel.Location = new Point(12, 425);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(813, 70);
            questionTextLabel.TabIndex = 0;
            questionTextLabel.Text = "Здесь будет текст каждого вопроса";
            questionTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answerTextButton1
            // 
            answerTextButton1.BackColor = Color.CornflowerBlue;
            answerTextButton1.BackgroundImageLayout = ImageLayout.Stretch;
            answerTextButton1.Font = new Font("Microsoft Sans Serif", 12F);
            answerTextButton1.Location = new Point(8, 512);
            answerTextButton1.Name = "answerTextButton1";
            answerTextButton1.Size = new Size(345, 70);
            answerTextButton1.TabIndex = 1;
            answerTextButton1.Text = "button1";
            answerTextButton1.UseVisualStyleBackColor = false;
            answerTextButton1.Click += answerTextButton_Click;
            // 
            // answerTextButton2
            // 
            answerTextButton2.BackColor = Color.CornflowerBlue;
            answerTextButton2.Font = new Font("Microsoft Sans Serif", 11.25F);
            answerTextButton2.Location = new Point(8, 588);
            answerTextButton2.Name = "answerTextButton2";
            answerTextButton2.Size = new Size(330, 70);
            answerTextButton2.TabIndex = 2;
            answerTextButton2.Text = "button2";
            answerTextButton2.UseVisualStyleBackColor = false;
            answerTextButton2.Click += answerTextButton_Click;
            // 
            // answerTextButton3
            // 
            answerTextButton3.BackColor = Color.CornflowerBlue;
            answerTextButton3.Font = new Font("Microsoft Sans Serif", 12F);
            answerTextButton3.Location = new Point(480, 512);
            answerTextButton3.Name = "answerTextButton3";
            answerTextButton3.Size = new Size(345, 70);
            answerTextButton3.TabIndex = 3;
            answerTextButton3.Text = "button3";
            answerTextButton3.UseVisualStyleBackColor = false;
            answerTextButton3.Click += answerTextButton_Click;
            // 
            // answerTextButton4
            // 
            answerTextButton4.BackColor = Color.CornflowerBlue;
            answerTextButton4.Font = new Font("Microsoft Sans Serif", 12F);
            answerTextButton4.Location = new Point(495, 588);
            answerTextButton4.Name = "answerTextButton4";
            answerTextButton4.Size = new Size(330, 70);
            answerTextButton4.TabIndex = 4;
            answerTextButton4.Text = "button4";
            answerTextButton4.UseVisualStyleBackColor = false;
            answerTextButton4.Click += answerTextButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Обычный_основной_фон;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(835, 423);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MidnightBlue;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(0, 416);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(835, 90);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.HotTrack;
            pictureBox3.Location = new Point(0, 505);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(835, 158);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(radioButton15);
            panel1.Controls.Add(radioButton14);
            panel1.Controls.Add(radioButton13);
            panel1.Controls.Add(radioButton12);
            panel1.Controls.Add(radioButton11);
            panel1.Controls.Add(radioButton10);
            panel1.Controls.Add(radioButton9);
            panel1.Controls.Add(radioButton8);
            panel1.Controls.Add(radioButton7);
            panel1.Controls.Add(radioButton6);
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 398);
            panel1.TabIndex = 10;
            // 
            // radioButton15
            // 
            radioButton15.AutoSize = true;
            radioButton15.BackColor = SystemColors.ActiveCaption;
            radioButton15.Enabled = false;
            radioButton15.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            radioButton15.ForeColor = Color.ForestGreen;
            radioButton15.Location = new Point(3, 79);
            radioButton15.Name = "radioButton15";
            radioButton15.Size = new Size(67, 17);
            radioButton15.TabIndex = 14;
            radioButton15.TabStop = true;
            radioButton15.Text = "500000";
            radioButton15.UseVisualStyleBackColor = false;
            // 
            // radioButton14
            // 
            radioButton14.AutoSize = true;
            radioButton14.BackColor = SystemColors.ActiveCaption;
            radioButton14.Enabled = false;
            radioButton14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            radioButton14.ForeColor = Color.ForestGreen;
            radioButton14.Location = new Point(3, 102);
            radioButton14.Name = "radioButton14";
            radioButton14.Size = new Size(67, 17);
            radioButton14.TabIndex = 13;
            radioButton14.TabStop = true;
            radioButton14.Text = "250000";
            radioButton14.UseVisualStyleBackColor = false;
            // 
            // radioButton13
            // 
            radioButton13.AutoSize = true;
            radioButton13.BackColor = SystemColors.ActiveCaption;
            radioButton13.Enabled = false;
            radioButton13.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            radioButton13.ForeColor = Color.ForestGreen;
            radioButton13.Location = new Point(3, 125);
            radioButton13.Name = "radioButton13";
            radioButton13.Size = new Size(67, 17);
            radioButton13.TabIndex = 12;
            radioButton13.TabStop = true;
            radioButton13.Text = "125000";
            radioButton13.UseVisualStyleBackColor = false;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.BackColor = Color.Aqua;
            radioButton12.Enabled = false;
            radioButton12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            radioButton12.ForeColor = Color.ForestGreen;
            radioButton12.Location = new Point(3, 56);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(74, 17);
            radioButton12.TabIndex = 11;
            radioButton12.TabStop = true;
            radioButton12.Text = "1000000";
            radioButton12.UseVisualStyleBackColor = false;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.BackColor = Color.Aqua;
            radioButton11.Enabled = false;
            radioButton11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            radioButton11.ForeColor = Color.ForestGreen;
            radioButton11.Location = new Point(3, 171);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(60, 17);
            radioButton11.TabIndex = 10;
            radioButton11.TabStop = true;
            radioButton11.Text = "32000";
            radioButton11.UseVisualStyleBackColor = false;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.BackColor = SystemColors.ActiveCaption;
            radioButton10.Enabled = false;
            radioButton10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            radioButton10.ForeColor = Color.ForestGreen;
            radioButton10.Location = new Point(3, 148);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(60, 17);
            radioButton10.TabIndex = 9;
            radioButton10.TabStop = true;
            radioButton10.Text = "64000";
            radioButton10.UseVisualStyleBackColor = false;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.BackColor = SystemColors.ActiveCaption;
            radioButton9.Enabled = false;
            radioButton9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            radioButton9.ForeColor = Color.ForestGreen;
            radioButton9.Location = new Point(3, 194);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(60, 17);
            radioButton9.TabIndex = 8;
            radioButton9.TabStop = true;
            radioButton9.Text = "16000";
            radioButton9.UseVisualStyleBackColor = false;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.BackColor = SystemColors.ActiveCaption;
            radioButton8.Enabled = false;
            radioButton8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            radioButton8.ForeColor = Color.ForestGreen;
            radioButton8.Location = new Point(3, 217);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(53, 17);
            radioButton8.TabIndex = 7;
            radioButton8.TabStop = true;
            radioButton8.Text = "8000";
            radioButton8.UseVisualStyleBackColor = false;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.BackColor = SystemColors.ActiveCaption;
            radioButton7.Enabled = false;
            radioButton7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            radioButton7.ForeColor = Color.ForestGreen;
            radioButton7.Location = new Point(3, 240);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(53, 17);
            radioButton7.TabIndex = 6;
            radioButton7.TabStop = true;
            radioButton7.Text = "4000";
            radioButton7.UseVisualStyleBackColor = false;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.BackColor = SystemColors.ActiveCaption;
            radioButton6.Enabled = false;
            radioButton6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            radioButton6.ForeColor = Color.ForestGreen;
            radioButton6.Location = new Point(3, 263);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(53, 17);
            radioButton6.TabIndex = 5;
            radioButton6.TabStop = true;
            radioButton6.Text = "2000";
            radioButton6.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.BackColor = Color.Aqua;
            radioButton5.Enabled = false;
            radioButton5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            radioButton5.ForeColor = Color.ForestGreen;
            radioButton5.Location = new Point(3, 286);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(53, 17);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "1000";
            radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = SystemColors.ActiveCaption;
            radioButton4.Enabled = false;
            radioButton4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            radioButton4.ForeColor = Color.ForestGreen;
            radioButton4.Location = new Point(3, 309);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(46, 17);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "500";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = SystemColors.ActiveCaption;
            radioButton3.Enabled = false;
            radioButton3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            radioButton3.ForeColor = Color.ForestGreen;
            radioButton3.Location = new Point(3, 332);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(46, 17);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "300";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = SystemColors.ActiveCaption;
            radioButton2.Enabled = false;
            radioButton2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            radioButton2.ForeColor = Color.ForestGreen;
            radioButton2.Location = new Point(3, 355);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(46, 17);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "200";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = SystemColors.ActiveCaption;
            radioButton1.Enabled = false;
            radioButton1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            radioButton1.ForeColor = Color.ForestGreen;
            radioButton1.Location = new Point(3, 378);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(46, 17);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "100";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(4, 3);
            button1.Name = "button1";
            button1.Size = new Size(70, 50);
            button1.TabIndex = 15;
            button1.Text = "50 на 50";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(834, 661);
            Controls.Add(panel1);
            Controls.Add(answerTextButton4);
            Controls.Add(answerTextButton3);
            Controls.Add(answerTextButton2);
            Controls.Add(answerTextButton1);
            Controls.Add(questionTextLabel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GameForm";
            Text = "Кто хочет стать миллионером";
            Load += GameForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label questionTextLabel;
        private Button answerTextButton1;
        private Button answerTextButton2;
        private Button answerTextButton3;
        private Button answerTextButton4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private RadioButton radioButton15;
        private RadioButton radioButton14;
        private RadioButton radioButton13;
        private RadioButton radioButton12;
        private RadioButton radioButton11;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
    }
}
