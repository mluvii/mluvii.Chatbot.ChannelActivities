namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the response to <see cref="DisableGuestUpload"/>.
    /// </summary>
    public class DisableGuestUploadResponse : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.DisableGuestUploadResponse"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.DisableGuestUploadResponse;

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
