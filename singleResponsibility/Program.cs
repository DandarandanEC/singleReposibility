using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleResponsibility
{
    
    class Program
    {        
        private MathUtils calc = new MathUtils();
        public Grades g = new Grades();
        int[] danGrades = { 90, 95, 98, 100 };

        void calculateGrades()
        {
            g.Grade = danGrades;

            int total = calc.getSummationOfGrades(g.Grade);

            decimal average = calc.getQuotientOfGrade(total, g.Grade.Length);

            displayResult(average);
        }

        void displayResult(decimal result)
        {            
            Console.WriteLine(result.ToString());            
        }


        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Dan Grades: ");
            foreach (var print in program.danGrades)
            {
                Console.Write(print + " | ");
            }
            Console.WriteLine();
            Console.Write("Average: ");

            program.calculateGrades();

            Console.ReadLine();
        }
    }
}
