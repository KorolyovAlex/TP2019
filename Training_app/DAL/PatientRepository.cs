using System.Collections.Generic;
using Training_app.Model;
using Training_app.Model.Entity;

namespace Training_app.DAL
{
    public class PatientRepository : IRepository<Patient>
    {
        private static List<Patient> _data = new List<Patient>();
        private static int _end_index = 0;

        public int Add(Patient obj)
        {
            obj.Id = _end_index++;
            _data.Add(obj);
            return obj.Id;
        }

        public void AddExamination(int id, Examination examination)
        {
            Find(id).ExaminationsList.Add(examination);
        }

        public void Update(Patient obj)
        {
            var patient = _data.Find(c => c.Id == obj.Id);
            if (patient != null)
                patient.Name = obj.Name;
        }

        public void Remove(int id)
        {
            _data.RemoveAll(c => c.Id == id);
        }

        public void Save()
        {
        }

        public Patient Find(int id)
        {
            return _data.Find(c => c.Id == id);
        }

        public IEnumerable<Patient> GetAll()
        {
            return _data;
        }
    }
}
