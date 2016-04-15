using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackVratsa.Models.Interfaces;
using HackVratsa.Models.Questions.Interfaces;

namespace HackVratsa.Models.Subjests.Intefaces
{
    public interface ISubject : INamealbe
    {
        IList<IQuestion> Questions { get; }

        void AddQuestion(IQuestion question);

        void GenerateMatriculation();
    }
}
