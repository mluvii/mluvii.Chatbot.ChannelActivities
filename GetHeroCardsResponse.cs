using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the response to <see cref="GetHeroCards"/>.
    /// <para>
    /// Returns HeroCards that can be used in the current session only.
    /// </para>
    /// </summary>
    public class GetHeroCardsResponse : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.GetHeroCardsResponse"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.GetHeroCardsResponse;

        /// <summary>
        /// List of available hero cards.
        /// </summary>
        public IList<HeroCardInfo> HeroCards { get; set; }

        /// <summary>
        /// Information about an available hero card.
        /// </summary>
        public class HeroCardInfo
        {
            /// <summary>
            /// Hero card's display name.
            /// </summary>
            public string DisplayName { get; set; }

            /// <summary>
            /// Hero card's ID.
            /// </summary>
            public int HeroCardId { get; set; }

            /// <summary>
            /// List of supported languages.
            /// </summary>
            public IList<string> Languages { get; set;  }
        }
    }
}
