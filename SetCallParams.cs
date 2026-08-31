using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Sets call parameters for the active session.
    /// </summary>
    public class SetCallParams : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.SetCallParams"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.SetCallParams;

        /// <summary>
        /// Call parameters to set.
        /// </summary>
        public IDictionary<string, string> CallParams { get; set; }
    }
}
