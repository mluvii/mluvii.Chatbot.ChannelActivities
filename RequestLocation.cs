namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Requests the guest's geographical location via their browser. This works on both desktop and mobile devices.
    /// </summary>
    public class RequestLocation : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.RequestLocation"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.RequestLocation;

        /// <summary>
        /// Optional text message to display with the request.
        /// </summary>
        public string? Text { get; set; }
    }
}
