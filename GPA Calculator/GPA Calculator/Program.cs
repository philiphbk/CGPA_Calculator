using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Net.Http.Headers;

namespace GPA_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<string> courseList = new List<string>() { "Math 101", "GS 101", ".NET 101", "C# 101", "HCI 101" };
            //List<int> courseUnitList = new List<int>() { 5, 3, 5, 5, 3 };
            //List<int> courseScore = new List<int>() { 70, 60, 50, 40, 30 };

            //Console.WriteLine("|---------------|-------------|-------|------------|");
            //Console.WriteLine("| COURSE & CODE | COURSE UNIT | GRADE | GRADE-UNIT |");
            //Console.WriteLine("|---------------|-------------|-------|------------|");

            ////for (int i = 0; i < courseList.Count; i++)
            ////{

            ////    Console.WriteLine($"| {courseList[i]}  | {courseUnitList[i]} | {grade}");

            ////}
            //Console.WriteLine($"Your GPA is = {Calculator.GPA_Calculator(courseList, courseUnitList, courseScore)}");
            //Console.WriteLine("|--------------------------------------------------|");



            UserInterface ui = new UserInterface();
            ui.InterfaceChecker();
        }
    }
}
