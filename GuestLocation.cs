namespace mluvii.Chatbot.ChannelActivities
{
    public class GuestLocation : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.GuestLocation;

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
