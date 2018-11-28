namespace Messaging.Client
{
    using System;
    using Akka.Actor;
    using Messages;

    public class EchoClient : TypedActor, IHandle<EchoMessage>
    {
        public EchoClient()
        {
            this.Subscribe();
        }

        private void Subscribe()
        {
           
        }

        /// <summary></summary>
        /// <param name="message"></param>
        public void Handle(EchoMessage message)
        {
            Console.WriteLine($"Received message: {message.Content}");
        }
    }
}