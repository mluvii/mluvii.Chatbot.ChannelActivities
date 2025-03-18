namespace mluvii.Chatbot.ChannelActivities
{
    public class RequestLocation : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.RequestLocation;

        public string Text { get; set; }
    }
}
