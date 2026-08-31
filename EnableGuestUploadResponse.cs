namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the response to <see cref="EnableGuestUpload"/>.
    /// </summary>
    public class EnableGuestUploadResponse : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.EnableGuestUploadResponse"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.EnableGuestUploadResponse;

        /// <summary>
        /// True if the operation was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Error message if the operation failed.
        /// </summary>
        public string? ErrorMessage { get; set; }
    }
}
