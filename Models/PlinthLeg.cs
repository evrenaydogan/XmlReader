using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader.Models
{
    public class PlinthLeg
    {

        // Empty constructor for EF
        public PlinthLeg()
        {
        }

        public string plinthLegGroup { get; set; }

        public string plinthLegCode { get; set; }

        public int plinthLegH { get; set; }

        public decimal plinthLegQuantity { get; set; }

        public string plinthLegModul { get; set; }

    }
}
