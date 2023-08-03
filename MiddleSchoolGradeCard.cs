using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class MiddleSchoolGradeCard : BasicGradeCard
    {
        public int MathMarks { get; set; }
        public int ScienceMarks { get; set; }
        public int HistoryMarks { get; set; }

        public MiddleSchoolGradeCard(string studentName, int mathMarks, int scienceMarks, int historyMarks)
            : base(studentName, mathMarks + scienceMarks + historyMarks)
        {
            MathMarks = mathMarks;
            ScienceMarks = scienceMarks;
            HistoryMarks = historyMarks;
        }

        public override void DisplayGradeCard()
        {
            base.DisplayGradeCard();
            Console.WriteLine("Math Marks: " + MathMarks);
            Console.WriteLine("Science Marks: " + ScienceMarks);
            Console.WriteLine("History Marks: " + HistoryMarks);
        }
    }

}
