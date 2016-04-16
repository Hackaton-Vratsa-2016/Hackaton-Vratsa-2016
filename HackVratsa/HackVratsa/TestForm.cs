using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackVratsa.Models.Enums;
using HackVratsa.Models.Matriculation;
using HackVratsa.Models.Matriculation.Interfaces;

namespace HackVratsa
{
    public partial class TestForm : Form
    {
        private int CurrentQuestionIndex;
        private IMatriculation matriculation;

        public TestForm(IMatriculation matriculation)
        {
            this.InitializeComponent();

            this.matriculation = matriculation;

            this.CurrentQuestionIndex = 0;

            this.ShowQuestion(matriculation);
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
        }

        private void answerOneButton_Click(object sender, EventArgs e)
        {

        }

        private void PreviousQuestionButton_Click(object sender, EventArgs e)
        {
            if (this.CurrentQuestionIndex > 0)
            {
                this.CurrentQuestionIndex--;
            }

            this.ShowQuestion(this.matriculation);
        }

        private void ShowQuestion(IMatriculation matriculation)
        {
            this.questionLabel.Text = matriculation.Questions[this.CurrentQuestionIndex].QuestionText;
            this.answerOneCheckButton.Text = matriculation.Questions[this.CurrentQuestionIndex].AnswersList[0];
            this.answerTwoCheckButton.Text = matriculation.Questions[this.CurrentQuestionIndex].AnswersList[1];
            this.answerTreeCheckButton.Text = matriculation.Questions[this.CurrentQuestionIndex].AnswersList[2];
            this.answerFourCheckButton.Text = matriculation.Questions[this.CurrentQuestionIndex].AnswersList[3];
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            if (this.CurrentQuestionIndex < 30)
            {
                this.CurrentQuestionIndex++;
            }
            this.ShowQuestion(this.matriculation);
        }
    }
}
