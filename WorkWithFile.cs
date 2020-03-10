using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyApp
{
    class WorkWithFile
    {
        public static void insertDataFromFile(List<Students> studentsList)
        {
            Console.Clear();
            double grade = 0.0;
            try
            {
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
                            else
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
                            else
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
                Printer.DisplayAverageAndMedian(studentsList);

            }
            catch (System.Exception)
            {
                Console.WriteLine("Blogas arba neegzistuojantis failas!");
                Console.WriteLine();
            }
        }
    }
}
