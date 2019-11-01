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
    public partial class MainForm : Form
    {
        public List<Patient> PatientList { get; } = new List<Patient>();
        public int y = 7;

        public MainForm()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPatientForm newForm = new NewPatientForm(this);
            newForm.Show();
        }

        public void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
                PatientInfoForm newForm1 = new PatientInfoForm(PatientList[int.Parse(button.Tag.ToString())]);
                newForm1.Show();
            }
        }
        public void PatientAdd(Button button)
        {
            patientPanel.Controls.Add(button);
        }
    }
}
