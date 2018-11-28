namespace Messaging.Client
{
    using System;
    using Akka.Actor;
    using Messages;

    internal class Program
    {
        //https://bitbucket.org/dandago/gigilabs/downloads/

        private static void Main(string[] args)
        {
            try
            {
                using (var actorSystem = ActorSystem.Create("ActorSystemName"))
                {
                    var subscriberGuid = Guid.NewGuid();
                    var clientActor = actorSystem.ActorOf(Props.Create<ClientActor>(), "ClientActor");

                    HandleInput(clientActor);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static void HandleInput(IActorRef clientActor)
        {
            while (true)
            {
                var text = Console.ReadLine();
                clientActor.Tell(new EchoMessage(text));
            }
        }
    }
}