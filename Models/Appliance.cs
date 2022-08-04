using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader.Models
{
    [Serializable]
    public partial class Appliance
    {
        // Empty constructor for EF
        public Appliance()
        {
        }

        public string applianceGroup { get; set; }

        public string applianceCode { get; set; }

        public decimal applianceQuantity { get; set; }

        public string applianceModul { get; set; }

    }
}
