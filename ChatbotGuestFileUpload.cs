namespace mluvii.Chatbot.ChannelActivities
{
    public class ChatbotGuestFileUpload : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.GuestFileUpload;

        public string FileUrl { get; set; }
    }
}
