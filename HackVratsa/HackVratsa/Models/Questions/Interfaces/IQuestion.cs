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
        string QuestionText { get; }

        int Points { get; }

        string CorrectAnswer { get; }
    }
}
