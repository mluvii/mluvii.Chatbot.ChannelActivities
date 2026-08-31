namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the response to <see cref="ShareFile"/>.
    /// </summary>
    public class ShareFileResponse : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.ShareFileResponse"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.ShareFileResponse;

        /// <summary>
        /// True if the operation was successful.
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Error message if the operation failed.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Source of the file.
        /// </summary>
        public string FileSource { get; set; }
    }
}
