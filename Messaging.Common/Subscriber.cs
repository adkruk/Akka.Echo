//namespace Messaging.Common
//{
//    using Akka.Actor;
//    using Akka.Event;

//    public static class Topics
//    {
//        public const string Topic = "topic";
//    }

//    public class Subscriber : ReceiveActor
//    {
//        private readonly ILoggingAdapter logger = Context.GetLogger();


//        public Subscriber()
//        {
//            var mediator = DistributedPubSub.Get(Context.System).Mediator;

//            // subscribe to the topic named "content"
//            mediator.Tell(new Subscribe(Topics.Topic, this.Self));

//            this.Receive<string>(s =>
//            {
//                this.logger.Info($"Got {s}");
//            });

//            this.Receive<SubscribeAck>(subscribeAck =>
//            {
//                if (subscribeAck.Subscribe.Topic.Equals(Topics.Topic)
//                    && subscribeAck.Subscribe.Ref.Equals(this.Self)
//                    && subscribeAck.Subscribe.Group == null)
//                {
//                    this.logger.Info("subscribing");
//                }
//            });

//        }
//    }
//}