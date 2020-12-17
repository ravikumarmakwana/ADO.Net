using System.Collections.Generic;

namespace ResultManagementSystem
{
    class Result : Exam, ISport, ITechnical, INonTechnical, IAptitude
    {
        public Result(int rollNo, string name, string department, int sub1, int sub2, int sub3, int sub4, int sub5, int technicalMarks, int nonTechnicalMarks, int sportMarks, int aptitudeMarks)
            : base(rollNo, name, department, sub1, sub2, sub3, sub4, sub5, technicalMarks, nonTechnicalMarks, sportMarks, aptitudeMarks)
        { }

        public void SportMarksEntry()
        {
            TotalMarks += SportMarks;
            if(IsPass)
            {
                if (SportMarks < 40)
                    IsPass = false;
            }
        }

        public void TechnicalMarksEntry()
        {
            TotalMarks += TechnicalMarks;
            if (IsPass)
            {
                if (TechnicalMarks < 40)
                    IsPass = false;
            }
        }

        public void NonTechnicalMarksEntry()
        {
            TotalMarks += NonTechnicalMarks;
            if (IsPass)
            {
                if (NonTechnicalMarks < 40)
                    IsPass = false;
            }
        }

        public void AptitudeMarksEntry()
        {
            TotalMarks += AptitudeMarks;
            if (IsPass)
            {
                if (AptitudeMarks < 40)
                    IsPass = false;
            }
        }

        public void ComputeFinalResult()
        {
            Percentage = ( TotalMarks * 100 ) / 900;
        }
    }
}
