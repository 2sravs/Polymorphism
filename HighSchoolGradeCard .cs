using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class HighSchoolGradeCard : BasicGradeCard
    {

        public int MathMarks { get; set; }
        public int ScienceMarks { get; set; }
        public int HistoryMarks { get; set; }
        public int EnglishMarks { get; set; }

        public HighSchoolGradeCard(string studentName, int mathMarks, int scienceMarks, int historyMarks, int englishMarks)
            : base(studentName, mathMarks + scienceMarks + historyMarks + englishMarks)
        {
            MathMarks = mathMarks;
            ScienceMarks = scienceMarks;
            HistoryMarks = historyMarks;
            EnglishMarks = englishMarks;
        }

        public override void DisplayGradeCard()
        {
            base.DisplayGradeCard();
            Console.WriteLine("Math Marks: " + MathMarks);
            Console.WriteLine("Science Marks: " + ScienceMarks);
            Console.WriteLine("History Marks: " + HistoryMarks);
            Console.WriteLine("English Marks: " + EnglishMarks);
        }
    }    
}
