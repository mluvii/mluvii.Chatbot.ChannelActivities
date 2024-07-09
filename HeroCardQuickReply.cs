using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    public class HeroCardQuickReply : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.HeroCardQuickReply;

        public string Text { get; set; }

        public long ReplyToActivityId { get; set; }

        public IDictionary<string, string> FieldValues { get; set; }
    }
}
