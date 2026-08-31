namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Sets a tag for the conversation.
    /// </summary>
    public class SetTag : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.SetTag"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.SetTag;

        /// <summary>
        /// The name of the tag to set.
        /// </summary>
        public string Name { get; set; }
    }
}
