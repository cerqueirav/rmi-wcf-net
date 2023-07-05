using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using WCFService;

namespace RmiNetWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Client.Run();
        }
    }
}
