namespace mluvii.Chatbot.ChannelActivities
{
    public class Typing : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.Typing;

        public bool Show { get; set; }
    }
}
