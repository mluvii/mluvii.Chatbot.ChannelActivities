namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the response to <see cref="SetCallParams"/>.
    /// </summary>
    public class SetCallParamsResponse : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.SetCallParamsResponse"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.SetCallParamsResponse;

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
