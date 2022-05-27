using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GPA_Calculator
{
    public class Validators
    {

        public static bool Validator(string input)
        {
            if (input == null)
            {
                throw new Exception("Please input the right control");
            }
            
            return Int32.TryParse(input, out int value);
        }

        public static bool CourseValidator(string input)
        {
            if (input == null)
            {
                throw new Exception("Please input the right control");
            }

            return Regex(input);
        }

        private static bool Regex(string input)
        {
            // Create a pattern for a word that starts with letter "M"  
            string pattern = @"^[A-Z]{3}\d{3}$";
            // Create a Regex  
            Regex rg = new Regex(pattern);
            if (rg.IsMatch(input)) return true;
            else return false;

        }

        public static bool UnitValidator(string input)
        {
           var pass = Validator(input);
           int num = Convert.ToInt32(input);
            if (num >= 0 && num <= 5)
                return true;

            else
            {
                throw new Exception("Please enter the correct course unit");
            }
        }

        public static bool ScoreValidator(string input)
        {
            var pass = Validator(input);
            int num = Convert.ToInt32(input);
            if (num >= 0 && num <= 100)
                return true;
            else
            {
                throw new Exception("Please enter the correct course grade");
            }
        }
    }
}
