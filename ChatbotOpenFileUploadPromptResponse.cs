namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the response to <see cref="ChatbotOpenFileUploadPrompt"/>.
    /// </summary>
    public class ChatbotOpenFileUploadPromptResponse : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.ChatbotOpenFileUploadPromptResponse"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.ChatbotOpenFileUploadPromptResponse;

        /// <summary>
        /// File URL uploaded by guest, if successful.
        /// </summary>
        public string FileUrl { get; set; }

        /// <summary>
        /// True if the guest canceled the file upload prompt.
        /// </summary>
        public bool CanceledByGuest { get; set; }
    }
}
