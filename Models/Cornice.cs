using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader.Models
{
    [Serializable]
    public partial class Cornice
    {
        // Empty constructor for EF
        public Cornice()
        {
        }

        public string corniceGroup { get; set; }

        public string corniceCode { get; set; }

        public string corniceUniqueCode { get; set; }

        public string corniceMaterial { get; set; }

        public string corniceMaterialUCase { get; set; }

        public int corniceH { get; set; }

        public int corniceL { get; set; }

        public int corniceT { get; set; }

        public string corniceModul { get; set; }

        public string corniceKitchenDModel { get; set; }

        public string corniceDModMat { get; set; }

        public string corniceDModDMat { get; set; }

        public string corniceUnitNote { get; set; }
    }
}
