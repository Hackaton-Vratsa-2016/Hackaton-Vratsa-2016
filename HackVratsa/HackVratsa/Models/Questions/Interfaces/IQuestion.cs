using HackVratsa.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackVratsa.Models.Questions.Interfaces
{
    public interface IQuestion
    {
        string QuestionText { get; set; }

        string QuestionId { get; set; }

        List<Answer> Answers { get; set; }

        string CorrectAnswer { get; set; }

        int Points { get; set; }
    }
}
