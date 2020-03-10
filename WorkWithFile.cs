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
        public static void CreateFiles()
        {
            int[] size = new int[] { 10, 100, 1000, 10000, 100000 };

            foreach (var e in size)
            {
                var timer = new System.Diagnostics.Stopwatch();
                timer.Start();
                var vargs = new List<Students>();
                var kiet = new List<Students>();
                var visi = new List<Students>();

                for (int i = 0; i < e; i++)
                {
                    var student = new Students($"Vardas{i}", $"Pavarde{i}");
                    student.AddRandomData(5);

                    if (student.GetAverageMark() < 5)
                    {
                        vargs.Add(student);
                        visi.Add(student);
                    }
                    else
                    {
                        kiet.Add(student);
                        visi.Add(student);
                    }
                }

                SaveInFile(Path.Combine($"vargsiukai-{e}.txt"), vargs);
                SaveInFile(Path.Combine($"kietiakai-{e}.txt"), kiet);
                SaveInFile(Path.Combine($"visi-{e}.txt"), visi);
                timer.Stop();
                Console.WriteLine($"{e} irasu sukurta per ---> {timer.Elapsed}");
            }
        }

        public static void SaveInFile(string fileName, List<Students> studentsList)
        {
            System.IO.StreamWriter file;
            try
            {
                file = new System.IO.StreamWriter("files/" + fileName);
            }
            catch (Exception err)
            {
                Console.WriteLine("Netinkama failo vieta.{0}", err);
                return;
            }
            file.WriteLine(Printer.returnLine("Vardas", "Pavarde", "Galutinis (Vid.)"));

            foreach (var student in studentsList)
            {
                file.WriteLine(Printer.returnLine(student.Name, student.SureName, $"{student.GetAverageMark():0.00}"));
            }
            file.Close();
        }

        public static Students ReadInfoFromFile(string line)
        {
            var args = line.Split().Where(x => !x.Equals("")).ToArray();
            var student = new Students(args[0], args[1], double.Parse(args[2]));
            return student;
        }

        public static void SpeedTest()
        {
            var folderOfFiles = new DirectoryInfo("files/");
            var files = folderOfFiles.GetFiles().ToList().Where(file => (file.FullName != null && file.FullName.Contains("visi"))).OrderBy(file => file.Length);
            foreach (var file in files)
            {
            Console.WriteLine($"failas: {file.Name}");
            Console.WriteLine($"Su listu greitis: {testListSpeed(file.FullName)}");
            Console.WriteLine($"---------------------------------------------");
            }
        }
        public static TimeSpan testListSpeed(string fileName)
        {
            var timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            var studentsList = new List<Students>();
            var vargs = new List<Students>();
            var kiet = new List<Students>();
            foreach (string line in File.ReadLines(fileName).Skip(1))
            {
                studentsList.Add(ReadInfoFromFile(line));
            }
            for (int i = 0; i < studentsList.Count; i++)
            {
                if (studentsList[i].getCalculatedGrades() < 5)
                {
                    vargs.Add(studentsList[i]);
                }
                else
                {
                    kiet.Add(studentsList[i]);
                }
            }

            timer.Stop();
            return timer.Elapsed;
        }
    }
}
