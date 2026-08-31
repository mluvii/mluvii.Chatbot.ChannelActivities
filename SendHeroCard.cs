using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Sends the specified hero card to the guest chat.
    /// Predefined values can be set using <see cref="InitialParams"/>.
    /// </summary>
    public class SendHeroCard : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.SendHeroCard"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.SendHeroCard;

        /// <summary>
        /// Hero card's ID.
        /// </summary>
        public int HeroCardId { get; set; }

        /// <summary>
        /// Optional predefined values in a HeroCard.
        /// </summary>
        public IReadOnlyDictionary<string, string>? InitialParams { get; set; }

        /// <summary>
        /// Optional selected language in format "cs", "en", "de" etc.
        /// </summary>
        public string? SelectedLanguage { get; set; }

        /// <summary>
        /// Optional additional parameters (e.g. for WhatsApp).
        /// </summary>
        public Dictionary<string, string[]>? AdditionalParams { get; set; }
    }
}
