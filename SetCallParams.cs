using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    public class SetCallParams : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.SetCallParams;

        public IDictionary<string, string> CallParams { get; set; }
    }
}
