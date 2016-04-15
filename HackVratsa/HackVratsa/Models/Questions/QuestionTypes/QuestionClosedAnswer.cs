using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackVratsa.Models.Questions.Interfaces;

namespace HackVratsa.Models.Questions.QuestionTypes
{
    public class QuestionClosedAnswer : QuestionBase, IClosedAnswers
    {
        private IList<string> answers;

        public QuestionClosedAnswer(
            string correctAnswer,
            string questionText,
            int category,
            int points,
            IList<string> answersList) 
            : base(correctAnswer, questionText, category, points)
        {
            this.Answers = answersList;
        }

        public IList<string> Answers
        {
            get { return this.answers; }
            set
            {
                if (value.Any(answer => string.IsNullOrWhiteSpace(answer) || string.IsNullOrEmpty(answer)))
                {
                    throw new ArgumentNullException("Answer cannot be null or white-space!");
                }
                this.answers = value;
            }
        }
    }
}
