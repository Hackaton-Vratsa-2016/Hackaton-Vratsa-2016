using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackVratsa.Models.Questions.Interfaces;

namespace HackVratsa.Models.Matriculation.Interfaces
{
    public interface IMatriculation
    {
        int Points { get; }

        IList<IQuestion> Questions { get; }

        void CalculateRating();

        void AddQuestion(IQuestion question);
    }
}
