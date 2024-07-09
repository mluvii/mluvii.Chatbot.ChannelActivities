namespace mluvii.Chatbot.ChannelActivities
{
    public class SetTag : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.SetTag;

        public string Name { get; set; }
    }
}
