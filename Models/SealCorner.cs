using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader.Models
{
    public partial class SealCorner
    {
        // Empty constructor for EF
        public SealCorner()
        {
        }

        public string sealCornerGroup { get; set; }

        public string sealCornerCode { get; set; }

        public string sealCornerMaterial { get; set; }

        public decimal sealCornerQuantity { get; set; }

        public string sealCornerModul { get; set; }

        public string sealCornerDModDMat { get; set; }

        public string sealCornerDModMat { get; set; }



    }
}
