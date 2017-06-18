using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSRSale
{
    class PickerData
    {
        public DateTime Date { get; set; }
        public List<string> Location { get; set; }
        public List<string> Account { get; set; }
        public List<string> Category { get; set; }
        public List<string> SKU { get; set; }

    }
}
