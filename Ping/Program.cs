using System;

using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string ipstring = null; // IP cannot be int or float.

            //long num = Int64.Parse(args[0]);

            /*if (args.Length == 0)
            {
                Console.WriteLine("Usage: ping <ipaddress>");
                Environment.Exit(1);
            }*/
            Console.WriteLine("Enter what you want the data to be."); string pingdata = Console.ReadLine();
            Console.WriteLine("Enter amount of times to ping."); int pingnumInput = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter IP.");

            while(ipstring == null)
            {
                ipstring = Console.ReadLine();
            }

            Ping pingSender = new Ping ();
            PingOptions options = new PingOptions ();

            options.DontFragment = true;

            string data = pingdata; // = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes (data);
            int timeout = 120;
            //PingReply reply = pingSender.Send (args[0], timeout, buffer, options);
            
            int pingnum = 1;
            while (pingnum < pingnumInput + 1)
            {
                PingReply reply = pingSender.Send (ipstring, timeout, buffer, options);
                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine("Ping " + pingnum + " succeeded.");
                }
                else if (reply.Status != IPStatus.Success)
                {
                    Console.WriteLine("Ping " + pingnum + " failed.");
                }
                else
                {
                    Console.WriteLine("Warning, an unknown error occuered.");
                    Environment.Exit(1);
                }
                pingnum++;
            }

            /*if (reply.Status == IPStatus.Success)
            {
                Console.WriteLine ("Address: {0}", reply.Address.ToString ());
                Console.WriteLine ("RoundTrip time: {0}", reply.RoundtripTime);
                // Buggy, idk why..
                // Console.WriteLine ("Time to live: {0}", reply.Options.Ttl);
                //Console.WriteLine ("Don't fragment: {0}", reply.Options.DontFragment);
                //Console.WriteLine ("Buffer size: {0}", reply.Buffer.Length);
            }
            else if(reply.Status != IPStatus.Success)
            {
                Console.WriteLine("Ping failure");
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Warning, an unknown error occuered.");
                Environment.Exit(1);
            }*/

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
