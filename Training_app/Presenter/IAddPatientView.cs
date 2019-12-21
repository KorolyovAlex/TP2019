using System;

namespace Training_app.Presenter
{
    public interface IAddPatientView : IView
    {
        string FName { get; }
        string Surname { get; }
        string BatyaName { get; }
        string Sex { get; }
        byte Age { get; }

        event Action AddPatient;
    }
}
