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
            this.PreviousQuestionButton = new System.Windows.Forms.Button();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.answerOneCheckButton = new System.Windows.Forms.CheckBox();
            this.answerTreeCheckButton = new System.Windows.Forms.CheckBox();
            this.answerFourCheckButton = new System.Windows.Forms.CheckBox();
            this.answerTwoCheckButton = new System.Windows.Forms.CheckBox();
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
            // PreviousQuestionButton
            // 
            this.PreviousQuestionButton.Location = new System.Drawing.Point(22, 354);
            this.PreviousQuestionButton.Name = "PreviousQuestionButton";
            this.PreviousQuestionButton.Size = new System.Drawing.Size(450, 50);
            this.PreviousQuestionButton.TabIndex = 5;
            this.PreviousQuestionButton.Text = "Предишен въпрос";
            this.PreviousQuestionButton.UseVisualStyleBackColor = true;
            this.PreviousQuestionButton.Click += new System.EventHandler(this.PreviousQuestionButton_Click);
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Location = new System.Drawing.Point(502, 354);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(450, 50);
            this.NextQuestionButton.TabIndex = 6;
            this.NextQuestionButton.Text = " Следващ въпрос";
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // answerOneCheckButton
            // 
            this.answerOneCheckButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerOneCheckButton.Location = new System.Drawing.Point(22, 127);
            this.answerOneCheckButton.Name = "answerOneCheckButton";
            this.answerOneCheckButton.Size = new System.Drawing.Size(450, 100);
            this.answerOneCheckButton.TabIndex = 7;
            this.answerOneCheckButton.Text = "checkBox1";
            this.answerOneCheckButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerOneCheckButton.UseVisualStyleBackColor = true;
            // 
            // answerTreeCheckButton
            // 
            this.answerTreeCheckButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerTreeCheckButton.Location = new System.Drawing.Point(22, 233);
            this.answerTreeCheckButton.Name = "answerTreeCheckButton";
            this.answerTreeCheckButton.Size = new System.Drawing.Size(450, 100);
            this.answerTreeCheckButton.TabIndex = 9;
            this.answerTreeCheckButton.Text = "checkBox2";
            this.answerTreeCheckButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerTreeCheckButton.UseVisualStyleBackColor = true;
            // 
            // answerFourCheckButton
            // 
            this.answerFourCheckButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerFourCheckButton.Location = new System.Drawing.Point(502, 233);
            this.answerFourCheckButton.Name = "answerFourCheckButton";
            this.answerFourCheckButton.Size = new System.Drawing.Size(450, 100);
            this.answerFourCheckButton.TabIndex = 10;
            this.answerFourCheckButton.Text = "checkBox3";
            this.answerFourCheckButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerFourCheckButton.UseVisualStyleBackColor = true;
            // 
            // answerTwoCheckButton
            // 
            this.answerTwoCheckButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerTwoCheckButton.Location = new System.Drawing.Point(502, 127);
            this.answerTwoCheckButton.Name = "answerTwoCheckButton";
            this.answerTwoCheckButton.Size = new System.Drawing.Size(450, 100);
            this.answerTwoCheckButton.TabIndex = 11;
            this.answerTwoCheckButton.Text = "checkBox1";
            this.answerTwoCheckButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerTwoCheckButton.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.answerTwoCheckButton);
            this.Controls.Add(this.answerFourCheckButton);
            this.Controls.Add(this.answerTreeCheckButton);
            this.Controls.Add(this.answerOneCheckButton);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.PreviousQuestionButton);
            this.Controls.Add(this.questionLabel);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button PreviousQuestionButton;
        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.CheckBox answerOneCheckButton;
        private System.Windows.Forms.CheckBox answerTreeCheckButton;
        private System.Windows.Forms.CheckBox answerFourCheckButton;
        private System.Windows.Forms.CheckBox answerTwoCheckButton;
    }
}