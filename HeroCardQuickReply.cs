using System;
using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    public class HeroCardQuickReply : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.HeroCardQuickReply;

        public string Text { get; set; }

        public long ReplyToActivityId { get; set; }

        [Obsolete("Use AdditionalParams instead")]
        public IDictionary<string, string> FieldValues { get; set; }

        /// <summary>
        /// <seealso cref="SendHeroCard.AdditionalParams"/>
        /// </summary>
        public Dictionary<string, string[]> AdditionalParams { get; set; }
    }
}
