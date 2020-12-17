using System;

namespace ResultManagementSystem
{
    class Student
    {
        public bool IsPass;
        public string Name, Department;
        public int RollNo;
        public int Sub1, Sub2, Sub3, Sub4, Sub5;
        public int SportMarks;
        public int AptitudeMarks;
        public int TechnicalMarks;
        public int NonTechnicalMarks;

        public int TotalMarks;
        public double Percentage;

        public Student(int rollNo, string name, string department, int sub1, int sub2, int sub3, int sub4, int sub5, int technicalMarks, int nonTechnicalMarks, int sportMarks, int aptitudeMarks)
        {
            this.Name = name;
            this.RollNo = rollNo;
            this.Department = department;
            this.Sub1 = sub1;
            this.Sub2 = sub2;
            this.Sub3 = sub3;
            this.Sub4 = sub4;
            this.Sub5 = sub5;
            this.TechnicalMarks = technicalMarks;
            this.NonTechnicalMarks = nonTechnicalMarks;
            this.SportMarks = sportMarks;
            this.AptitudeMarks = aptitudeMarks;
        }
        public void ShowResult()
        {
            string ans = null;
            
            if (IsPass)
                ans = "Pass";
            else
                ans = "Failed";

            Console.WriteLine(String.Format("| {0, 10} | {1, -20} | {2, -20} | {3, 20} | {4, 20}% | {5, 20} |", RollNo, Name, Department, TotalMarks, Percentage, ans));
        }
    }
}
