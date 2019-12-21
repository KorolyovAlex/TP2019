using System;

namespace Training_app.Presenter
{
    public interface IAddExaminationView : IView
    {
        int PatientId { get; set; }
        string Exercise { get; }
        short Duration { get; }
        DateTime Date { get; }
        bool ArterialPressure { get; }
        bool SkinTemperature { get; }
        bool SkinMoisture { get; }
        bool SkinConductivity { get; }
        bool Pulse { get; }

        event Action AddExamination;
    }
}
