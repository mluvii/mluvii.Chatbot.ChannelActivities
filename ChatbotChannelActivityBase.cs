namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the base class for all chatbot activities executed within a session.
    /// </summary>
    public abstract class ChatbotChannelActivityBase : ChatbotActivityBase
    {
        /// <summary>
        /// The ID of the session where the activity is to be executed.
        /// The chatbot must be connected to this session.
        /// </summary>
        public long SessionId { get; set; }
    }
}
