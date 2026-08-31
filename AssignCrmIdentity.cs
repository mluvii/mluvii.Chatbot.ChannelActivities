namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Assigns a guest identity to a new or existing record in the Contact Directory.
    /// This is typically called based on results from <see cref="ObtainCrmIdentity"/>.
    /// </summary>
    public class AssignCrmIdentity : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.AssignCrmIdentity"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.AssignCrmIdentity;

        /// <summary>
        /// ID of an existing CRM identity to assign, or null to create a new one.
        /// </summary>
        public long? ExistingCrmIdentityId { get; set; }
    }
}
