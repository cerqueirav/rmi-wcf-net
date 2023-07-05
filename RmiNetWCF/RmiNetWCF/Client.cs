using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using WCFService;

namespace RmiNetWCF
{
    public class Client
    {
        public static void Run()
        {
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);

            IRemoteObject remoteObject = (IRemoteObject)Activator.GetObject(
                typeof(IRemoteObject), "tcp://localhost:8081/RemoteObject");

            ShowLog();
            Console.WriteLine("Resultado: " + remoteObject.Calculate(5, 3, '+'));
            Console.WriteLine("Resultado: " + remoteObject.Calculate(12, 5, '-'));
            Console.WriteLine("Resultado: " + remoteObject.Calculate(10, 8, '*'));
            Console.WriteLine("Resultado: " + remoteObject.Calculate(120, 10, '/'));
        }

        public static void ShowLog()
        {
            Console.WriteLine("Operação local executada em: " + DateTime.Now);
        }
    }
}
