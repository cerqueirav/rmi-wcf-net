using System;

namespace WCFService
{
    namespace RemoteObject
    {
        public class RemoteObject : MarshalByRefObject, IRemoteObject
        {
            public int Calculate(int a, int b, char op)
            {
                ShowLog();
                switch (op)
                {
                    case '+': return a + b;
                    case '-': return a - b;
                    case '*': return a * b;
                    case '/': return a / b;
                    default: return a+b;
                }
            }

            public void ShowLog()
            {
                Console.WriteLine("Operação remota executada em: " + DateTime.Now);
            }
        }
    }

}
