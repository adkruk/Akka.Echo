//namespace AkkaPubSub
//{
//    using Akka.Actor;
//    using Akka.Cluster.Tools.PublishSubscribe;
//    using Messaging.Common;

//    public class Publisher : ReceiveActor
//    {

//        public Publisher()
//        {
//            var mediator = DistributedPubSub.Get(Context.System).Mediator;

//            this.Receive<string>(str =>
//            {
//                var upperCase = str.ToUpper();
//                mediator.Tell(new Publish(Topics.Topic, upperCase));
//            });
//        }
//    }
//}