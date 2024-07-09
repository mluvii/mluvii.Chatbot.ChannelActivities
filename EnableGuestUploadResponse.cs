namespace mluvii.Chatbot.ChannelActivities
{
    public class EnableGuestUploadResponse : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.EnableGuestUploadResponse;

        public bool Success { get; set; }

        public string ErrorMessage { get; set; }
    }
}
