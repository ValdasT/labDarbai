using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsList = new List<Students>();
            bool insertStudent = true;
            while (insertStudent)
            {
                insertStudent = insertStudentsByHand(studentsList);
            }
        }
        private static bool insertStudentsByHand( List<Students> studentsList)
        {
            if(studentsList.Count == 0){
                 Console.WriteLine("(y) - Ivesti pirmo studento duomenis?");
            }else{
                 Console.WriteLine("(y) - Ivesti kito studento duomenis?");
                 Console.WriteLine("(v) - Spausdinti studento duomenis su vidurkiais?");
                 Console.WriteLine("(m) - Spausdinti studento duomenis su medianomis?");
            }
            Console.WriteLine("(x) - Exit");
            switch (Console.ReadLine())
            {
                case "y":
                    ByHand(studentsList);
                    return true;
                case "v":
                    Printer.DisplayWithAverage(studentsList);
                    return true;
                case "m":
                    Printer.DisplayWithMedian(studentsList);
                    return true;
                case "x":
                    return false;
                default:
                    return true;
            }
        }
        private static void ByHand(List<Students> studentsList)
        {
            Console.Clear();
            Console.WriteLine("Iveskite studento varda:");
            string name = Console.ReadLine();
            Console.WriteLine("Iveskite studento pavarde:");
            string sureName = Console.ReadLine();
            var Student = new Students(name, sureName);
            int homeWorkAmount = insertArraySize();
            var homeWorkMarks = new double[homeWorkAmount];
            for (int i = 0; i < homeWorkAmount; i++){
                homeWorkMarks[i] = insertHomeWorkMark();
            }
            Student.SetStudentGrades(homeWorkMarks.ToList());
            var finalMark = insertFinalMark();
            Student.FinalGrade = finalMark;
            studentsList.Add(Student);
        }

        public static int insertArraySize()
        {
            Console.WriteLine("Iveskite studento namu darbu kieki:");
            try
            {
                var x = int.Parse(Console.ReadLine());
                return x;
            }
            catch (FormatException)
            {
                Console.WriteLine("Skaicius gali buti tik sveikasis");
                insertArraySize();
                return 0;
            }
        }

        public static double insertHomeWorkMark()
        {
            Console.WriteLine("Iveskite studento namu darbu pazimi:");
            try
            {
                var mark = double.Parse(Console.ReadLine());
                return mark;
            }
            catch (FormatException)
            {
                Console.WriteLine("Skaicius gali buti sveikasis arba double tipo");
                insertHomeWorkMark();
                return 0;
            }
        }

        
        public static double insertFinalMark()
        {
            Console.WriteLine("Iveskite studento egzamino pazimi:");
            try
            {
                var mark = double.Parse(Console.ReadLine());
                return mark;
            }
            catch (FormatException)
            {
                Console.WriteLine("Skaicius gali buti sveikasis arba double tipo");
                insertFinalMark();
                return 0;
            }
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nAtsakymas yra: {message}");
            Console.Write("\r\nSpausti Enter, kad grizti i meniu.");
            Console.ReadLine();
        }

    }
}