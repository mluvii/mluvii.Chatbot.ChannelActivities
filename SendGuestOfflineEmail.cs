namespace mluvii.Chatbot.ChannelActivities
{
    public class SendGuestOfflineEmail : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.SendGuestOfflineEmail;

        public string Subject { get; set; }

        public string Message { get; set; }

        public string Location { get; set; }
    }
}
