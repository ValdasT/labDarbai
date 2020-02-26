﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

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
        private static bool insertStudentsByHand(List<Students> studentsList)
        {
            if (studentsList.Count == 0)
            {
                Console.WriteLine("(y) - Ivesti studentu duomenis ranka?");
                Console.WriteLine("(f) - Gauti studentu duomenis is failo?");
            }
            else
            {
                Console.WriteLine("(y) - Ivesti kito studento duomenis?");
                Console.WriteLine("(f) - Pakartoti studentu duomenis is failo?");
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
                case "f":
                    insertDataFromFile(studentsList);
                    return true;
                case "x":
                    return false;
                default:
                    return true;
            }
        }

        private static char selectDataInsertion()
        {
            Console.WriteLine("Ivesti duomenis ranka spausti \"r\"");
            Console.WriteLine("Generuoti duomenis spausti \"g\"");
            Console.WriteLine("(x) - Exit");
            switch (Console.ReadLine())
            {
                case "r":
                    return 'r';
                case "g":
                    return 'g';
                default:
                    return 'r';
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
            if (selectDataInsertion() == 'r')
            {
                for (int i = 0; i < homeWorkAmount; i++)
                {
                    homeWorkMarks[i] = insertHomeWorkMark();
                }
                Student.SetStudentGrades(homeWorkMarks.ToList());
                var finalMark = insertFinalMark();
                Student.FinalGrade = finalMark;
            }
            else
            {
                Student.AddRandomData(homeWorkAmount);
            }
            studentsList.Add(Student);
        }

        public static int insertArraySize()
        {
            Console.Clear();
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
            Console.WriteLine("Iveskite studento namu darbu pazymi:");
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
            Console.WriteLine("Iveskite studento egzamino pazymi:");
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

        private static void insertDataFromFile(List<Students> studentsList)
        {
            Console.Clear();
            double grade = 0.0;
            foreach (string line in File.ReadLines("./kursiokai.txt").Skip(1))
            {
                var elements = line.Split(' ').ToArray();
                var homeWorkMarks = new double[(elements.Length) - 3];
                var finalMark = 0.0;
                var counter = 0;
                foreach (var it in elements.Select((x, i) => new { Value = x, Index = i }))
                {
                    if (it.Index != 0 && it.Index != 1 && it.Index != elements.Length - 1)
                    {
                        if (double.TryParse(it.Value, out grade))
                        {
                            homeWorkMarks[counter] = grade;
                            counter++;
                        }
                    }
                    if (it.Index == elements.Length - 1)
                    {
                        if (double.TryParse(it.Value, out grade))
                        {
                            finalMark = grade;
                        }
                    }
                }
                var Student = new Students(elements[0], elements[1]);
                Student.SetStudentGrades(homeWorkMarks.ToList());
                Student.FinalGrade = finalMark;
                studentsList.Add(Student);
            }
            // ThenByDescending ; OrderBy
            studentsList = studentsList.OrderBy(x => x.Name).OrderBy(x => x.SureName).ToList();
            Printer.DisplayAverageAndMedian(studentsList);
        }
    }
}