using DuckDns_DUC.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DuckDns_DUC.Common
{
    public static class Utils
    {
        public static Config LeerConfiguracionDesdeXml(string filePath)
        {
            if (!File.Exists((filePath)))            
                return new Config();
            
            XmlSerializer serializer = new XmlSerializer(typeof(Config));
            using (StreamReader reader = new StreamReader(filePath))
            {
                return (Config)serializer.Deserialize(reader);
            }
        }

        public static void EscribirConfiguracionEnXml(string filePath, Config config)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Config));
            using (StreamWriter writer = new StreamWriter(filePath, false)) // 'false' para sobrescribir
            {
                serializer.Serialize(writer, config);
            }           
        }
        public static  List<NetworkInterfacesDTO> GetNetworkInterfaces()
        {
            var res = new List<NetworkInterfacesDTO>();

            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                var tmp = new NetworkInterfacesDTO();
                tmp.Id = networkInterface.Id;
                tmp.Name = networkInterface.Name;
                tmp.Description = networkInterface.Description;
                tmp.Tipo = networkInterface.NetworkInterfaceType.ToString();
                tmp.Estado = networkInterface.OperationalStatus.ToString();

                IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();
                tmp.SufijoDNS = ipProperties.DnsSuffix;
                foreach (UnicastIPAddressInformation unicastIPAddress in ipProperties.UnicastAddresses)
                {
                    if (unicastIPAddress.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        tmp.DireccionIPv4 = unicastIPAddress.Address.ToString();
                    }
                    else if (unicastIPAddress.Address.AddressFamily == AddressFamily.InterNetworkV6)
                    {
                        tmp.DireccionIPv6 = unicastIPAddress.Address.ToString();
                    }
                }
                res.Add(tmp);
            }

            return res;
        }
    }
}
