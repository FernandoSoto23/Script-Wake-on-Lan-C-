using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Wake_on_lan.models
{
    class WolSecond
    {
        public static void SendWakeOnLan(PhysicalAddress target)
        {
            var header = Enumerable.Repeat(byte.MaxValue, 6);
            var data = Enumerable.Repeat(target.GetAddressBytes(), 16).SelectMany(mac => mac);

            var magicPacket = header.Concat(data).ToArray();

            
            using (var client = new UdpClient())
            {
                client.Send(magicPacket, magicPacket.Length, new IPEndPoint(IPAddress.Broadcast, 9));
            }

                
        }
    }
}
