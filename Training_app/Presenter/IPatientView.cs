using System;
using System.Collections.Generic;
using Training_app.Model.Entity;

namespace Training_app.Presenter
{
    public interface IPatientView : IView
    {
        event Action ShowAddPatient;
        event Action <int> ShowPatientInfo;

        void ShowPatient(IEnumerable<Patient> patients);
    }
}
