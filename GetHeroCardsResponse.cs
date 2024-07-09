using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    public class GetHeroCardsResponse : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.GetHeroCardsResponse;

        public IList<HeroCardInfo> HeroCards { get; set; }

        public class HeroCardInfo
        {
            public string DisplayName { get; set; }

            public int HeroCardId { get; set; }

            public IList<string> Languages { get; set;  }
        }
    }
}
