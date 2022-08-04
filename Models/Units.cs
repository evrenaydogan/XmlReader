using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader.Models
{
    [Serializable]
    public partial class Units
    {

        public string GROUP { get; set; }

        public string CODE { get; set; }

        public string UniqueCode { get; set; }

        public string Model { get; set; }

        public string Model2 { get; set; }

        public string KitchenDModel { get; set; }

        public string Material { get; set; }

        public string DMaterial { get; set; }

        public string DMaterial2 { get; set; }

        public string DModDMat { get; set; }

        public string DMod2DMat2 { get; set; }

        public string HandleModel { get; set; }

        public int HandleCount { get; set; }

        public string DGlassMaterial { get; set; }

        public string DGlassMaterial2 { get; set; }

        public string Direction { get; set; }

        public string DoorDirections { get; set; }

        public int ModulePose { get; set; }

        public int H1 { get; set; }

        public int W1 { get; set; }

        public int D1 { get; set; }

        public int D2 { get; set; }

        //Kontrol
        public decimal AreaM2 { get; set; }

        public int NotchType { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public string Sides { get; set; }

        public string SidesMat { get; set; }

        public string Modul { get; set; }

        public decimal Quantity { get; set; }

        public decimal Angle { get; set; }

        public string InsertionPoint { get; set; }

        public string UnitNote { get; set; }
    }
}
