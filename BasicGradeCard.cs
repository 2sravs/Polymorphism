using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    
    public class BasicGradeCard
    {
        public string StudentName { get; set; }
        public int TotalMarks { get; set; }

        public BasicGradeCard(string studentName, int totalMarks)
        {
            StudentName = studentName;
            TotalMarks = totalMarks;
        }

        public virtual void DisplayGradeCard()
        {
            Console.WriteLine("----- Grade Card -----");
            Console.WriteLine("Student Name: " + StudentName);
            Console.WriteLine("Total Marks: " + TotalMarks);
        }
    }

}
