namespace mluvii.Chatbot.ChannelActivities
{
    public class GetAvailableOperators : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.GetAvailableOperators;

        public int? GroupId { get; set; }
    }
}
