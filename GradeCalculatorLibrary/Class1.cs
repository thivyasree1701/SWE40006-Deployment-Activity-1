using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculatorLibrary
{
    public class GradeService
    {
        public static string GetGrade(int mark)
        {
            if (mark >= 80)
                return "HD";
            else if (mark >= 70)
                return "D";
            else if (mark >= 60)
                return "C";
            else if (mark >= 50)
                return "P";
            else
                return "N";
        }
    }
}