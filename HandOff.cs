namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Returns the interaction to the routing engine for parameter re-evaluation.
    /// After calling this activity, the chatbot is disconnected from the session.
    /// We recommend determining the availability of target operators or groups using <see cref="GetAvailableOperators"/> or <see cref="GetAvailableGroups"/> before calling this.
    /// <para>
    /// The result of the Handoff operation depends on the state of the group:
    /// <list type="bullet">
    /// <item>ONLINE - the session is assigned to an operator.</item>
    /// <item>BUSY - the session is placed in the group queue.</item>
    /// <item>OFFLINE - an offline form is displayed to the client.</item>
    /// </list>
    /// </para>
    /// </summary>
    public class HandOff : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.HandOff"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.HandOff;
    }
}
