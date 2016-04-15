using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackVratsa.Models.Questions.Interfaces;

namespace HackVratsa.Models.Questions.QuestionTypes
{
    public class QuestionOpenAnswer : QuestionBase
    {
        public QuestionOpenAnswer(string correctAnswer, string questionText, int category, int points) 
            : base(correctAnswer, questionText, category, points)
        {

        }
    }
}
