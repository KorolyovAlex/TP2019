using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_app.Model.Entity;

namespace Training_app.Model
{
    public interface IRepositoryService
    {
        void AddPatient(string name, string surname, string batyaname, string sex, byte age);
        Patient FindPatient(int id);
        void AddExamination(int id, DateTime date, short duration, string exerciseType, bool bloodPress, bool skinTemp, bool skinMois, bool electrCond, bool pulse);
        IEnumerable<Patient> GetAllPatients();

        event Action PatientAdded;
        event Action ExaminationAdded;
    }
}
