using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader.Models
{
    public partial class Worktop
    {
        // Empty constructor for EF
        public Worktop()
        {
        }

        public string worktopGroup { get; set; }

        public string worktopCode { get; set; }

        public string worktopMaterial { get; set; }

        public string worktopMaterialUCase { get; set; }

        public int worktopL1 { get; set; }

        public int worktopL2 { get; set; }

        public int worktopT { get; set; }

        public int worktopUnitLenght { get; set; }

        public int worktopMtulLenght { get; set; }

        public decimal worktopQuantity { get; set; }

        public string worktopModul { get; set; }
    }
}
