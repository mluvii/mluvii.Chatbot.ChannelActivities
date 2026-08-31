using System;
using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents a quick reply to a hero card, typically used in channels like WhatsApp.
    /// </summary>
    public class HeroCardQuickReply : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.HeroCardQuickReply"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.HeroCardQuickReply;

        /// <summary>
        /// The quick reply text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The ID of the activity this is a reply to.
        /// </summary>
        public long ReplyToActivityId { get; set; }

        /// <summary>
        /// Use <see cref="AdditionalParams"/> instead.
        /// </summary>
        [Obsolete("Use AdditionalParams instead")]
        public IDictionary<string, string> FieldValues { get; set; }

        /// <summary>
        /// Additional parameters for the quick reply.
        /// <seealso cref="SendHeroCard.AdditionalParams"/>
        /// </summary>
        public Dictionary<string, string[]> AdditionalParams { get; set; }
    }
}
