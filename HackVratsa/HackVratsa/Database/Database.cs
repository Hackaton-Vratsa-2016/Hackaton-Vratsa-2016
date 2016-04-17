using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackVratsa.Database.Interfaces;

namespace HackVratsa.Database
{
    public class Database : IDatabase
    {
        private int userPoints;

        public Database()
        {
            this.userPoints = 0;
        }

        public int UserPoints
        {
            get { return this.userPoints; }
            set {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Users points cannot be null!");
                }
                this.userPoints = value;
            }
        }
    }
}
