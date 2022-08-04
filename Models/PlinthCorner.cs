using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader.Models
{
    public partial class PlinthCorner
    {

        // Empty constructor for EF
        public PlinthCorner()
        {
        }

        public string plinthCornerGroup { get; set; }

        public string plinthCornerCode { get; set; }

        public string plinthCornerMaterial { get; set; }

        public decimal plinthCornerQuantity { get; set; }

        public string plinthCornerModul { get; set; }

        public string plinthCornerDModDMat { get; set; }

        public string plinthCornerDModMat { get; set; }

        public string plinthCornerUnitNote { get; set; }

    }
}
