namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Enables guest file upload functionality.
    /// </summary>
    public class EnableGuestUpload : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.EnableGuestUpload"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.EnableGuestUpload;
    }
}
