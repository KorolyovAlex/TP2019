using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_app.Model;

namespace Training_app.Presenter
{
    public class AddPatientPresenter
    {
        private IAddPatientView _view;
        private IRepositoryService _service;

        public AddPatientPresenter(IAddPatientView view, IRepositoryService service)
        {
            _view = view;
            _view.AddPatient += AddPatient;

            _service = service;
            _service.PatientAdded += HandlePatientUpdated;
        }

        public event Action PatientUpdated;

        private void AddPatient()
        {
            _service.AddPatient(_view.FName, _view.Surname, _view.BatyaName, _view.Sex, _view.Age);
        }

        private void HandlePatientUpdated()
        {
            PatientUpdated?.Invoke();
            _view.Close();
        }

        public void Run()
        {   
            _view.Show();
        }
    }
}
