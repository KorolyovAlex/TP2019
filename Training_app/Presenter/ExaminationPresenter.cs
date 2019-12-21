using Training_app.Model;

namespace Training_app.Presenter
{
    public class ExaminationPresenter
    {
        private IExaminationView _view;
        private IRepositoryService _repository_service;
        private IExaminationService _examination_service;

        public ExaminationPresenter(IExaminationView view, IRepositoryService repository_service, IExaminationService examination_service)
        {
            _view = view;
            _view.StartExamination += StartExamination;

            _repository_service = repository_service;
            _examination_service = examination_service;
            _examination_service.ExaminationEnded += ShowEndMessage;
        }

        private void StartExamination()
        {
            var examination = _repository_service.FindPatient(_view.PatientId).ExaminationsList[_view.ExaminationId];
            if (examination.ArterialPressInd)
            {
                _examination_service.TimerTicked += HandleAPChange;
            }
            if (examination.SkinTempInd)
            {
                _examination_service.TimerTicked += HandleSTChange;
            }
            if (examination.SkinMoisureInd)
            {
                _examination_service.TimerTicked += HandleSMChange;
            }
            if (examination.ElectrCondInd)
            {
                _examination_service.TimerTicked += HandleSCChange;
            }
            if (examination.PulseInd)
            {
                _examination_service.TimerTicked += HandlePChange;
            }
            _examination_service.StartExamination(examination);
        }

        private void HandleAPChange()
        {
            _view.UpdateAPGraph(_examination_service.TimeCounter, _examination_service.APValue);
        }

        private void HandleSTChange()
        {
            _view.UpdateSTGraph(_examination_service.TimeCounter, _examination_service.STValue);
        }

        private void HandleSMChange()
        {
            _view.UpdateSMGraph(_examination_service.TimeCounter, _examination_service.SMValue);
        }

        private void HandleSCChange()
        {
            _view.UpdateSCGraph(_examination_service.TimeCounter, _examination_service.SCValue);
        }

        private void HandlePChange()
        {
            _view.UpdatePGraph(_examination_service.TimeCounter, _examination_service.PValue);
        }

        private void ShowEndMessage()
        {
            _view.ShowEndMessage();
        }
        public void Run()
        {
        }

        public void Run(int PatientId, int ExaminationId)
        {
            _view.UpdateInfo(_repository_service.FindPatient(PatientId).ExaminationsList[ExaminationId]);
            _view.PatientId = PatientId;
            _view.ExaminationId = ExaminationId;
            _view.Show();
        }
    }
}
