using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_app.Model;
using Training_app.Model.Entity;

namespace Training_app.Presenter    
{
    public interface IPatientInfoView : IView
    {
        int PatientId { get; set; }

        event Action AddExamination;
        event Action <int, int> ShowExamination;

        void UpdateInfo(Patient patient);
        void UpdateExamination(IEnumerable<Examination> examination);
    }
}
