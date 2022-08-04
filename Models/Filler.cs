using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader.Models
{
    public partial class Filler
    {
        // Empty constructor for EF
        public Filler()
        {
        }

        public string fillerGroup { get; set; }

        public string fillerCode { get; set; }

        public string fillerMaterialBody { get; set; }

        public string fillerMaterialDoor { get; set; }

        public int fillerH { get; set; }

        public int fillerW { get; set; }

        public int fillerD { get; set; }

        public decimal fillerQuantity { get; set; }

        public string fillerModul { get; set; }

        public string fillerDModMat { get; set; }

        public string fillerDModDMat { get; set; }

    }
}
