using System.Threading;
using System;

namespace DelegateExample
{
    public class MessageData : EventArgs
    {
        public string MessageText { get; set; }
    }

    public class Messages
    {
        // You can declare delegate and event separately
        // public delegate void MessageSentEventHandler(object source, MessageData message);
        // public event MessageSentEventHandler messageSent;

        // Or you can only declare EventHandler
        public event EventHandler<MessageData> messageSent;

        public void SendMessage(string text){
            Console.WriteLine("Sending message ... ");
            Thread.Sleep(3000);

            OnMessageSent(text);
        }

        protected virtual void OnMessageSent(string text){
            if(messageSent != null){
                messageSent(this, new MessageData{ MessageText = text });
            }
        }
    }
}
