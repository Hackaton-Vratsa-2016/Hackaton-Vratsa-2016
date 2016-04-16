using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackVratsa.Models.Enums;

namespace HackVratsa.Controller.Interfaces
{
    public interface IController
    {
        void GenerateMatriculation(GradeType gradeType, SubjectType subjectType);
    }
}
