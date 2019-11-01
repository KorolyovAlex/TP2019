using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training_app
{
    public partial class NewExaminationForm : Form
    {
        private PatientInfoForm parentForm;
        private Patient patient;

        public NewExaminationForm(PatientInfoForm form, Patient patient)
        {
            InitializeComponent();
            parentForm = form;
            this.patient = patient;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string exerciseType = String.Empty;

            if(exerciseBike.Checked)
            {
                exerciseType = "Вело";
            }

            if (exerciseRunning.Checked)
            {
                exerciseType = "Бег";
            }

            if (exerciseWalking.Checked)
            {
                exerciseType = "Ходьба";
            }

            if (exerciseStrength.Checked)
            {
                exerciseType = "Силовая";
            }

            patient.ExaminationsList.Add(new Examination(dateTimePicker.Value,
                                                        (short)exerciseDuration.Value,
                                                        exerciseType,
                                                        bloodPressureInd.Checked,
                                                        skinTemperatureInd.Checked,
                                                        skinMoistureInd.Checked,
                                                        electricalConductivityInd.Checked,
                                                        pulseInd.Checked));

            Button button = new Button();
            button.Tag = (patient.ExaminationsList.Count - 1).ToString();
            StringBuilder buttonName = new StringBuilder();
            button.Text = buttonName.Append(dateTimePicker.Value.ToString("dd MMMM yyyy"))
                                    .Append(" ")
                                    .Append(exerciseType)
                                    .Append(" ")
                                    .Append(exerciseDuration.Value.ToString())
                                    .Append(" мин")
                                    .ToString();

            button.Location = new Point(10, parentForm.y);
            parentForm.y += 30;
            button.Width = parentForm.Width - 40;
            button.BackColor = SystemColors.ScrollBar;
            button.Click += parentForm.ButtonOnClick;
            button.Font = new Font("Segoe UI", 9f);
            button.TextAlign = ContentAlignment.MiddleLeft;
            parentForm.PatientAdd(button);
            Close();
        }
    }
}
