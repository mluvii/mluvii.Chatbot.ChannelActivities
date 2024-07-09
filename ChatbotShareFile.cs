namespace mluvii.Chatbot.ChannelActivities
{
    public class ChatbotShareFile : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.ShareFile;

        public string Url { get; set; }

        public string Name { get; set; }
    }
}
