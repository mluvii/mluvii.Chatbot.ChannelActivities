namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Retrieves the guest's identity properties.
    /// </summary>
    public class GetGuestIdentity : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.GetGuestIdentity"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.GetGuestIdentity;
    }
}
