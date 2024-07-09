namespace mluvii.Chatbot.ChannelActivities
{
    public class AssignCrmIdentityResponse : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.AssignCrmIdentityResponse;

        public bool Created { get; set; }

        public long CrmIdentityId  { get; set; }

        public string Reason { get; set; }
    }
}
