using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackVratsa.Models.Questions;
using HackVratsa.Models.Questions.Interfaces;

namespace HackVratsa
{
    public interface IDatabase
    {
        IList<IList<IQuestion>> BulgarianQuestionsList { get; }

        IList<IList<IQuestion>> EnglishQuestionsList { get; }
    
        IList<IList<IQuestion>> MathQuestionsList { get; }

        IList<IList<IQuestion>> PhysicsQuestionsList { get; }

        IList<IList<IQuestion>> HistoryQuestionsList { get; }

        IList<IList<IQuestion>> GeographyQuestionsList { get; }

        IList<IList<IQuestion>> ChemistryQuestionsList { get; }
    }
}
