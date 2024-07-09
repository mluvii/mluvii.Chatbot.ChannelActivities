namespace mluvii.Chatbot.ChannelActivities
{
    public class ChatbotOpenFileUploadPromptResponse : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.ChatbotOpenFileUploadPromptResponse;

        public string FileUrl { get; set; }

        public bool CanceledByGuest { get; set; }
    }
}
