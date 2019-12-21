using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_app.Model.Entity;

namespace Training_app.Presenter
{
    public interface IExaminationView : IView
    {
        int PatientId { get; set; }
        int ExaminationId { get; set; }

        void UpdateInfo(Examination exam);
        void UpdateAPGraph(int timerTime, int value);
        void UpdateSTGraph(int timerTime, double value);
        void UpdateSMGraph(int timerTime, int value);
        void UpdateSCGraph(int timerTime, int value);
        void UpdatePGraph(int timerTime, int value);
        void ShowEndMessage();

        event Action StartExamination;
    }
}
