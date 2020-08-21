using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace RabbitMQ.MessageConsumer_01.MessageProducer
{
    class MultiProductionConsumer
    {
        public static void Show01()
        {
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
                        var consumer = new EventingBasicConsumer(channel);
                        consumer.Received += (model, ea) =>
                        {
                            var body = ea.Body;
                            var message = Encoding.UTF8.GetString(body.ToArray());
                            Console.WriteLine($"消费之01 接收消息：{message}");
                        };
                        channel.BasicConsume("MultiProducerMessage", true, consumer);
                        Console.WriteLine(" Press [enter] to exit.");
                        Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }

        public static void Show02()
        {
            var factory = new ConnectionFactory();
            factory.HostName = "localhost";
            factory.UserName = "xzj";
            factory.Password = "995995";

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    try
                    {
                        var consumer = new EventingBasicConsumer(channel);
                        consumer.Received += (model, ea) =>
                        {
                            var body = ea.Body;
                            var message = Encoding.UTF8.GetString(body.ToArray());
                            Console.WriteLine($"消费之02 接收消息：{message}");
                        };
                        channel.BasicConsume("MultiProducerMessage", true, consumer);
                        Console.WriteLine(" Press [enter] to exit.");
                        Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }

        public static void Show03()
        {
            var factory = new ConnectionFactory();
            factory.HostName = "localhost";
            factory.UserName = "xzj";
            factory.Password = "995995";

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    try
                    {
                        var consumer = new EventingBasicConsumer(channel);
                        consumer.Received += (model, ea) =>
                        {
                            var body = ea.Body;
                            var message = Encoding.UTF8.GetString(body.ToArray());
                            Console.WriteLine($"消费之03 接收消息：{message}");
                        };
                        channel.BasicConsume("MultiProducerMessage", true, consumer);
                        Console.WriteLine(" Press [enter] to exit.");
                        Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }
    }
}
