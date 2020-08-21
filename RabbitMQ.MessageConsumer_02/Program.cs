using RabbitMQ.MessageConsumer_02.MessageProducer;
using System;

namespace RabbitMQ.MessageConsumer_02
{
    class Program
    {
        static void Main(string[] args)
        {
            PublishSubscribeConsumer.Show();

            //Console.Read();
        }
    }
}
