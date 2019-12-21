using System;
using System.Windows.Forms;
using Training_app.Presenter;

namespace Training_app.Views
{
    public partial class AddPatientView : Form, IAddPatientView
    {
        public AddPatientView()
        {
            InitializeComponent();
            nameBox1.Text = nameBox2.Text = nameBox3.Text = string.Empty;
        }

        public new void Show()
        {
            base.Show();
        }

        public string FName => nameBox2.Text;
        public string Surname => nameBox1.Text;
        public string BatyaName => nameBox3.Text;
        public string Sex => maleRadioButton.Checked ? "Мужской" : "Женский";
        public byte Age => (byte)ageBox.Value;

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public event Action AddPatient;

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (nameBox1.Text != string.Empty && nameBox2.Text != string.Empty && nameBox3.Text != string.Empty)
            {
                AddPatient?.Invoke();
            }
        }
    }
}
