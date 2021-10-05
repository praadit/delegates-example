using System.Threading;
using System;

namespace DelegateExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Insert a Message : ");
            string text = Console.ReadLine();
            Messages message = new Messages();
            MessageReceiver receiver = new MessageReceiver();

            message.messageSent += receiver.OnMessageReceived;

            message.SendMessage(text);
        }
    }

    public class MessageReceiver{
        public void OnMessageReceived(object source, MessageData e){
            Console.WriteLine($"Message received : {e.MessageText}");
        }
    }
}
