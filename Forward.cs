namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Forwards the session to a live operator. Either <see cref="OperatorGroupId"/> or <see cref="UserId"/> must be set.
    /// <para>
    /// Forwarded sessions ignore configured capacity rules (group queue limit/operator slots).
    /// If this is not desirable, either handle the capacity manually using <see cref="GetAvailableOperators"/> / <see cref="GetAvailableGroups"/> or use <see cref="HandOff"/> activity instead.
    /// </para>
    /// <para>
    /// Routing parameters are not re-evaluated. To re-evaluate parameters (e.g., after changing session parameters), use the <see cref="HandOff"/> activity.
    /// </para>
    /// </summary>
    public class Forward : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.Forward"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.Forward;

        /// <summary>
        /// The ID of the operator group to forward to. Optional if <see cref="UserId"/> is set.
        /// </summary>
        public int? OperatorGroupId { get; set; }

        /// <summary>
        /// The ID of the specific user to forward to. Optional if <see cref="OperatorGroupId"/> is set.
        /// </summary>
        public int? UserId { get; set; }
    }
}
