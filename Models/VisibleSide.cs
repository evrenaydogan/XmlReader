using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader.Models
{
    public partial class VisibleSide
    {
        // Empty constructor for EF
        public VisibleSide()
        {
        }
        public string visibleSideGroup { get; set; }

        public string visibleSideCode { get; set; }

        public string visibleSideMaterial { get; set; }

        public int visibleSideW { get; set; }

        public int visibleSideH { get; set; }

        public decimal visibleSideArea { get; set; }

        public string visibleSidePOsition { get; set; }

        public decimal visibleSideQuantity { get; set; }

        public string visibleSideDModDMat { get; set; }

        public string visibleSideNote { get; set; }

    }
}
