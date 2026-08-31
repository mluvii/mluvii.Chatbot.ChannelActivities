namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the response to <see cref="SendHeroCard"/>.
    /// </summary>
    public class SendHeroCardResponse : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.SendHeroCardResponse"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.SendHeroCardResponse;

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
