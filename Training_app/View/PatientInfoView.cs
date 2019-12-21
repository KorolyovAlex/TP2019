using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Training_app.Model.Entity;
using Training_app.Presenter;

namespace Training_app.Views
{
    public partial class PatientInfoView : Form, IPatientInfoView
    {
        public int PatientId { get; set; }

        public event Action AddExamination;
        public event Action <int, int> ShowExamination;

        public PatientInfoView()
        {
            InitializeComponent();
        }

        public void UpdateInfo(Patient patient)
        {
            StringBuilder name = new StringBuilder();
            patientName.Text = name.Append(patient.Surname).Append(" ").Append(patient.Name).Append(" ").Append(patient.Batyaname).ToString();
            patientAge.Text = patient.Age.ToString();
            patientSex.Text = patient.Sex;
        }

        private void AddExamination_Click(object sender, EventArgs e)
        {
            AddExamination?.Invoke();
        }

        public void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
                ShowExamination?.Invoke(PatientId, int.Parse(button.Tag.ToString()));
            }
        }

        public void UpdateExamination(IEnumerable<Examination> examination)
        {
            examPanel.Controls.Clear();

            int i = 0;
            int y = 7;
            foreach (Examination exam in examination)
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
