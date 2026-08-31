namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Triggers a file upload dialog for the guest.
    /// </summary>
    public class ChatbotOpenFileUploadPrompt : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.ChatbotOpenFileUploadPrompt"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.ChatbotOpenFileUploadPrompt;
    }
}
