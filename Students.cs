using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    public class Students
    {
        List<double> studentGrades;
        public string Name { get; set; }
        public string SureName { get; set; }
        public double FinalGrade { get; set; } = 0.0;
        public Students(string name, string surname)
        {
            Name = name;
            SureName = surname;
            studentGrades = new List<double>();
        }

        public void SetStudentGrades(List<double> grades)
        {
            this.studentGrades = grades;
        }

        public double GetAverageMark()
        {
            if(studentGrades.Count == 0)
            {
                return FinalGrade * 0.7;
            }

            return (studentGrades.Sum() / studentGrades.Count) * 0.3 + FinalGrade * 0.7;
        }

        public double GetMedianMark()
        {
            if(studentGrades.Count == 0)
            {
                return FinalGrade * 0.7;
            }

            studentGrades.Sort();

            if (studentGrades.Count % 2 == 0 && studentGrades.Count >= 2)
            {
                int i = (int)((double)(studentGrades.Count - 2) / 2);
                return ((studentGrades[i] + studentGrades[i + 1])/2.0) * 0.3 + FinalGrade * 0.7;
            }

            int middle = (int)Math.Floor((double)studentGrades.Count / 2.0);
            return studentGrades[middle] * 0.3 + FinalGrade * 0.7;
        }

        public string[] GetDataAverage()
        {
            return new string[] {Name, SureName, $"{GetAverageMark():0.00}" };
        }

         public string[] GetDataMedian()
        {
            return new string[] {Name, SureName, $"{GetMedianMark():0.00}" };
        }
    }
}
