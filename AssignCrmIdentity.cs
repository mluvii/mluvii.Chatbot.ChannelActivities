namespace mluvii.Chatbot.ChannelActivities
{
    public class AssignCrmIdentity : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.AssignCrmIdentity;

        public long? ExistingCrmIdentityId { get; set; }
    }
}
