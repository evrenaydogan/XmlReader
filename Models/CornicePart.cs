using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader.Models
{
    [Serializable]
    public partial class CornicePart
    {
        // Empty constructor for EF
        public CornicePart()
        {
        }

        public string cornicePartGroup { get; set; }

        public string cornicePartCode { get; set; }

        public string cornicePartUniqueCode { get; set; }

        public string cornicePartMaterial { get; set; }

        public string cornicePartMaterialUCase { get; set; }

        public int cornicePartH { get; set; }

        public int cornicePartL { get; set; }

        public int cornicePartT { get; set; }

        public string cornicePartModul { get; set; }

        public string cornicePartKitchenDModel { get; set; }

        public string cornicePartDModMat { get; set; }

        public string cornicePartDModDMat { get; set; }

        public string cornicePartUnitNote { get; set; }
    }
}
