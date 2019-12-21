using Training_app.Model;
using Ninject;

namespace Training_app.Presenter
{
    public class PatientInfoPresenter
    {
        private IKernel _kernel;
        private IPatientInfoView _view;
        private IRepositoryService _service;

        public PatientInfoPresenter(IKernel kernel,  IPatientInfoView view, IRepositoryService service)
        {
            _kernel = kernel;
            _view = view;
            _view.AddExamination += ShowAddExamination;
            _view.ShowExamination += ShowExamination;

            _service = service;
        }


        private void ShowAddExamination()
        {
            var presenter = _kernel.Get<AddExaminationPresenter>();
            presenter.ExaminationAdded += UpdateExamination;
            presenter.Run(_view.PatientId);
        }

        private void ShowExamination(int PatientId, int ExaminationId)
        {
            var presenter = _kernel.Get<ExaminationPresenter>();
            presenter.Run(PatientId, ExaminationId);
        }

        private void UpdateExamination()
        {
            _view.UpdateExamination(_service.FindPatient(_view.PatientId).ExaminationsList);
        }

        public void Run()
        {
        }

        public void Run(int id)
        {
            _view.PatientId = id;
            _view.UpdateInfo(_service.FindPatient(id));
            UpdateExamination();
            _view.Show();
        }
    }
}
