namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Disables guest file upload functionality.
    /// </summary>
    public class DisableGuestUpload : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.DisableGuestUpload"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.DisableGuestUpload;
    }
}
