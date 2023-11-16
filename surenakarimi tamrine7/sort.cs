using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsReportCard
{
    public class Sort
    {
        private List<Student> Students;

        public Sort(List<Student> Students)
        {
            this.Students = Students;
        }

        public void SortByWritten()
        {
            double Average = 0;
            string Name = "";
            Console.Write("lotfn tedad danshamozani ra k mikhahid moratb knid vard knid: ");
            string Input = Console.ReadLine();
            Student Student = new Student("", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

            if (IsNotNull(Input) && IsInt(Input))
            {
                int Number = Convert.ToInt32(Input);
                if (Number <= Students.Count)
                {
                    for (int i = 0; i < Number; i++)
                    {
                        foreach (Student student in Students)
                        {
                            if (student.AverageWritten() > Average)
                            {
                                Average = student.AverageWritten();
                                Name = student.FullName();
                                Student = student;
                            }
                        }
                        Console.WriteLine($"{i + 1}.Name:{Name},  Average: {Average}");
                        Students.Remove(Student);
                        Average = 0;
                    }
                }
                else
                    Console.WriteLine("lotfn shomare sahih ra vard knid!!!");
            }
            else
                Console.WriteLine("lotfn shomare sahih ra vard knid!!!");
        }

        public void SortByPractical()
        {
            double Average = 0;
            string Name = "";
            Console.Write("lotfn tedad danshamozani ra k mikhahid moratb knid vard knid: ");
            string Input = Console.ReadLine();
            Student Student = new Student("", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

            if (IsNotNull(Input) && IsInt(Input))
            {
                int Number = Convert.ToInt32(Input);
                if (Number <= Students.Count)
                {
                    for (int i = 0; i < Number; i++)
                    {
                        foreach (Student student in Students)
                        {
                            if (student.AveragePractical() > Average)
                            {
                                Average = student.AveragePractical();
                                Name = student.FullName();
                                Student = student;
                            }
                        }
                        Console.WriteLine($"{i + 1}.Name:{Name},  Average: {Average}");
                        Students.Remove(Student);
                        Average = 0;
                    }
                }
                else
                    Console.WriteLine("lotfn shomare sahih ra vard knid!!!");
            }
            else
                Console.WriteLine("lotfn shomare sahih ra vard knid!!!");
        }

        public void SortByTheorical()
        {
            double Average = 0;
            string Name = "";
            Console.Write("lotfn tedad danshamozani ra k mikhahid moratb knid vard knid: ");
            string Input = Console.ReadLine();
            Student Student = new Student("", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

            if (IsNotNull(Input) && IsInt(Input))
            {
                int Number = Convert.ToInt32(Input);
                if (Number <= Students.Count)
                {
                    for (int i = 0; i < Number; i++)
                    {
                        if (i == 99)
                        {
                            foreach (Student student in Students)
                            {
                                if (student.FirstName != "")
                                {
                                    Student = student;
                                    break;
                                }
                            }
                            Console.WriteLine($"{i + 1}.Name:{Student.FullName()},  Average: {Student.AverageTheorical()}");
                        }
                        else
                        {
                            foreach (Student student in Students)
                            {
                                if (student.AverageTheorical() > Average)
                                {
                                    Average = student.AverageTheorical();
                                    Name = student.FullName();
                                    Student = student;
                                }
                            }
                            Console.WriteLine($"{i + 1}.Name:{Name},  Average: {Average}");
                            Students.Remove(Student);
                            Average = 0;
                        }

                    }
                }
                else
                    Console.WriteLine("lotfn shomare sahih ra vard knid!!!");
            }
            else
                Console.WriteLine("lotfn shomare sahih ra vard knid!!!");
        }

        public void SortByMain()
        {
            double Average = 0;
            string Name = "";
            Console.Write("lotfn tedad danshamozani ra k mikhahid moratb knid vard knid: ");
            string Input = Console.ReadLine();
            Student Student = new Student("", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

            if (IsNotNull(Input) && IsInt(Input))
            {
                int Number = Convert.ToInt32(Input);
                if (Number <= Students.Count)
                {
                    for (int i = 0; i < Number; i++)
                    {
                        foreach (Student student in Students)
                        {
                            if (student.AverageMain() > Average)
                            {
                                Average = student.AverageMain();
                                Name = student.FullName();
                                Student = student;
                            }
                        }
                        Console.WriteLine($"{i + 1}.Name:{Name},  Average: {Average}");
                        Students.Remove(Student);
                        Average = 0;
                    }
                }
                else
                    Console.WriteLine("lotfn shomare sahih ra vard knid!!!");
            }
            else
                Console.WriteLine("lotfn shomare sahih ra vared knid!!!");
        }

        public void SortByGrade()
        {
            double Average = 0;
            string Name = "";
            char Grade = ' ';
            Student Student = new Student("", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            Console.Write("lotfn tedad danshamozani ra k mikhahid moratb knid vard knid: ");
            string Input = Console.ReadLine();


            if (IsNotNull(Input) && IsInt(Input))
            {
                int Number = Convert.ToInt32(Input);
                if (Number <= 100)
                {
                    for (int i = 0; i < Number; i++)
                    {
                        foreach (Student student in Students)
                        {
                            if (student.AverageGeneral() > Average)
                            {
                                Average = student.AverageGeneral();
                                Name = student.FullName();
                                Grade = student.Rank(Average);
                                Student = student;
                            }
                        }
                        Console.WriteLine($"{i + 1}.Name:{Name},  Average: {Average},  Grade: {Grade}");
                        Students.Remove(Student);
                        Average = 0;
                    }
                }
                else
                    Console.WriteLine("lotfn shomare sahih ra vard knid!!!");
            }
            else
                Console.WriteLine("lotfn shomare sahih ra vard knid!!!");
        }

        private bool IsInt(string input)
        {
            foreach (char c in input)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsNotNull(string Input)
        {
            if (Input.Replace(" ", "") == "")
                return false;
            return true;
        }
    }
}