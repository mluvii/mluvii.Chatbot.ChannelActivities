using System;

namespace mluvii.Chatbot.ChannelActivities
{
    public class ChatbotConversationStarted : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.ConversationStarted;

        public DateTimeOffset Timestamp { get; set; }
    }
}
