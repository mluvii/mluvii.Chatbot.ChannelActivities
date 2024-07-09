using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    public class HeroCardSubmission : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.HeroCardSubmission;

        public Dictionary<string,string> Params { get; set; }
    }
}
