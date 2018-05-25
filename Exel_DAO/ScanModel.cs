using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exel_DAO
{
    public class ScanModel
    {
        public decimal id { get; set; }
        public string code { get; set; }
        public string model { get; set; }
        public string shift { get; set; }
        public string date { get; set; }
        public string scan { get; set; }
        public int line { get; set; }
        public decimal quantity { get; set; }
        public string table { get; set; }
    }
}
