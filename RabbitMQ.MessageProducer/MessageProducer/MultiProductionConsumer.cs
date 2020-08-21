using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Channels;

namespace RabbitMQ.MessageProducer.MessageProducer
{
    class MultiProductionConsumer
    {
        public static void Show01()
        {
            var factory = new ConnectionFactory();
            factory.HostName = "localhost";
            factory.UserName = "guest";
            factory.Password = "guest";

            using (var connection=factory.CreateConnection())
            {
                using (var channel=connection.CreateModel())
                {
                    channel.QueueDeclare("MultiProducerMessage", true, false, false, null);
                    channel.ExchangeDeclare("MultiProducerMessageExchange", ExchangeType.Direct, true, false, null);
                    channel.QueueBind("MultiProducerMessage", "MultiProducerMessageExchange", string.Empty, null);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("生产者001已准备就绪");

                    int i = 1;
                    while (true)
                    {
                        Console.WriteLine($"生产者01----{Thread.CurrentThread.ManagedThreadId}");
                        string message = $"生产者01：消息{i}";
                        byte[] body = Encoding.UTF8.GetBytes(message);
                        channel.BasicPublish("MultiProducerMessageExchange", string.Empty, null, body);
                        Console.WriteLine($"消息：{message}已发送");
                        i++;
                        Thread.Sleep(1000 * 3);
                    }
                }
            }
        }

        public static void Show02()
        {
            var factory = new ConnectionFactory();
            factory.HostName = "localhost";
            factory.UserName = "guest";
            factory.Password = "guest";

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare("MultiProducerMessage", true, false, false, null);
                    channel.ExchangeDeclare("MultiProducerMessageExchange", ExchangeType.Direct, true, false, null);
                    channel.QueueBind("MultiProducerMessage", "MultiProducerMessageExchange", string.Empty, null);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("生产者002已准备就绪");

                    int i = 1;
                    while (true)
                    {
                        Console.WriteLine($"生产者02----{Thread.CurrentThread.ManagedThreadId}");
                        string message = $"生产者02：消息{i}";
                        byte[] body = Encoding.UTF8.GetBytes(message);
                        channel.BasicPublish("MultiProducerMessageExchange", string.Empty, null, body);
                        Console.WriteLine($"消息：{message}已发送");
                        i++;
                        Thread.Sleep(1000 * 3);
                    }
                }
            }
        }

        public static void Show03()
        {
            var factory = new ConnectionFactory();
            factory.HostName = "localhost";
            factory.UserName = "guest";
            factory.Password = "guest";

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare("MultiProducerMessage", true, false, false, null);
                    channel.ExchangeDeclare("MultiProducerMessageExchange", ExchangeType.Direct, true, false, null);
                    channel.QueueBind("MultiProducerMessage", "MultiProducerMessageExchange", string.Empty, null);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("生产者003已准备就绪");

                    int i = 1;
                    while (true)
                    {
                        Console.WriteLine($"生产者03----{Thread.CurrentThread.ManagedThreadId}");
                        string message = $"生产者03：消息{i}";
                        byte[] body = Encoding.UTF8.GetBytes(message);
                        channel.BasicPublish("MultiProducerMessageExchange", string.Empty, null, body);
                        Console.WriteLine($"消息：{message}已发送");
                        i++;
                        Thread.Sleep(1000*3);
                    }
                }
            }
        }
    }
}
