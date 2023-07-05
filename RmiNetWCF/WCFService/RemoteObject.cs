using System;

namespace WCFService
{
    namespace RemoteObject
    {
        public class RemoteObject : MarshalByRefObject, IRemoteObject
        {
            public int Somar(int a, int b)
            {
                Log();
                return a + b;
            }

            public void Log()
            {
                Console.WriteLine("Operação remota executada em: " + DateTime.Now);
            }
        }
    }

}
