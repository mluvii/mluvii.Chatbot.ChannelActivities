namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Removes a tag from the conversation.
    /// </summary>
    public class UnsetTag : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.UnsetTag"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.UnsetTag;

        /// <summary>
        /// The name of the tag to remove.
        /// </summary>
        public string Name { get; set; }
    }
}
