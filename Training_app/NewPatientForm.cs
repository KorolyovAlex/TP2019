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
    public partial class NewPatientForm : Form
    {
        private MainForm parentForm;

        public NewPatientForm(MainForm form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            parentForm.PatientList.Add(new Patient(nameBox1.Text, nameBox2.Text, nameBox3.Text, maleRadioButton.Checked ? "Мужской" : "Женский", (byte)ageBox.Value));

            Button button = new Button();
            button.Tag = (parentForm.PatientList.Count - 1).ToString();
            StringBuilder buttonName = new StringBuilder();
            button.Text = buttonName.Append(nameBox1.Text)
                                    .Append(" ")
                                    .Append(nameBox2.Text)
                                    .Append(" ")
                                    .Append(nameBox3.Text)
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
