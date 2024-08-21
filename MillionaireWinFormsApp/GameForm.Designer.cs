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
            label1 = new Label();
            currentWinningLabel = new Label();
            SuspendLayout();
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Location = new Point(17, 57);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(200, 15);
            questionTextLabel.TabIndex = 0;
            questionTextLabel.Text = "Здесь будет текст каждого вопроса";
            // 
            // answerTextButton1
            // 
            answerTextButton1.Location = new Point(58, 113);
            answerTextButton1.Name = "answerTextButton1";
            answerTextButton1.Size = new Size(136, 23);
            answerTextButton1.TabIndex = 1;
            answerTextButton1.Text = "button1";
            answerTextButton1.UseVisualStyleBackColor = true;
            answerTextButton1.Click += answerTextButton_Click;
            // 
            // answerTextButton2
            // 
            answerTextButton2.Location = new Point(58, 156);
            answerTextButton2.Name = "answerTextButton2";
            answerTextButton2.Size = new Size(136, 23);
            answerTextButton2.TabIndex = 2;
            answerTextButton2.Text = "button2";
            answerTextButton2.UseVisualStyleBackColor = true;
            answerTextButton2.Click += answerTextButton_Click;
            // 
            // answerTextButton3
            // 
            answerTextButton3.Location = new Point(223, 113);
            answerTextButton3.Name = "answerTextButton3";
            answerTextButton3.Size = new Size(128, 23);
            answerTextButton3.TabIndex = 3;
            answerTextButton3.Text = "button3";
            answerTextButton3.UseVisualStyleBackColor = true;
            answerTextButton3.Click += answerTextButton_Click;
            // 
            // answerTextButton4
            // 
            answerTextButton4.Location = new Point(223, 156);
            answerTextButton4.Name = "answerTextButton4";
            answerTextButton4.Size = new Size(128, 23);
            answerTextButton4.TabIndex = 4;
            answerTextButton4.Text = "button4";
            answerTextButton4.UseVisualStyleBackColor = true;
            answerTextButton4.Click += answerTextButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 8);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 5;
            label1.Text = "Выигрыш: ";
            // 
            // currentWinningLabel
            // 
            currentWinningLabel.AutoSize = true;
            currentWinningLabel.Location = new Point(81, 9);
            currentWinningLabel.Name = "currentWinningLabel";
            currentWinningLabel.Size = new Size(13, 15);
            currentWinningLabel.TabIndex = 6;
            currentWinningLabel.Text = "0";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 191);
            Controls.Add(currentWinningLabel);
            Controls.Add(label1);
            Controls.Add(answerTextButton4);
            Controls.Add(answerTextButton3);
            Controls.Add(answerTextButton2);
            Controls.Add(answerTextButton1);
            Controls.Add(questionTextLabel);
            Name = "GameForm";
            Text = "Кто хочет стать миллионером";
            Load += GameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionTextLabel;
        private Button answerTextButton1;
        private Button answerTextButton2;
        private Button answerTextButton3;
        private Button answerTextButton4;
        private Label label1;
        private Label currentWinningLabel;
    }
}
