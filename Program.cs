using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BasicGradeCard gradeCard1 = new BasicGradeCard("Venky", 300);
            gradeCard1.DisplayGradeCard();
            Console.WriteLine();

            ElementarySchoolGradeCard primaryGradeCard = new ElementarySchoolGradeCard("tina", 80, 90);
            primaryGradeCard.DisplayGradeCard();
            Console.WriteLine();

            MiddleSchoolGradeCard middleGradeCard = new MiddleSchoolGradeCard("Meena", 85, 80, 90);
            middleGradeCard.DisplayGradeCard();
            Console.WriteLine();

            HighSchoolGradeCard highGradeCard = new HighSchoolGradeCard("Sam", 90, 88, 85, 92);
            highGradeCard.DisplayGradeCard();
            Console.ReadKey();
        }


    }

}


