namespace ResultManagementSystem
{
    class Exam : Student
    {
        public Exam(int rollNo, string name, string department, int sub1, int sub2, int sub3, int sub4, int sub5, int technicalMarks, int nonTechnicalMarks, int sportMarks, int aptitudeMarks)
            : base(rollNo, name, department, sub1, sub2, sub3, sub4, sub5, technicalMarks, nonTechnicalMarks, sportMarks, aptitudeMarks)
        { }

        public void ExamMarksEntry()
        {
            if (Sub1 > 40 && Sub2 > 40 && Sub3 > 40 && Sub4 > 40 && Sub5 > 40)
                IsPass = true;
            else
                IsPass = false;
            TotalMarks += Sub1 + Sub2 + Sub3 + Sub4 + Sub5;
        }
    }
}
