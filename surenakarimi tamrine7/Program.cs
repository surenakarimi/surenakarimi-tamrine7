﻿using StudentsReportCard;
using System.IO;

List<Student> Students;
Sort Sort;
string path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data", "StudentsData.txt");


void GenerateStudent()
{
    using (StreamReader Reader = new StreamReader(path))
    {
        for (int i = 0; i < 100; i++)
        {
            string[] Values = Reader.ReadLine().Replace(" ", "").Split(new char[] { ',' });

            Student Student = new Student(Values[0],
                                          Values[1],
                                          Int32.Parse(Values[2]),
                                          Int32.Parse(Values[3]),
                                          Int32.Parse(Values[4]),
                                          Int32.Parse(Values[5]),
                                          Int32.Parse(Values[6]),
                                          Int32.Parse(Values[7]),
                                          Int32.Parse(Values[8]),
                                          Int32.Parse(Values[9]),
                                          Int32.Parse(Values[10]),
                                          Int32.Parse(Values[11]));
            Students.Add(Student);

        }
    }

}

void Welcome()
{
    Console.WriteLine("*****************************************");
    string Menu = @"Welcome to student manager program:
1.Written Average
2.Practical Average
3.Theorical Average
4.Main Average
5.General Average
6.Top students by written average
7.Top students by practical average
8.Top students by theorical average
9.Top students by main average 
10.Top students by grade
11.Find prime numbers in lessons marks
12.Exit";
    Console.WriteLine(Menu);
    Console.WriteLine("*****************************************");

}

void SelectOption()
{
    do
    {
        Welcome();
        Console.Write("Please choose one of the options: ");
        Students = new List<Student>();
        GenerateStudent();
        Sort = new Sort(Students);
        switch (Console.ReadLine())
        {
            case "1":
                PrintAverage("WrittenAverage");
                break;
            case "2":
                PrintAverage("PracticalAverage");
                break;
            case "3":
                PrintAverage("TheoricalAverage");
                break;
            case "4":
                PrintAverage("MainAverage");
                break;
            case "5":
                PrintAverage("GeneralAverage");
                break;
            case "6":
                Sort.SortByWritten();
                break;
            case "7":
                Sort.SortByPractical();
                break;
            case "8":
                Sort.SortByTheorical();
                break;
            case "9":
                Sort.SortByMain();
                break;
            case "10":
                Sort.SortByGrade();
                break;
            case "11":
                ShowPrimeNumbers();
                break;
            case "12":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Please enter a correct number!!!!!");
                break;

        }
    } while (true);
}

void PrintAverage(string Type)
{
    Console.WriteLine($"***{Type}s***");
    foreach (Student Student in Students)
    {
        switch (Type)
        {
            case "WrittenAverage":
                Console.WriteLine($"{Student.FullName()} : {Student.AverageWritten()}");
                break;
            case "PracticalAverage":
                Console.WriteLine($"{Student.FullName()} : {Student.AveragePractical()}");
                break;
            case "TheoricalAverage":
                Console.WriteLine($"{Student.FullName()} : {Student.AverageTheorical()}");
                break;
            case "MainAverage":
                Console.WriteLine($"{Student.FullName()} : {Student.AverageMain()}");
                break;
            case "GeneralAverage":
                Console.WriteLine($"{Student.FullName()} : {Student.AverageGeneral()}");
                break;
        }
    }
}

void ShowPrimeNumbers()
{
    Console.WriteLine("***Prime numbers for all student***");
    foreach (Student Student in Students)
    {
        Student.PrimeNumbers();
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("--------------------------------------");
    }
}

SelectOption();
//surena karimi
//tamrine 7