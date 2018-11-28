namespace Messaging.Client.Messages
{
    public class EchoMessage
    {
        public EchoMessage(string content)
        {
            this.Content = content;
        }

        /// <summary>Gets or sets the content.</summary>
        public string Content { get; set; }
        
    }
}