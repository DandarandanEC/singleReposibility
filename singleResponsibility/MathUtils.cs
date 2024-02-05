using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleResponsibility
{
    class MathUtils
    {
        public int getSummationOfGrades(int[] grades)
        {
            return grades.Sum();
        }

        public decimal getQuotientOfGrade(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
    }
}
