using System;

namespace mluvii.Chatbot.ChannelActivities
{
    public class ChatbotText : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.Text;

        public DateTimeOffset Timestamp { get; set; }

        public string Text { get; set; }
    }
}
