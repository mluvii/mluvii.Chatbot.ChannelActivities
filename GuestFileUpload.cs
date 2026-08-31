namespace mluvii.Chatbot.ChannelActivities
{
    public class GuestFileUpload : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.GuestFileUpload;

        public string FileUrl { get; set; }
    }
}
