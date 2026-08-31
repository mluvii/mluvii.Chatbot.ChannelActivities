namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Ends the conversation session.
    /// </summary>
    public class EndConversation : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.EndConversation"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.EndConversation;
    }
}
