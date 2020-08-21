using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace RabbitMQ.MessageConsumer_01.MessageProducer
{
    class ProductionConsumer
    {
        public static void Show()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "____11111111");
            var factory = new ConnectionFactory();
            factory.HostName = "localhost";
            factory.UserName = "xzj";
            factory.Password = "995995";
            using (var connection=factory.CreateConnection())
            {
                using (var channel=connection.CreateModel())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    try
                    {
                        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "____1111111222222");
                        var consumer = new EventingBasicConsumer(channel);
                        consumer.Received += (model, ea) =>
                        {
                            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "____222222222222");
                            var body = ea.Body;
                            var message = Encoding.UTF8.GetString(body.Span);
                            Console.WriteLine($"消费者01接收消息 {message}");
                        };
                        channel.BasicConsume(queue: "OnlyProducerManager", autoAck: true, consumer: consumer);
                        Console.WriteLine("press ENTER to exit");
                        Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "____33333333333333");
        }
    }
}
