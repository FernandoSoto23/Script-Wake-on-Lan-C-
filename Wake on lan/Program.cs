using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Wake_on_lan
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Programa de consola WakeOnLan");
            Console.WriteLine("------------------------------");
            
            try
            {
                string macAddress = "7C-10-C9-8B-82-14";// aqui va la direccion mac de la pc
                models.WolSecond.SendWakeOnLan(PhysicalAddress.Parse(macAddress));
            }
            catch (Exception error)
            {
                Console.WriteLine("Se ha detectado el siguiente error" + error);
                throw;
            }


        }
    }
}
