using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader
{
    public partial class Handle
    {
        // Empty constructor for EF
        public Handle()
        {
        }

        public string handleGroup { get; set; }

        public string handleCode { get; set; }

        public string handleModel { get; set; }

        public decimal handleQuantity { get; set; }

        public string handleModul { get; set; }

    }
}
