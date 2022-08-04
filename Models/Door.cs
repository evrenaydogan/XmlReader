using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader
{
    public partial class Door
    {

        // Empty constructor for EF
        public Door()
        {
        }

        public string doorGroup { get; set; }

        public string doorCode { get; set; }

        public string doorType { get; set; }

        public string doorModel { get; set; }

        public string doorMaterial { get; set; }     

        public string doorDirection { get; set; }

        public string doorOpenDirection { get; set; }

        public int doorModulePose { get; set; }

        public string doorBrand { get; set; }

        public string doorModul { get; set; }

        public int doorH { get; set; }

        public int doorW { get; set; }

        public int doorMatRota { get; set; }

        public decimal doorQuantity { get; set; }

    }
}
