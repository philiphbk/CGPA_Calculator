using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator
{
    public class UserInterface
    {
        private string userName = String.Empty;
        private string courseName = string.Empty;
        public string control = String.Empty;

        private readonly string controlMessage = "Input 1 to Add to the table" +
                                          "\n Input 2 to Print GPA" +
                                          "\n Input 3 to Continue" +
                                          "\n";
        public void InterfaceChecker()
        {

            Console.WriteLine("Welcome to CGPA calculator");
            Console.WriteLine("pls insert your Name");
            string username = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(controlMessage);
            control = Console.ReadLine();
            var validControl = Validators.Validator(control);


            while (true)
            {
                while (Convert.ToInt32(control) == 1)
                {
                    Console.WriteLine($"Hello {userName}, Please enter your Course Name");
                        courseName = Console.ReadLine();
                        var validData = Validators.CourseValidator(courseName.ToUpper().Trim());

                        if (validData == true)
                            Calculator.GPA_Calculator(courseName);


                        Console.WriteLine($"Hello {userName}, Please enter your Course Unit \n");
                        var courseUnit = Console.ReadLine();
                        
                        if (Validators.UnitValidator(courseUnit) == true)
                            Calculator.GPA_Calculator(courseUnit);

                        Console.WriteLine($"Hello {userName}, Please enter your Course Score \n");
                        var courseScore = Console.ReadLine();

                        if (Validators.ScoreValidator(courseScore) == true)
                            Calculator.GPA_Calculator(courseScore);


                       
                }

            }

        }

    }
}

