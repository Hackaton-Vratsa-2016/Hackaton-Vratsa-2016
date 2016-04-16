using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackVratsa.Models.Questions.Interfaces;

namespace HackVratsa.Database
{
    public class Database : IDatabase
    {
        private IList<IList<IQuestion>> englishQuestionsList;
        private IList<IList<IQuestion>> mathQuestionsList;
        private IList<IList<IQuestion>> physicsQuestionList;
        private IList<IList<IQuestion>> historyQuestionsList;
        private IList<IList<IQuestion>> geographyQuestionsList;
        private IList<IList<IQuestion>> chemistryQuestionsList;

        public Database(
            IList<IList<IQuestion>> bulgarianQuestionsList,
            IList<IList<IQuestion>> englishQuestionsList,
            IList<IList<IQuestion>> mathQuestionsList,
            IList<IList<IQuestion>> physicsQuestionsList,
            IList<IList<IQuestion>> historyQuestionsList,
            IList<IList<IQuestion>> geographyQuestionsList,
            IList<IList<IQuestion>> chemistryQuestionsList)
        {
            this.BulgarianQuestionsList = bulgarianQuestionsList;
            this.EnglishQuestionsList = englishQuestionsList;
            this.MathQuestionsList = mathQuestionsList;
            this.PhysicsQuestionsList = physicsQuestionsList;
            this.HistoryQuestionsList = historyQuestionsList;
            this.GeographyQuestionsList = geographyQuestionsList;
            this.ChemistryQuestionsList = chemistryQuestionsList;
        }

        public IList<IList<IQuestion>> BulgarianQuestionsList { get; set; }

        public IList<IList<IQuestion>> EnglishQuestionsList { get; set; }

        public IList<IList<IQuestion>> MathQuestionsList { get; set; }

        public IList<IList<IQuestion>> PhysicsQuestionsList { get; set; }

        public IList<IList<IQuestion>> HistoryQuestionsList { get; set; }

        public IList<IList<IQuestion>> GeographyQuestionsList { get; set; }

        public IList<IList<IQuestion>> ChemistryQuestionsList { get; set; }
    }
}
