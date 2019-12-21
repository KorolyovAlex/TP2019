using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_app.Model.Entity
{
    public class Patient : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Batyaname { get; set; }
        public string Sex { get; set; }
        public byte Age { get; set; }
        public List<Examination> ExaminationsList { get; } = new List<Examination>();
    }
}
