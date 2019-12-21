using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Training_app.Model.Entity;
using Training_app.Presenter;

namespace Training_app.Views
{
    public partial class PatientView : Form, IPatientView
    {
        public event Action ShowAddPatient;
        public event Action <int> ShowPatientInfo;

        public PatientView()
        {
            InitializeComponent();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAddPatient?.Invoke();
        }

        public void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
                ShowPatientInfo?.Invoke(int.Parse(button.Tag.ToString()));
            }
        }
        public void PatientAdd(Button button)
        {
            patientPanel.Controls.Add(button);
        }   

        public void ShowPatient(IEnumerable<Patient> patients)
        {
            patientPanel.Controls.Clear();
            int y = 7;
            foreach (Patient patient in patients)
            {
                Button button = new Button();
                button.Tag = patient.Id.ToString();
                StringBuilder buttonName = new StringBuilder();
                button.Text = buttonName.Append(patient.Surname)
                                        .Append(" ")
                                        .Append(patient.Name)
                                        .Append(" ")
                                        .Append(patient.Batyaname)
                                        .ToString();

                button.Location = new Point(10, y);
                y += 30;
                button.Width = Width - 40;
                button.BackColor = SystemColors.ScrollBar;
                button.Click += ButtonOnClick;
                button.Font = new Font("Segoe UI", 9f);
                button.TextAlign = ContentAlignment.MiddleLeft;
                patientPanel.Controls.Add(button);
            }
        }
    }
}
