using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_app
{
    public class Examination
    {
        public DateTime Date { get; }
        public short Duration { get; }
        public string ExerciseType { get; }
        public bool BloodPressInd { get; }
        public bool SkinTempInd { get; }
        public bool SkinMoisureInd { get; }
        public bool ElectrCondInd { get; }
        public bool PulseInd { get; }

        public Examination(DateTime date, short duration, string exerciseType, bool bloodPress, bool skinTemp, bool skinMois, bool electrCond, bool pulse)
        {
            Date = date;
            Duration = duration;
            ExerciseType = exerciseType;
            BloodPressInd = bloodPress;
            SkinTempInd = skinTemp;
            SkinMoisureInd = skinMois;
            ElectrCondInd = electrCond;
            PulseInd = pulse;
        }
    }
}
