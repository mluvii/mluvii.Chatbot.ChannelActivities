using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the response to <see cref="GetAvailableOperators"/>.
    /// </summary>
    public class GetAvailableOperatorsResponse : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.GetAvailableOperatorsResponse"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.GetAvailableOperatorsResponse;

        /// <summary>
        /// List of available operators.
        /// </summary>
        public IList<AvailableOperatorInfo> AvailableOperators { get; set; }

        /// <summary>
        /// Information about an available operator.
        /// </summary>
        public class AvailableOperatorInfo
        {
            /// <summary>
            /// Operator's display name.
            /// </summary>
            public string DisplayName { get; set; }

            /// <summary>
            /// Operator's user ID.
            /// </summary>
            public int UserId { get; set; }
        }
    }
}
