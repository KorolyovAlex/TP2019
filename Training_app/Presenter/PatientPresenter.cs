using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_app.Model;
using Ninject;

namespace Training_app.Presenter
{
    class PatientPresenter
    {
        private readonly IPatientView _view;
        private readonly IRepositoryService _service;
        private readonly IKernel _kernel;

        public PatientPresenter(IKernel kernel,  IPatientView view, IRepositoryService service)
        {
            _view = view;
            _kernel = kernel;
            _service = service;

            _view.ShowAddPatient += ShowAddPatient;
            _view.ShowPatientInfo += ShowPatientInfo;
        }

        private void ShowAddPatient()
        {
            var presenter = _kernel.Get<AddPatientPresenter>();
            presenter.PatientUpdated += ShowPatient;
            presenter.Run();
        }

        private void ShowPatientInfo(int id)
        {
            var presenter = _kernel.Get<PatientInfoPresenter>();
            presenter.Run(id);
        }

        public void ShowPatient()
        {
            _view.ShowPatient(_service.GetAllPatients());
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
