using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RabbitMQ.MessageProducer.MessageProducer
{
    class ProductionConsumer
    {
        public static void Show()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId +"____11111111");
            var factory = new ConnectionFactory();
            factory.HostName = "localhost";
            factory.Password = "guest";
            factory.UserName = "guest";
            using (var connection = factory.CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "OnlyProducerManager", durable: true, exclusive: false, autoDelete: false, arguments: null);
                    channel.ExchangeDeclare(exchange: "OnlyProducerMessageExchange", type: ExchangeType.Direct, durable: true, autoDelete: false, arguments: null);
                    channel.QueueBind(queue: "OnlyProducerManager", exchange: "OnlyProducerMessageExchange", routingKey: string.Empty, arguments: null);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("生产者ProducerDemo已准备就绪");
                    int i = 1;
                    while (true)
                    {
                        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "____222222222");
                        string message = $"消息{i}";
                        byte[] body = Encoding.UTF8.GetBytes(message);
                        channel.BasicPublish(exchange: "OnlyProducerMessageExchange", routingKey: string.Empty, basicProperties: null, body: body);
                        Console.WriteLine($"消息：{message}已发送");
                        i++;
                        Thread.Sleep(1000 * 1);
                    }
                }
            }
        }
    }
}
