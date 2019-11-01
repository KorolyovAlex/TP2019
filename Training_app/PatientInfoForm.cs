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
    public partial class PatientInfoForm : Form
    {
        private Patient patient;
        public int y = 7;

        public PatientInfoForm(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;

            StringBuilder name = new StringBuilder();
            patientName.Text = name.Append(patient.Surname).Append(" ").Append(patient.Name).Append(" ").Append(patient.Fathername).ToString();
            patientAge.Text = patient.Age.ToString();
            patientSex.Text = patient.Sex;
        }

        private void addExamination_Click(object sender, EventArgs e)
        {
            NewExaminationForm newForm = new NewExaminationForm(this, patient);
            newForm.Show();
        }

        public void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
                ExaminationForm newForm1 = new ExaminationForm(patient.ExaminationsList[int.Parse(button.Tag.ToString())]);
                newForm1.Show();
            }
        }

        private void PatientInfoForm_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Examination exam in patient.ExaminationsList)
            {
                Button button = new Button();
                button.Tag = i++;
                StringBuilder buttonName = new StringBuilder();
                button.Text = buttonName.Append(exam.Date.ToString("dd MMMM yyyy"))
                                        .Append(" ")
                                        .Append(exam.ExerciseType)
                                        .Append(" ")
                                        .Append(exam.Duration.ToString())
                                        .Append(" мин")
                                        .ToString();

                button.Location = new Point(10, y);
                y += 30;
                button.Width = Width - 40;
                button.BackColor = SystemColors.ScrollBar;
                button.Click += ButtonOnClick;
                button.Font = new Font("Segoe UI", 9f);
                button.TextAlign = ContentAlignment.MiddleLeft;
                examPanel.Controls.Add(button);
            }
        }

        public void PatientAdd(Button button)
        {
            examPanel.Controls.Add(button);
        }
    }
}
