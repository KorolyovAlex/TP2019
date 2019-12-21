using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_app.Presenter
{
    public interface IAddPatientView : IView
    {
        string FName { get; }
        string Surname { get; }
        string BatyaName { get; }
        string Sex { get; }
        byte Age { get; }

        event Action AddPatient;
    }
}
