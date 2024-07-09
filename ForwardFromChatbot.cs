namespace mluvii.Chatbot.ChannelActivities
{
    public class ForwardFromChatbot : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.Forward;

        public int? OperatorGroupId { get; set; }

        public int? UserId { get; set; }
    }
}
