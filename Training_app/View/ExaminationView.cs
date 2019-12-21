using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Training_app.Presenter;
using Training_app.Model.Entity;
using ZedGraph;

namespace Training_app.Views
{
    public partial class ExaminationView : Form, IExaminationView
    {
        public int PatientId { get; set; }
        public int ExaminationId { get; set; }
        private GraphPane _ap;
        private GraphPane _st;
        private GraphPane _sm;
        private GraphPane _sc;
        private GraphPane _p;

        private PointPairList _apList;
        private PointPairList _stList;
        private PointPairList _smList;
        private PointPairList _scList;
        private PointPairList _pList;

        private readonly int _pmax = 140;
        private readonly int _pmin = 40;
        private readonly int _scmax = 35;
        private readonly int _scmin = 20;
        private readonly int _stmax = 45;
        private readonly int _stmin = 32;
        private readonly int _smmax = 100;
        private readonly int _smmin = 0;
        private readonly int _apmax = 300;
        private readonly int _apmin = 0;


        public ExaminationView(Examination exam)
        {
            InitializeComponent();

            _apList = new PointPairList();
            _stList = new PointPairList();
            _smList = new PointPairList();
            _scList = new PointPairList();
            _pList = new PointPairList();

            _ap = arterialPressureGraph.GraphPane;
            _ap.Title.Text = "Артериальное давление";
            _st = skinTemperatureGraph.GraphPane;
            _st.Title.Text = "Температура кожи";
            _sm = skinMoistureGraph.GraphPane;
            _sm.Title.Text = "Влажность кожи";
            _sc = skinConductivityGraph.GraphPane;
            _sc.Title.Text = "Проводимость кожи";
            _p = pulseGraph.GraphPane;
            _p.Title.Text = "Пульс";
        }

        public void UpdateInfo(Examination exam)
        {
            date.Text = exam.Date.ToString("dd.MM.yyyy");
            if (!exam.ArterialPressInd)
            {
                BP_Ind.Enabled = false;
                arterialPressureGraph.Hide();
            }
            else
            {
                _ap.XAxis.Scale.Min = 0;
                _ap.XAxis.Scale.Max = exam.Duration + 1;
                _ap.XAxis.Scale.MajorStep = 1;
                _ap.YAxis.Scale.Max = _apmax;
                _ap.YAxis.Scale.MajorStep = 60;
                arterialPressureGraph.AxisChange();
                arterialPressureGraph.Invalidate();
            }
            if (!exam.SkinMoisureInd)
            {
                SM_Ind.Enabled = false;
                skinMoistureGraph.Hide();
            }
            else
            {
                _sm.XAxis.Scale.Min = 0;
                _sm.XAxis.Scale.Max = exam.Duration + 1;
                _sm.XAxis.Scale.MajorStep = 1;
                _sm.YAxis.Scale.Max = _smmax;
                _sm.YAxis.Scale.MajorStep = 10;
                skinMoistureGraph.AxisChange();
                skinMoistureGraph.Invalidate();
            }
            if (!exam.SkinTempInd)
            {
                ST_Ind.Enabled = false;
                skinTemperatureGraph.Hide();
            }
            else
            {
                _st.XAxis.Scale.Min = 0;
                _st.XAxis.Scale.Max = exam.Duration + 1;
                _st.XAxis.Scale.MajorStep = 1;
                _st.YAxis.Scale.Max = _stmax;
                _st.YAxis.Scale.Min = _stmin;
                _st.YAxis.Scale.MajorStep = 1;
                _st.YAxis.Scale.MinorStep = 0.2;
                skinTemperatureGraph.AxisChange();
                skinTemperatureGraph.Invalidate();
            }
            if (!exam.ElectrCondInd)
            {
                EC_Ind.Enabled = false;
                skinConductivityGraph.Hide();
            }
            else
            {
                _sc.XAxis.Scale.Min = 0;
                _sc.XAxis.Scale.Max = exam.Duration + 1;
                _sc.XAxis.Scale.MajorStep = 1;
                _sc.YAxis.Scale.Max = _scmax;
                _sc.YAxis.Scale.Min = _scmin;
                _sc.YAxis.Scale.MajorStep = 1;
                skinConductivityGraph.AxisChange();
                skinConductivityGraph.Invalidate();
            }
            if (!exam.PulseInd)
            {
                Pulse_Ind.Enabled = false;
                pulseGraph.Hide();
            }
            else
            {
                _p.XAxis.Scale.Min = 0;
                _p.XAxis.Scale.Max = exam.Duration + 1;
                _p.XAxis.Scale.MajorStep = 1;
                _p.YAxis.Scale.Max = _pmax;
                _p.YAxis.Scale.Min = _pmin;
                _p.YAxis.Scale.MajorStep = 20;
                _p.YAxis.Scale.MinorStep = 10;
                pulseGraph.AxisChange();
                pulseGraph.Invalidate();
            }
        }

        public event Action StartExamination;

        private void StartButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            StartExamination?.Invoke();
        }

        public void UpdateAPGraph(int timerTime, int value)
        {
            _apList.Add(timerTime, value);
            _ap.CurveList.Clear();
            _ap.AddCurve(string.Empty, _apList, Color.Red, SymbolType.Triangle);
            arterialPressureGraph.Invalidate();
            BP_Ind.Text = value.ToString();
        }

        public void UpdateSTGraph(int timerTime, double value)
        {
            _stList.Add(timerTime, value);
            _st.CurveList.Clear();
            _st.AddCurve(string.Empty, _stList, Color.Red, SymbolType.Triangle);
            skinTemperatureGraph.Invalidate();
            ST_Ind.Text = value.ToString();
        }

        public void UpdateSMGraph(int timerTime, int value)
        {
            _smList.Add(timerTime, value);
            _sm.CurveList.Clear();
            _sm.AddCurve(string.Empty, _smList, Color.Red, SymbolType.Triangle);
            skinMoistureGraph.Invalidate();
            SM_Ind.Text = value.ToString();
        }

        public void UpdateSCGraph(int timerTime, int value)
        {
            _scList.Add(timerTime, value);
            _sc.CurveList.Clear();
            _sc.AddCurve(string.Empty, _scList, Color.Red, SymbolType.Triangle);
            skinConductivityGraph.Invalidate();
            EC_Ind.Text = value.ToString();
        }

        public void UpdatePGraph(int timerTime, int value)
        {
            _pList.Add(timerTime, value);
            _p.CurveList.Clear();
            _p.AddCurve(string.Empty, _pList, Color.Red, SymbolType.Triangle);
            pulseGraph.Invalidate();
            Pulse_Ind.Text = value.ToString();
        }

        public void ShowEndMessage()
        {
            endMessage.Text = "Обследование завершено";
        }

        private void ActivateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
