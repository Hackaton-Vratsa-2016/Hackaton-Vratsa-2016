﻿using System;
using System.Collections.Generic;
using HackVratsa.Models.Matriculation.Interfaces;
using HackVratsa.Models.Questions.Interfaces;

namespace HackVratsa.Models.Matriculation
{
    public abstract class Matriculation : IMatriculation
    {
        private int points;
        private int time;
        private IDictionary<IQuestion> questions;

        protected Matriculation(int time)
        {
            this.Points = 0;
            this.Questions = new List<IQuestion>();
            this.Time = time;
        }

        public int Time
        {
            get { return this.time; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Time cannot be negative or zero!");
                }
                this.time = value;
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

        public IList<IQuestion> Questions
        {
            get { return this.questions; }
            set { this.questions = value; }
        }
        
        public void CalculateRating()
        {
            throw new NotImplementedException();
        }

        public void AddQuestion(IQuestion question)
        {
            throw new NotImplementedException();
        }

        private void AddPoints(IQuestion question)
        {
            throw new NotImplementedException();
        }
    }
}
