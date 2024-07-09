using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    public class GetAvailableGroups : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.GetAvailableGroups;

        public ICollection<int> GroupIds { get; set; }
    }
}
