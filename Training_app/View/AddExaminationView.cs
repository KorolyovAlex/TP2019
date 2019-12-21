using System;
using System.Windows.Forms;
using Training_app.Presenter;
using Training_app.Model.Entity;

namespace Training_app.Views
{
    public partial class AddExaminationView : Form, IAddExaminationView
    {
        public string Exercise
        {
            get
            {
                if (exerciseBike.Checked)
                {
                    return "Вело";
                }

                if (exerciseRunning.Checked)
                {
                    return "Бег";
                }

                if (exerciseWalking.Checked)
                {
                    return "Ходьба";
                }

                if (exerciseStrength.Checked)
                {
                    return "Силовая";
                }
                return string.Empty;
            }
        }

        public int PatientId { get; set; }
        public short Duration => (short)exerciseDuration.Value;
        public DateTime Date => dateTimePicker.Value;
        public bool ArterialPressure => bloodPressureInd.Checked;
        public bool SkinTemperature => skinTemperatureInd.Checked;
        public bool SkinMoisture => skinMoistureInd.Checked;
        public bool SkinConductivity => electricalConductivityInd.Checked;
        public bool Pulse => pulseInd.Checked;

        public event Action AddExamination;

        public AddExaminationView(PatientInfoView form, Patient patient)
        {
            InitializeComponent();
            dateTimePicker.Value = DateTime.Now;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddExamination?.Invoke();
        }
    }
}
