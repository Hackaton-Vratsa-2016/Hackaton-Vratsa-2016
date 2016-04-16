namespace HackVratsa
{
    partial class TestForm
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerOneButton = new System.Windows.Forms.Button();
            this.answerTwoButton = new System.Windows.Forms.Button();
            this.answerTreeButton = new System.Windows.Forms.Button();
            this.answerFourButton = new System.Windows.Forms.Button();
            this.PreviousQuestionButton = new System.Windows.Forms.Button();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(97, 48);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(49, 13);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Question";
            // 
            // answerOneButton
            // 
            this.answerOneButton.Location = new System.Drawing.Point(12, 127);
            this.answerOneButton.Name = "answerOneButton";
            this.answerOneButton.Size = new System.Drawing.Size(450, 100);
            this.answerOneButton.TabIndex = 1;
            this.answerOneButton.Text = "button1";
            this.answerOneButton.UseVisualStyleBackColor = true;
            this.answerOneButton.Click += new System.EventHandler(this.answerOneButton_Click);
            // 
            // answerTwoButton
            // 
            this.answerTwoButton.Location = new System.Drawing.Point(522, 127);
            this.answerTwoButton.Name = "answerTwoButton";
            this.answerTwoButton.Size = new System.Drawing.Size(450, 100);
            this.answerTwoButton.TabIndex = 2;
            this.answerTwoButton.Text = "button2";
            this.answerTwoButton.UseVisualStyleBackColor = true;
            // 
            // answerTreeButton
            // 
            this.answerTreeButton.Location = new System.Drawing.Point(12, 247);
            this.answerTreeButton.Name = "answerTreeButton";
            this.answerTreeButton.Size = new System.Drawing.Size(450, 100);
            this.answerTreeButton.TabIndex = 3;
            this.answerTreeButton.Text = "button3";
            this.answerTreeButton.UseVisualStyleBackColor = true;
            // 
            // answerFourButton
            // 
            this.answerFourButton.Location = new System.Drawing.Point(522, 247);
            this.answerFourButton.Name = "answerFourButton";
            this.answerFourButton.Size = new System.Drawing.Size(450, 100);
            this.answerFourButton.TabIndex = 4;
            this.answerFourButton.Text = "button4";
            this.answerFourButton.UseVisualStyleBackColor = true;
            // 
            // PreviousQuestionButton
            // 
            this.PreviousQuestionButton.Location = new System.Drawing.Point(12, 372);
            this.PreviousQuestionButton.Name = "PreviousQuestionButton";
            this.PreviousQuestionButton.Size = new System.Drawing.Size(450, 50);
            this.PreviousQuestionButton.TabIndex = 5;
            this.PreviousQuestionButton.Text = "Предишен въпрос";
            this.PreviousQuestionButton.UseVisualStyleBackColor = true;
            this.PreviousQuestionButton.Click += new System.EventHandler(this.PreviousQuestionButton_Click);
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Location = new System.Drawing.Point(522, 372);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(450, 50);
            this.NextQuestionButton.TabIndex = 6;
            this.NextQuestionButton.Text = " Следващ въпрос";
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.PreviousQuestionButton);
            this.Controls.Add(this.answerFourButton);
            this.Controls.Add(this.answerTreeButton);
            this.Controls.Add(this.answerTwoButton);
            this.Controls.Add(this.answerOneButton);
            this.Controls.Add(this.questionLabel);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button answerOneButton;
        private System.Windows.Forms.Button answerTwoButton;
        private System.Windows.Forms.Button answerTreeButton;
        private System.Windows.Forms.Button answerFourButton;
        private System.Windows.Forms.Button PreviousQuestionButton;
        private System.Windows.Forms.Button NextQuestionButton;
    }
}