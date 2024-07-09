namespace mluvii.Chatbot.ChannelActivities
{
    public class SetCallParamsResponse : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.SetCallParamsResponse;

        public bool Success { get; set; }

        public string ErrorMessage { get; set; }
    }
}
