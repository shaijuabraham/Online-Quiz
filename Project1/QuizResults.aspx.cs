using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    public partial class QuizResults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string studentName = Request["txtStudentInfo"];
            string studentId = Request["txtStudentId"];

            string answerOne = Request["rdbAnswerOne"];
            string answerTwo = Request["chkAnswerTwo"];
            string answerThree = Request["drpAnswerThree"];
            string answerFour = Request["txtAnswerFour"];
            string answerFive = Request["rdbAnswerFive"];

            string answerSix = Request["rdbAnswerSix"];
            string answerSeven = Request["rdbAnswerSeven"];
            string answerEight = Request["rdbAnswerEight"];
            string answerNine = Request["rdbanswerNine"];
            string answerTen = Request["chkAnswerTen"];

            string answerEleven = Request["rdbanswerEleven"];
            string answerTwelve = Request["rdbAnswerTwelve"];
            string answerThirteen = Request["chkAnswerThirteen"];
            string answerFourteen = Request["chkAnswerFourteen"];
            string answerFifteen = Request["chkAnswerFifteen"];

            string answerSixteen = Request["drpAnswerSixteen"];
            string answerSeventeen = Request["rdbAnswerSeventeen"];
            string answerEighteen = Request["rdbAnswerEighteen"];
            string answerNineteen = Request["rdbAnswerNineteen"];
            string answerTwenty = Request["txtAnswerTwenty"];

            string[] userAnswer = { answerOne, answerTwo, answerThree,  answerFour, answerFive,
                                    answerSix, answerSeven, answerEight, answerNine, answerTen,
                                    answerEleven, answerTwelve, answerThirteen, answerFourteen, answerFifteen,
                                    answerSixteen, answerSeventeen, answerEighteen, answerNineteen, answerTwenty 
            };



            QuizData quizData = new QuizData();
            StudentInfo studentInfo = new StudentInfo(studentName, studentId);
            List<string> resultMessages = quizData.QuizAnswers(userAnswer, studentInfo);

            string displayMessage = "";
                foreach (string message in resultMessages)
                {
                    displayMessage += message + "<br>";
                }

                lblQuestion.Text = displayMessage;

                lblStudentInfo.Text = studentInfo.ToString();


                if (quizData.Average <= 60)
                {
                    lblFinialGrade.Text = studentInfo.FinalGrade + "<br>" + quizData.Average + "%" + "<br>" + " F";
                }
                else if (quizData.Average <= 69)
                {
                    lblFinialGrade.Text = studentInfo.FinalGrade + "<br>" + quizData.Average + "%" + "<br>" + " D";
                }
                else if (quizData.Average <= 79)
                {
                    lblFinialGrade.Text = studentInfo.FinalGrade + "<br>" + quizData.Average + "%" + "<br>" + " C";
                }
                else if (quizData.Average <= 89)
                {
                    lblFinialGrade.Text = studentInfo.FinalGrade + "<br>" + quizData.Average + "%" + "<br>" + " B";
                }
                else if (quizData.Average <= 100)
                {
                    lblFinialGrade.Text = studentInfo.FinalGrade + "<br>" + quizData.Average + "%" + "<br>" + " A";
                }

                lblFinalGradeimg.Text = quizData.FinalGradeimg;

        }
    }
}
