using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1
{
    public class QuizData
    {
        public string FinalGradeimg { get; set; }
        public double Average { get; set; }
        public QuizList quizList;

        public QuizData(string finialgradeimg)
        {
            FinalGradeimg = finialgradeimg;
            quizList = new QuizList(); 
        }

        public QuizData()
        {
            quizList = new QuizList(); 

        }

        public List<string> QuizAnswers(string[] userAnswers, StudentInfo studentInfo)
        {
            List<string> resultAnswers = QuizResult(userAnswers);
            int userGrade = CalculateGrade(userAnswers);
            CalculateFinalGrade(userGrade, studentInfo);
            return resultAnswers;
        }

        private int CalculateGrade(string[] userAnswers)
        {
            int userGrade = 0;
            for (int i = 0; i < userAnswers.Length; i++)
            {
                if (userAnswers[i] == quizList.correctAnswers[i])
                {
                    userGrade++;
                }
            }
            return userGrade;
        }

        private List<string> QuizResult(string[] userAnswers)
        {
            List<string> resultAnswers = new List<string>();
            for (int i = 0; i < userAnswers.Length; i++)
            {
                if (userAnswers[i] == null)
                {
                    userAnswers[i] = "Not Answered";
                }
                if (userAnswers[i].ToLower() == quizList.correctAnswers[i].ToLower())
                {
                    resultAnswers.Add("Question :" + (i + 1) + " " + quizList.questions[i] + "<br>" +
                        "<img src= 'pic/correct.png' style='width:20px;height:20px;'/>" +
                        "Correct Answer: " + userAnswers[i] + " <br>");
                }
                else
                {
                    resultAnswers.Add("Question :" + (i + 1) + " " + quizList.questions[i] + "<br>" +
                        "<img src= 'pic/wrong.png' style='width:20px;height:20px;'/>" +
                        "Your Answer: " + userAnswers[i] +
                        "<br> Correct Answer: " + quizList.correctAnswers[i] + "<br>");
                }
            }
            return resultAnswers;
        }

        private void CalculateFinalGrade(int userGrade, StudentInfo studentInfo)
        {
            int totalGrade = 20;
            double averageGrade = (double)userGrade / totalGrade * 100;
            string finalGrade = "Your Score: " + userGrade + " / " + totalGrade;
            string image = (userGrade <= 15) ?
                "<img src= 'pic/smiley.jpg' style='width:200px;height:200px;'/>" :
                "<img src= 'pic/Cong.jpeg' style='width:200px;height:200px;'/>";

            SetStudentInfo(finalGrade, image, averageGrade, studentInfo);
        }

        private void SetStudentInfo(string finalGrade, string image, double averageGrade, StudentInfo studentInfo)
        {
            studentInfo.FinalGrade = finalGrade;
            FinalGradeimg = image;
            Average = averageGrade;
        }
    }
}