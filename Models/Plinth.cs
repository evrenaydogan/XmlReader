using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader.Models
{
    public partial class Plinth
    {
        // Empty constructor for EF
        public Plinth()
        {
        }

        public string plinthGroup { get; set; }

        public string plinthCode { get; set; }

        public string plinthUniqueCode { get; set; }

        public string plinthMaterial { get; set; }

        public int plinthH { get; set; }

        public int plinthL { get; set; }

        public int plinthT { get; set; }

        public string plinthModul { get; set; }

        public string plinthKitchenDModel { get; set; }

        public string plinthDModDMat { get; set; }

        public string plinthDModMat { get; set; }

        public string plinthUnitNote { get; set; }
    }
}
