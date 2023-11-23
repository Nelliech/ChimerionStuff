using System.ComponentModel;

namespace ChimerionStuffApi.Models.Instruments
{
    public class Guitar : Instrument
    {
        public string Body { get; set; } //Enum
        public string Neck { get; set; } //enum?
        public string NeckConstruction { get; set; } //Enum?
        public string FretBoard { get; set; } //enum?
        public int NumberFrets { get; set; } //Enum ?
        //public string PickUp { get; set; } // Must Be Enum
        public NumberStringsEnum NumberStrings { get; set; } = NumberStringsEnum._6; 
        public string Bridge { get; set; } 
        public string Color { get; set; }
    }
    public enum NumberStringsEnum
    {
        [Description("6")]
        _6=1,
        [Description("7")]
        _7 = 2,
        [Description("8")]
        _8=3,
        [Description("12")]
        _12 = 4
    }
}
