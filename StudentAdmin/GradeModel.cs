using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmin
{
    internal class GradeModel
    {             
        public double Grade; 
        public GradeModel()
        {
            
        }
        public GradeModel(double grade)
        {
            
            Grade = grade;
        }

        public void PrintGradeInfo()
        {
            Console.Write($"Grade: {Grade}\n");
        }
    }
}
