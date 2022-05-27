using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator
{
    public class Calculator
    {

        public static string GPA_Calculator(string value)
        {
            List<string> courseList = new List<string>();
            courseList.Add(value);
            
            List<int> courseUnitList = new List<int>();
            courseUnitList.Add(Convert.ToInt32(value));

            List<int> courseScore = new List<int>();
            courseScore.Add(Convert.ToInt32(value));


            var totalQualityPoint = 0;
            var totalGradeUnit = 0;
            List<string> gradeList = new List<string>();
            List<int> gradeUnitList = new List<int>();
            List<string> remark = new List<string>();
            if (gradeUnitList == null || courseUnitList == null || courseList == null)
            {
                throw new Exception("The Course score table cannot be empty");
            }





            for (int i = 0; i < courseUnitList.Count; i++)
            {
                if (courseScore[i] >= 70)
                {
                    gradeList.Add("A");
                    gradeUnitList.Add(5);
                    remark.Add("Excellent");
                }
                else if (courseScore[i] >= 60 || courseScore[i] <= 69)
                {
                    gradeList.Add("B");
                    gradeUnitList.Add(4);
                    remark.Add("Very Good");
                }
                else if (courseScore[i] >= 50 || courseScore[i] <= 59)
                {
                    gradeList.Add("C");
                    gradeUnitList.Add(3);
                    remark.Add("Good");
                }
                else if (courseScore[i] >= 45 || courseScore[i] <= 49)
                {
                    gradeList.Add("D");
                    gradeUnitList.Add(2);
                    remark.Add("Fair");
                }
                else if (courseScore[i] >= 40 || courseScore[i] <= 45)
                {
                    gradeList.Add("E");
                    gradeUnitList.Add(1);
                    remark.Add("Pass");
                }
                else
                {
                    gradeList.Add("F");
                    gradeUnitList.Add(0);
                    remark.Add("Fail");
                }


                var qualityPoint = courseUnitList[i] * gradeUnitList[i];
                totalQualityPoint += qualityPoint;
                totalGradeUnit += gradeUnitList[i];


            }

            if (totalGradeUnit == 0 && totalQualityPoint == 0)
            {
                throw new Exception("Your GPA is 0.");
            }

            double gpa = totalQualityPoint / totalGradeUnit;

            return ""; //Math.Round(gpa, 2);

        }
    }
}
