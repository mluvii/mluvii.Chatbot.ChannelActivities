using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    public class GetAvailableOperatorsResponse : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.GetAvailableOperatorsResponse;

        public IList<AvailableOperatorInfo> AvailableOperators { get; set; }

        public class AvailableOperatorInfo
        {
            public string DisplayName { get; set; }

            public int UserId { get; set; }
        }
    }
}
