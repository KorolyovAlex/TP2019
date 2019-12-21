using System.Collections.Generic;
using Training_app.Model.Entity;

namespace Training_app.Model
{
    public interface IRepository<T> where T : class
    {
        int Add(T obj);
        void Update(T obj);
        void Remove(int id);
        void AddExamination(int id, Examination examination);
        void Save();
        T Find(int id);
        IEnumerable<T> GetAll();
    }
}
