using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_app
{
    public class Patient
    {
        public string Name { get; }
        public string Surname { get; }
        public string Fathername { get; }
        public string Sex { get; }
        public byte Age { get; }
        public List<Examination> ExaminationsList { get; } = new List<Examination>();

        public Patient(string surname, string name, string fathername, string sex, byte age)
        {
            Name = name;
            Surname = surname;
            Fathername = fathername;
            Sex = sex;
            Age = age;
        }
    }
}
