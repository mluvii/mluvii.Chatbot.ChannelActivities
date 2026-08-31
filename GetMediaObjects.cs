namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Retrieves a list of files stored in mluvii that are available for the session.
    /// </summary>
    public class GetMediaObjects : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.GetMediaObjects"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.GetMediaObjects;
    }
}
