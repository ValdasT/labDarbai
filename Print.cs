using System;
using System.Collections.Generic;

namespace MyApp
{
    public class Printer
    {
        public static void DisplayWithAverage(List<Students> studentsList)
        {
            Console.WriteLine();
            Console.WriteLine("Vardas   Pavarde     Galutinis (Vid.)");
            Console.WriteLine("-------------------------------------");
            foreach (var student in studentsList)
            {
                string row = "";
                foreach (var element in student.GetDataAverage()){
                    row += element+ "   "; 
                }
                Console.WriteLine(row);
            }
        }

        public static void DisplayWithMedian(List<Students> studentsList)
        {
            Console.WriteLine();
            Console.WriteLine("Vardas   Pavarde     Galutinis (Med.)");
            Console.WriteLine("-------------------------------------");
            foreach (var student in studentsList)
            {
                string row = "";
                foreach (var element in student.GetDataMedian()){
                    row += element+ "   "; 
                }
                Console.WriteLine(row);
            }
        }
    }
}
