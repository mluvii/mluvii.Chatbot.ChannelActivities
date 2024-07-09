namespace mluvii.Chatbot.ChannelActivities
{
    public class UnsetTag : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.UnsetTag;

        public string Name { get; set; }
    }
}
