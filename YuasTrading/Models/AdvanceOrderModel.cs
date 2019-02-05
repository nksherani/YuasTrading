using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuasTrading.Models
{
    public class AdvanceOrderModel
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Country { get; set; }
        public int YearFrom { get; set; }
        public int YearTo { get; set; }
        public string FuetType { get; set; }
        public string Transmission { get; set; }
        public string DriveTrain { get; set; }
        public string Color { get; set; }
        public float EngineCapacity { get; set; }
        public string Remarks { get; set; }
    }
}