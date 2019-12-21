using System;
using Training_app.Model.Entity;

namespace Training_app.Model
{
    public interface IExaminationService
    {
        int TimeCounter { get; set; }
        int APValue { get; set; }
        double STValue { get; set; }
        int SMValue { get; set; }
        int SCValue { get; set; }
        int PValue { get; set; }

        void StartExamination(Examination examination);

        event Action TimerTicked;
        event Action ExaminationEnded;
    }
}
