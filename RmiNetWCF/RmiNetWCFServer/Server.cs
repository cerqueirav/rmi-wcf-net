using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using WCFService.RemoteObject;

namespace RmiNetWCFServer
{
    public class Server
    {
        public static void Run()
        {
            TcpChannel channel = new TcpChannel(8081);
            ChannelServices.RegisterChannel(channel, false);

            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(RemoteObject), "RemoteObject", WellKnownObjectMode.Singleton);

            Console.WriteLine("Servidor iniciado. Pressione Enter para sair.");
            Console.ReadLine();
        }
    }
}
