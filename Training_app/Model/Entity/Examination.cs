using System;

namespace Training_app.Model.Entity
{
    public class Examination : EntityBase
    {
        public DateTime Date { get; set; }
        public short Duration { get; set; }
        public string ExerciseType { get; set; }
        public bool ArterialPressInd { get; set; }
        public bool SkinTempInd { get; set; }
        public bool SkinMoisureInd { get; set; }
        public bool ElectrCondInd { get; set; }
        public bool PulseInd { get; set; }
    }
}
