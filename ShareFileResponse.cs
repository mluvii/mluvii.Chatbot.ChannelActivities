namespace mluvii.Chatbot.ChannelActivities
{
    public class ShareFileResponse : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.ShareFileResponse;

        public bool IsSuccess { get; set; }

        public string ErrorMessage { get; set; }

        public string FileSource { get; set; }
    }
}
