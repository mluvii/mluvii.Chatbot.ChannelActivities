namespace mluvii.Chatbot.ChannelActivities
{
    public class DisableGuestUploadResponse : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.DisableGuestUploadResponse;

        public bool Success { get; set; }

        public string ErrorMessage { get; set; }
    }
}
