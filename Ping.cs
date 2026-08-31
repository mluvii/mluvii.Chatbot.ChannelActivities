namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents a ping activity.
    /// </summary>
    public class Ping : ChatbotActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.Ping"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.Ping;
    }
}
