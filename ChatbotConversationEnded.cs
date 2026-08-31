using System;

namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// [EXPERIMENTAL, OPT-IN]
    /// Notifies that a chatbot conversation has ended.
    /// </summary>
    public class ChatbotConversationEnded : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.ConversationEnded"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.ConversationEnded;

        /// <summary>
        /// The timestamp when the conversation ended.
        /// </summary>
        public DateTimeOffset Timestamp { get; set; }
    }
}
