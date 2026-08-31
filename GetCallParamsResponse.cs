using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the response to <see cref="GetCallParams"/>.
    /// </summary>
    public class GetCallParamsResponse : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.GetCallParamsResponse"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.GetCallParamsResponse;

        /// <summary>
        /// Call parameters associated with the session.
        /// </summary>
        public IDictionary<string, string> CallParams { get; set; }
    }
}
