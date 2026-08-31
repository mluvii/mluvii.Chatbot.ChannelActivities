using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Retrieves a list of operator groups and their current statuses.
    /// <para>
    /// If the <see cref="GroupIds"/> field is defined, a list of groups according to this field is returned.
    /// </para>
    /// <para>
    /// Otherwise, the routing conditions are re-evaluated and a list of groups that meet the conditions is returned.
    /// It is therefore possible to change the session parameters and get a list of available operators according to the current parameters.
    /// </para>
    /// </summary>
    public class GetAvailableGroups : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.GetAvailableGroups"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.GetAvailableGroups;

        /// <summary>
        /// Optional field to filter by specific group IDs.
        /// </summary>
        public ICollection<int>? GroupIds { get; set; }
    }
}
