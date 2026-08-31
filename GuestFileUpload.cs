namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Notifies the chatbot that the guest has uploaded a file.
    /// </summary>
    public class GuestFileUpload : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.GuestFileUpload"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.GuestFileUpload;

        /// <summary>
        /// The URL of the uploaded file.
        /// </summary>
        public string FileUrl { get; set; }
    }
}
