namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Retrieves call parameters associated with the active session.
    /// </summary>
    public class GetCallParams : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.GetCallParams"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.GetCallParams;
    }
}
