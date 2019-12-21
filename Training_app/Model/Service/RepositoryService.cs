using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_app.Model;
using Training_app.Model.Entity;

namespace Training_app.Model.Service
{
    public class RepositoryService : IRepositoryService
    {
        private IRepository<Patient> _patient_repository;

        public RepositoryService(IRepository<Patient> patient_repository)
        {
            _patient_repository = patient_repository;
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return _patient_repository.GetAll();
        }

        public Patient FindPatient(int id)
        {
            return _patient_repository.Find(id);
        }

        public event Action PatientAdded;

        public void AddPatient(string name, string surname, string batyaname, string sex, byte age)
        {
            _patient_repository.Add(new Patient { Name = name, Surname = surname, Batyaname = batyaname, Sex = sex, Age = age });
            PatientAdded?.Invoke();
        }

        public event Action ExaminationAdded;

        public void AddExamination(int id, DateTime date, short duration, string exerciseType, bool bloodPress, bool skinTemp, bool skinMois, bool electrCond, bool pulse)
        {
            _patient_repository.AddExamination(id, new Examination { Date = date,
                                                                     Duration = duration,
                                                                     ExerciseType = exerciseType,
                                                                     ArterialPressInd = bloodPress,
                                                                     SkinTempInd = skinTemp,
                                                                     SkinMoisureInd = skinMois,
                                                                     ElectrCondInd = electrCond,
                                                                     PulseInd = pulse
                                                                    });
            ExaminationAdded?.Invoke();
        }

        public void GetPatient()
        {

        }
    }
}
