using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader.Models
{
    public partial class Extra
    {
        // Empty constructor for EF
        public Extra()
        {
        }

        public string extraGroup { get; set; }

        public string extraCode { get; set; }

        public decimal extraQuantity { get; set; }

        public string extraQuantityUnit { get; set; }

        public string extraType { get; set; }

        public string extraDModDMat { get; set; }

        public string extraModul { get; set; }

    }
}
