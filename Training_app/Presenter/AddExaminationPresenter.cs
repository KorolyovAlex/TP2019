using System;
using Training_app.Model;

namespace Training_app.Presenter
{
    public class AddExaminationPresenter
    {
        private IAddExaminationView _view;
        private IRepositoryService _service;

        public AddExaminationPresenter(IAddExaminationView view, IRepositoryService service)
        {
            _view = view;
            _view.AddExamination += AddExamination;

            _service = service;
            _service.ExaminationAdded += HandleExaminationAdded;
        }

        public event Action ExaminationAdded;

        private void AddExamination()
        {
            _service.AddExamination(_view.PatientId, _view.Date, _view.Duration, _view.Exercise, _view.ArterialPressure, _view.SkinTemperature, _view.SkinMoisture, _view.SkinConductivity, _view.Pulse);
        }

        private void HandleExaminationAdded()
        {
            ExaminationAdded?.Invoke();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }

        public void Run(int id)
        {
            _view.PatientId = id;
            _view.Show();
        }
    }
}
