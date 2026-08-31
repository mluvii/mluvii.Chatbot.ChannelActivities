namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the response to <see cref="AssignCrmIdentity"/>.
    /// </summary>
    public class AssignCrmIdentityResponse : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.AssignCrmIdentityResponse"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.AssignCrmIdentityResponse;

        /// <summary>
        /// True if a new record was created, false if an existing record was matched.
        /// </summary>
        public bool Created { get; set; }

        /// <summary>
        /// ID of the assigned CRM identity.
        /// </summary>
        public long CrmIdentityId  { get; set; }

        /// <summary>
        /// Reason for failure, if any.
        /// </summary>
        public string Reason { get; set; }
    }
}
