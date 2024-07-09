using System;

namespace mluvii.Chatbot.ChannelActivities
{
    public class GetGuestIdentityResponse : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.GetGuestIdentityResponse;

        public Guid? TrackedGuestGuid { get; set; }

        public string FacebookPSID { get; set; }

        public string FacebookPageId { get; set; }

        public string PhoneCallerId { get; set; }

        public string WhatsAppContactId { get; set; }

        public string VkContactId { get; set; }

        public string GenericChannelId { get; set; }
    }
}
