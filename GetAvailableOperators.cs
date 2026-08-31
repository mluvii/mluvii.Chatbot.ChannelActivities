namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Retrieves a list of logged-in and available operators.
    /// <para>
    /// If the <see cref="GroupId"/> parameter is set, a list of available operators from the selected group is returned.
    /// </para>
    /// <para>
    /// Otherwise (<see cref="GroupId"/> isn't set), the routing conditions are re-evaluated and only a list of available operators from the groups that meet the conditions is returned.
    /// It is therefore possible to change the session parameters and get a list of available operators according to the current parameters.
    /// </para>
    /// </summary>
    public class GetAvailableOperators : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.GetAvailableOperators"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.GetAvailableOperators;

        /// <summary>
        /// Optional Group ID.
        /// </summary>
        public int? GroupId { get; set; }
    }
}
