using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the response to <see cref="ObtainCrmIdentity"/>.
    /// </summary>
    public class ObtainCrmIdentityResponse : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.ObtainCrmIdentityResponse"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.ObtainCrmIdentityResponse;

        /// <summary>
        /// ID of currently assigned CRM identity, if any.
        /// </summary>
        public long? AssignedCrmIdentityId { get; set; }

        /// <summary>
        /// List of matched CRM identities from the Contact Directory.
        /// </summary>
        public GetSessionCrmIdentityResponseMatch[] MatchedCrmIdentities { get; set; }

        /// <summary>
        /// Describes a CRM identity match
        /// </summary>
        public class GetSessionCrmIdentityResponseMatch
        {
            /// <summary>
            /// CRM identity ID.
            /// </summary>
            public long CrmIdentityId { get; set; }

            /// <summary>
            /// Match score (0-100).
            /// </summary>
            public double Score { get; set; }

            /// <summary>
            /// Match data (e.g. e-mails, phones, etc. that matched).
            /// </summary>
            public IReadOnlyDictionary<string, HashSet<string>> Data { get; set; }
        }
    }
}
