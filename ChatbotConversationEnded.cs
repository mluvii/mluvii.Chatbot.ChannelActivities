using System;

namespace mluvii.Chatbot.ChannelActivities
{
    public class ChatbotConversationEnded : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.ConversationEnded;

        public DateTimeOffset Timestamp { get; set; }
    }
}
