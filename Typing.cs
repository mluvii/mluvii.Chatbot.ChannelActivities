namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Controls the display of the chatbot's typing indicator.
    /// </summary>
    public class Typing : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.Typing"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.Typing;

        /// <summary>
        /// True to show typing indicator, false to hide.
        /// </summary>
        public bool Show { get; set; }
    }
}
