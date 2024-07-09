namespace mluvii.Chatbot.ChannelActivities
{
    public class SendHeroCardResponse : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.SendHeroCardResponse;

        public bool Success { get; set; }

        public string ErrorMessage { get; set; }
    }
}
