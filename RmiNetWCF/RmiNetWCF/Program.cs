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
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);

            IRemoteObject remoteObject = (IRemoteObject)Activator.GetObject(
                typeof(IRemoteObject), "tcp://localhost:8081/RemoteObject");

            Log();
            int resultado = remoteObject.Somar(5, 3);
            Console.WriteLine("Resultado: " + resultado);
        }

        public static void Log()
        {
            Console.WriteLine("Operação interna executada em: " + DateTime.Now);
        }
    }
}
