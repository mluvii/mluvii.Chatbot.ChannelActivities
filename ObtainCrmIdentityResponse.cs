using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    public class ObtainCrmIdentityResponse : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.ObtainCrmIdentityResponse;

        public long? AssignedCrmIdentityId { get; set; }

        public GetSessionCrmIdentityResponseMatch[] MatchedCrmIdentities { get; set; }

        public class GetSessionCrmIdentityResponseMatch
        {
            public long CrmIdentityId { get; set; }

            public double Score { get; set; }

            public IReadOnlyDictionary<string, HashSet<string>> Data { get; set; }
        }
    }
}
