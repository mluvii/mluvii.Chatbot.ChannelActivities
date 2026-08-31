using System;

namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Notifies that a chatbot conversation has started.
    /// </summary>
    public class ChatbotConversationStarted : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.ConversationStarted"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.ConversationStarted;

        /// <summary>
        /// The timestamp when the conversation started.
        /// </summary>
        public DateTimeOffset Timestamp { get; set; }
    }
}
