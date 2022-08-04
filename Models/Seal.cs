using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader.Models
{
    public partial class Seal
    {
        // Empty constructor for EF
        public Seal()
        {
        }

        public string sealGroup { get; set; }

        public string sealCode { get; set; }

        public string sealMaterial { get; set; }

        public string sealMaterialUCase { get; set; }

        public int sealL { get; set; }

        public string sealModul { get; set; }

        public string sealDModDMat { get; set; }

        public string sealDModMat { get; set; }

    }
}
