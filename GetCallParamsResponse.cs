using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    public class GetCallParamsResponse : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.GetCallParamsResponse;

        public IDictionary<string, string> CallParams { get; set; }
    }
}
