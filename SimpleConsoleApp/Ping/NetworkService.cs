using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp.Ping
{
    public class NetworkService
    {
        public string SendPing()
        {

            return "Success:Ping Send";
        }

        public int PingTimeout(int a, int b)
        {
            return a + b;
        }

        public DateTime LastPingDate()
        {
            return DateTime.Now;
        }
        public PingOptions GetPingOptions() //PingOptions>object in .net
        {
            return new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };
            //var pingOptions = new PingOptions()
            //{
            //    DontFragment = true,
            //    Ttl = 1
            //};
            //return pingOptions;
        }
        public IEnumerable<PingOptions> MostRecentPings()
        {
            IEnumerable<PingOptions> pingOptions = new[]
            {
                new PingOptions()
                {
                     DontFragment = true,
                      Ttl = 1
                },
                 new PingOptions()
                {
                     DontFragment = true,
                      Ttl = 1
                },
                  new PingOptions()
                {
                     DontFragment = true,
                      Ttl = 1
                },
            };
            return pingOptions;

        }

    }
}
