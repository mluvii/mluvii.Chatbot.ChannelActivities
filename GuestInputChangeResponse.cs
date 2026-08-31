namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the response to <see cref="EnableGuestInput"/> or <see cref="DisableGuestInput"/>.
    /// </summary>
    public class GuestInputChangeResponse : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.GuestInputChangeResponse"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.GuestInputChangeResponse;

        /// <summary>
        /// True if the operation was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Error message if the operation failed.
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
