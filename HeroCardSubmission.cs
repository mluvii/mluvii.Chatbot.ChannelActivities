using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Notifies the chatbot that a guest has submitted a hero card response or selected an option (e.g., in WhatsApp).
    /// </summary>
    public class HeroCardSubmission : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.HeroCardSubmission"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.HeroCardSubmission;

        /// <summary>
        /// Submitted parameters from the hero card.
        /// </summary>
        public Dictionary<string,string> Params { get; set; }
    }
}
