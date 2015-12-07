using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorySerialSearcher
{
    class ADComputer
    {
        public string name { get; set; }
        public string netbootGUID { get; set; }
        public string DN { get; set; }
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        
        public ADComputer()
        {
        }
    }
}
