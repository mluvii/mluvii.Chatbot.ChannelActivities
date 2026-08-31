using System;

namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the response to <see cref="GetGuestIdentity"/>.
    /// </summary>
    public class GetGuestIdentityResponse : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.GetGuestIdentityResponse"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.GetGuestIdentityResponse;

        /// <summary>
        /// The unique identifier from the guest's cookie.
        /// </summary>
        public Guid? TrackedGuestGuid { get; set; }

        /// <summary>
        /// The Facebook PSID identifier.
        /// </summary>
        public string FacebookPSID { get; set; }

        /// <summary>
        /// The Facebook page identifier.
        /// </summary>
        public string FacebookPageId { get; set; }

        /// <summary>
        /// The guest's phone number.
        /// </summary>
        public string PhoneCallerId { get; set; }

        /// <summary>
        /// The WhatsApp contact identifier.
        /// </summary>
        public string WhatsAppContactId { get; set; }

        /// <summary>
        /// The VK contact identifier.
        /// </summary>
        public string VkContactId { get; set; }

        /// <summary>
        /// The Apple contact identifier.
        /// </summary>
        public string AppleContactId { get; set; }

        /// <summary>
        /// The generic channel identifier.
        /// </summary>
        public string GenericChannelId { get; set; }
    }
}
