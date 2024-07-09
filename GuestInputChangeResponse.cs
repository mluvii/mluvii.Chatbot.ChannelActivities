namespace mluvii.Chatbot.ChannelActivities
{
    public class GuestInputChangeResponse : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.GuestInputChangeResponse;

        public bool Success { get; set; }

        public string ErrorMessage { get; set; }
    }
}
