using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackVratsa.Database.Interfaces;
using HackVratsa.Models.Enums;
using HackVratsa.Models.Matriculation;
using HackVratsa.Models.Matriculation.Interfaces;

namespace HackVratsa
{
    public partial class TestForm : Form
    {
        private int CurrentQuestionIndex;
        private Matura matura;
        private IDatabase database;

        public TestForm(Matura matura, IDatabase database)
        {
            this.InitializeComponent();

            this.database = database;

            this.matura = matura;

            this.CurrentQuestionIndex = 0;

            this.ShowQuestion(matura);
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
        }

        private void PreviousQuestionButton_Click(object sender, EventArgs e)
        {
            if (this.CurrentQuestionIndex > 0)
            {
                this.CurrentQuestionIndex--;
            }

            this.ShowQuestion(this.matura);
        }

        private void ShowQuestion(Matura matura)
        {
            this.questionLabel.Text = matura.Questions[this.CurrentQuestionIndex].QuestionText;
            this.answerOneCheckButton.Text = matura.Questions[this.CurrentQuestionIndex].Answers[0].Text;
            this.answerTwoCheckButton.Text = matura.Questions[this.CurrentQuestionIndex].Answers[1].Text;
            this.answerTreeCheckButton.Text = matura.Questions[this.CurrentQuestionIndex].Answers[2].Text;
            this.answerFourCheckButton.Text = matura.Questions[this.CurrentQuestionIndex].Answers[3].Text;

            this.answerOneCheckButton.Checked = matura.Questions[this.CurrentQuestionIndex].Answers[0].isChecked;
            this.answerTwoCheckButton.Checked = matura.Questions[this.CurrentQuestionIndex].Answers[1].isChecked;
            this.answerTreeCheckButton.Checked = matura.Questions[this.CurrentQuestionIndex].Answers[2].isChecked;
            this.answerFourCheckButton.Checked = matura.Questions[this.CurrentQuestionIndex].Answers[3].isChecked;
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            if (this.CurrentQuestionIndex < this.matura.Questions.Length - 1)
            {
                this.CurrentQuestionIndex++;
            }
            this.ShowQuestion(this.matura);
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            this.CalculateGrade();


            this.Hide();
            Form finialForm = new FinalForm(this.database, this.matura.Questions.Length);
            finialForm.ShowDialog();
            this.Dispose();
        }

        private void CalculateGrade()
        {
            foreach (var question in this.matura.Questions)
            {
                switch (question.CorrectAnswer)
                {
                    case "А":
                        if (question.Answers[0].isChecked)
                        {
                            this.database.UserPoints++;
                        }
                        break;
                    case "Б":
                        if (question.Answers[1].isChecked)
                        {
                            this.database.UserPoints++;
                        }
                        break;
                    case "В":
                        if (question.Answers[2].isChecked)
                        {
                            this.database.UserPoints++;
                        }
                        break;
                    case "Г":
                        if (question.Answers[3].isChecked)
                        {
                            this.database.UserPoints++;
                        }
                        break;
                }
            }
        }

        private void DoMagic(object sender, EventArgs e)
        {
            this.matura.Questions[this.CurrentQuestionIndex].Answers[0].isChecked = this.answerOneCheckButton.Checked;
        }

        private void DoMagic2(object sender, EventArgs e)
        {
            this.matura.Questions[this.CurrentQuestionIndex].Answers[1].isChecked = this.answerTwoCheckButton.Checked;
        }

        private void DoMagic3(object sender, EventArgs e)
        {
            this.matura.Questions[this.CurrentQuestionIndex].Answers[2].isChecked = this.answerTreeCheckButton.Checked;
        }

        private void DoMagic4(object sender, EventArgs e)
        {
            this.matura.Questions[this.CurrentQuestionIndex].Answers[3].isChecked = this.answerFourCheckButton.Checked;
        }
    }
}
