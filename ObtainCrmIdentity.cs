namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Retrieves matching records from the Contact Directory based on the guest's identification data (e.g., name, phone, email).
    /// </summary>
    public class ObtainCrmIdentity : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.ObtainCrmIdentity"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.ObtainCrmIdentity;
    }
}
