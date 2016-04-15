using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackVratsa.Models.Questions.Interfaces;
using HackVratsa.Models.Subjests.Intefaces;

namespace HackVratsa.Models.Subjests
{
    public abstract class SubjectBase : ISubject
    {
        private string name;
        private IList<IQuestion> questions;

        protected SubjectBase(string name)
        {
            this.Name = name;
            this.Questions = new List<IQuestion>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty or white-space!");
                }
                this.name = value;
            }
        }

        public IList<IQuestion> Questions { get; set; }

        public void AddQuestion(IQuestion question)
        {
            this.Questions.Add(question);
        }

        public void GenerateMatriculation()
        {
            throw new NotImplementedException();
        }
    }
}
