using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader.Models
{
    public partial class Sink
    {
        // Empty constructor for EF
        public Sink()
        {
        }

        public string sinkGroup { get; set; }

        public string sinkCode { get; set; }

        public string sinkBrand { get; set; }

        public decimal sinkQuantity { get; set; }

        public string sinkModul { get; set; }

    }
}
