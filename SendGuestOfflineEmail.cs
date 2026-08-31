namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Sends an email for messages received via the offline form. The offline form must be configured at the widget level.
    /// </summary>
    public class SendGuestOfflineEmail : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.SendGuestOfflineEmail"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.SendGuestOfflineEmail;

        /// <summary>
        /// Email subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Email message content.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Message source for distinction, e.g.: "Chatbot Mluviik".
        /// </summary>
        public string Location { get; set; }
    }
}
