using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DuckDns_DUC.Types
{
    public class NetworkInterfacesDTO
    {
        public string Id{ get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tipo { get; set; }   
        public string Estado { get; set; }
        public string DireccionIPv4 { get; set; }
        public string DireccionIPv6 { get; set; }

        public string SufijoDNS { get; set; }
    }
}
