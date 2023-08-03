using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class ElementarySchoolGradeCard : BasicGradeCard
    {

        public int MathMarks { get; set; }
        public int ScienceMarks { get; set; }

        public ElementarySchoolGradeCard(string studentName, int mathMarks, int scienceMarks)
            : base(studentName, mathMarks + scienceMarks)
        {
            MathMarks = mathMarks;
            ScienceMarks = scienceMarks;
        }

        public override void DisplayGradeCard()
        {
            base.DisplayGradeCard();
            Console.WriteLine("Math Marks: " + MathMarks);
            Console.WriteLine("Science Marks: " + ScienceMarks);
        }
    }

}

