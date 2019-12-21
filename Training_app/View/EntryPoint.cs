using System;
using System.Windows.Forms;
using Training_app.Model;
using Training_app.Model.Entity;
using Training_app.Views;
using Training_app.Presenter;
using Training_app.Model.Service;
using Training_app.DAL;
using Ninject;


namespace Training_app
{
    static class EntryPoint
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<IPatientView>().To<PatientView>();
            kernel.Bind<IRepository<Patient>>().To<PatientRepository>();
            kernel.Bind<IAddPatientView>().To<AddPatientView>();
            kernel.Bind<IRepositoryService>().To<RepositoryService>();
            kernel.Bind<IPatientInfoView>().To<PatientInfoView>();
            kernel.Bind<IAddExaminationView>().To<AddExaminationView>();
            kernel.Bind<IExaminationView>().To<ExaminationView>();
            kernel.Bind<IExaminationService>().To<ExaminationService>();
            kernel.Bind<ITimer>().To<WinFormTimer>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<PatientPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
        }

        internal class WinFormTimer : System.Windows.Forms.Timer, ITimer { }
    }
}
