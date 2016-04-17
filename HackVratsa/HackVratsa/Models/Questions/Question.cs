namespace HackVratsa
{
    using System.Collections.Generic;
    using Models.Questions.Interfaces;

    public class Question : IQuestion
    {
        public string QuestionText { get; set; }

        public string QuestionId { get; set; }

        public List<Answer> Answers { get; set; }

        public string CorrectAnswer { get; set; }
        
        public string SelectedAnswerId { get; set; }

        public int Points { get; set; }
    }
}