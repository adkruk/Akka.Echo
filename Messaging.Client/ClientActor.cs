namespace Messaging.Client
{
    using Akka.Actor;
    using Messages;

    public class ClientActor : TypedActor, IHandle<EchoMessage>
    {
        public void Handle(EchoMessage message)
        {
            
        }
    }
}