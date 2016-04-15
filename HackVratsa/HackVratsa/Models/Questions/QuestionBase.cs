using HackVratsa.Models.Questions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackVratsa.Models.Enums;

namespace HackVratsa.Models.Questions
{
    public abstract class QuestionBase : IQuestion
    {
        private string correctAnswer;
        private string questionText;
        private int points;
        private int category;
        
        protected QuestionBase(string correctAnswer, string questionText, int category, int points)
        {
            this.CorrectAnswer = correctAnswer;
            this.QuestionText = questionText;
            this.Category = category;
            this.Points = points;
        }

        public int Category
        {
            get { return this.category; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Category cannot be negative or zero!");
                }
                this.category = value;
            }
        }

        public string QuestionText
        {
            get { return this.questionText; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Question text cannot be null or white-space!");
                }
                this.questionText = value;
            }
        }

        public int Points
        {
            get { return this.points; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Points cannot be negative or zero!");
                }
                this.points = value;
            }
        }

        public string CorrectAnswer
        {
            get { return this.correctAnswer; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Correct answer cannot be null or white-space!");
                }
                this.correctAnswer = value;
            }
        }
    }
}
