using System;
using Training_app.Model.Entity;

namespace Training_app.Model.Service
{
    public class ExaminationService : IExaminationService
    {
        private ITimer _timer;
        private short _duration;
        public int TimeCounter { get; set; }
        public int APValue { get; set; }
        public double STValue { get; set; }
        public int SMValue { get; set; }
        public int SCValue { get; set; }
        public int PValue { get; set; }

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
        private Random rand;

        public event Action TimerTicked;
        public event Action ExaminationEnded;

        public ExaminationService(ITimer timer)
        {
            TimeCounter = 0;
            _timer = timer;
            _timer.Interval = 1000;
            rand = new Random();
        }

        public void StartExamination(Examination examination)
        {
            _duration = examination.Duration;

            if (examination.ArterialPressInd)
            {
                _timer.Tick += ChangeAPValue;
            }
            if (examination.SkinTempInd)
            {
                _timer.Tick += ChangeSTValue;
            }
            if (examination.SkinMoisureInd)
            {
                _timer.Tick += ChangeSMValue;
            }
            if (examination.ElectrCondInd)
            {
                _timer.Tick += ChangeSCValue;
            }
            if (examination.PulseInd)
            {
                _timer.Tick += ChangePValue;
            }
            _timer.Tick += TimerTick;
            _timer.Start();
        }

        private void TimerTick(object Sender, EventArgs e)
        {
            TimeCounter++;
            TimerTicked?.Invoke();

            if (TimeCounter == _duration)
            {
                _timer.Stop();
                ExaminationEnded?.Invoke();
                return;
            }
        }

        private void ChangeAPValue(object Sender, EventArgs e)
        {
            APValue = rand.Next(_apmin, _apmax);
        }

        private void ChangeSTValue(object Sender, EventArgs e)
        {
            STValue = rand.Next(_stmin * 10, _stmax * 10) / 10.0;
        }

        private void ChangeSMValue(object Sender, EventArgs e)
        {
            SMValue = rand.Next(_smmin, _smmax);
        }

        private void ChangeSCValue(object Sender, EventArgs e)
        {
            SCValue = rand.Next(_scmin, _scmax);
        }

        private void ChangePValue(object Sender, EventArgs e)
        {
            PValue = rand.Next(_pmin, _pmax);
        }
    }
}
