using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    public class SendHeroCard : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.SendHeroCard;

        public int HeroCardId { get; set; }

        public IReadOnlyDictionary<string, string> InitialParams { get; set; }

        public string SelectedLanguage { get; set; }

        public Dictionary<string, string[]> AdditionalParams { get; set; }
    }
}
