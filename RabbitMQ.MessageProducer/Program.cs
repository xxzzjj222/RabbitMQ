using RabbitMQ.MessageProducer.MessageProducer;
using System;
using System.Dynamic;
using System.Threading;
using System.Threading.Tasks;

namespace RabbitMQ.MessageProducer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "____0000000000000");
            #region 生产者消费者
            //ProductionConsumer.Show(); 
            #endregion

            #region 多生产者消费者
            //Task.Run(() => { MultiProductionConsumer.Show01(); });
            //Task.Run(() => { MultiProductionConsumer.Show02(); });
            //Task.Run(() => { MultiProductionConsumer.Show03(); }); 
            #endregion

            #region 发布订阅
            PublishSubscribeConsumber.Show(); 
            #endregion

            Console.Read();
        }
    }
}
