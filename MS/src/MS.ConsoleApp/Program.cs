using RabbitMQ.Client;
using System;
using System.Text;

namespace MS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true){
                EnviarMensagem();
            }
        }

        private static void EnviarMensagem(){
            var factory = new ConnectionFactory() { HostName = "ms-rabbitmq", Port=15692, UserName = "msuser", Password = "msuser" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "RegistrarMensagemCommand",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments:null );

                string message = "Hello World!";
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                     routingKey: "RegistrarMensagemCommand",
                                     basicProperties: null,
                                     body: body);
                Console.WriteLine(" [x] Sent {0}", message);
            }
           System.Threading.Thread.Sleep(5000);
        }
    }
}
