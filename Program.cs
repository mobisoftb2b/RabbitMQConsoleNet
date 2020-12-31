using System;
using NLog;

namespace RabbitMQConsoleNet
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Error("Hello World! stam");

            SendReceive s = new SendReceive();
            s.Init();

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
            s.Close();

        }
    }
}
