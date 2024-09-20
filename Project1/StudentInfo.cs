using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1
{
    public class StudentInfo
    {
        private string Studentname;
        private string Studentid;
        public string FinalGrade { get; set; }

        public StudentInfo(string studentname, string studentid)
        {
            this.Studentname = studentname;
            this.Studentid = studentid;

        }
        public StudentInfo(string finialgrade)
        {
            FinalGrade = finialgrade;

        }

        public string StudentName
        {
            get { return Studentname; }
            set { Studentname = value; }
        }

        public string StudentId
        {
            get { return Studentid; }
            set { Studentid = value; }
        }


        public override string ToString()
        {
            return "Student Name : " +  Studentname +  "<br>" +
                "Student ID : " + Studentid + "<br>";
        }
    }
}