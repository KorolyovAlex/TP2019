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
    public partial class ExaminationForm : Form
    {
        public ExaminationForm(Examination exam)
        {
            InitializeComponent();
            date.Text = exam.Date.ToString("dd.MM.yyyy");
            if(!exam.BloodPressInd)
            {
                BP_Ind.Enabled = false;
            }
            if (!exam.SkinMoisureInd)
            {
                SM_Ind.Enabled = false;
            }
            if (!exam.SkinTempInd)
            {
                ST_Ind.Enabled = false;
            }
            if (!exam.ElectrCondInd)
            {
                EC_Ind.Enabled = false;
            }
            if (!exam.PulseInd)
            {
                Pulse_Ind.Enabled = false;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void activateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
