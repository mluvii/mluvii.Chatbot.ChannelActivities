using System;

namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents a text message activity from the chatbot.
    /// </summary>
    public class ChatbotText : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.Text"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.Text;

        /// <summary>
        /// The message timestamp.
        /// </summary>
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// The message text.
        /// </summary>
        public string Text { get; set; }
    }
}
