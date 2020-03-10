using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    public class Printer
    {

        public static void DisplayWithAverage(List<Students> studentsList)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Vardas   Pavarde     Galutinis (Vid.)");
            Console.WriteLine("-------------------------------------");
            foreach (var student in studentsList)
            {
                string row = "";
                foreach (var element in student.GetDataAverage())
                {
                    row += element + "   ";
                }
                Console.WriteLine(row);
            }
        }

        public static void DisplayWithMedian(List<Students> studentsList)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Vardas   Pavarde     Galutinis (Med.)");
            Console.WriteLine("-------------------------------------");
            foreach (var student in studentsList)
            {
                string row = "";
                foreach (var element in student.GetDataMedian())
                {
                    row += element + "   ";
                }
                Console.WriteLine(row);
            }
        }

        public static void DisplayAverageAndMedian(List<Students> studentsList)
        {
            Console.Clear();
            // ThenByDescending ; OrderBy
            studentsList = studentsList.OrderBy(x => x.Name).OrderBy(x => x.SureName).ToList();
            Console.WriteLine();
            printLine("Vardas", "Pavarde", "Galutinis (Vid.)", "Galutinis (Med.)");
            Console.WriteLine(new string('-', 100));
            foreach (var student in studentsList)
            {
                printLine(student.Name, student.SureName, $"{student.GetAverageMark():0.00}", $"{student.GetMedianMark():0.00}");
            }
        }

        public static void printLine(params string[] line)
        {
            int size = 100 / line.Length;
            string row = "";

            foreach (string element in line)
            {
                row += element.PadRight(size - (size - element.Length) / 2).PadLeft(size);
            }
            Console.WriteLine(row);
        }
        public static string returnLine(params string[] line)
        {
            int size = 100 / line.Length;
            string row = "";

            foreach (string element in line)
            {
                row += element.PadRight(size - (size - element.Length) / 2).PadLeft(size);
            }
            return row;
        }
    }
}
