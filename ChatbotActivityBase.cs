namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the base class for all chatbot activities.
    /// </summary>
    public abstract class ChatbotActivityBase
    {
        /// <summary>
        /// The type of the activity.
        /// </summary>
        public abstract ChannelActivityType Activity { get; }
    }
}
