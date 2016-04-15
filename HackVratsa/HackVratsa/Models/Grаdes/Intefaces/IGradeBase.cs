using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackVratsa.Models.Interfaces;
using HackVratsa.Models.Subjests.Intefaces;

namespace HackVratsa.Models.Garades.Intefaces
{
    public interface IGradeBase : INamealbe
    {
        IList<ISubject> Subjects { get; }
    }
}
