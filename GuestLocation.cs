namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the guest's geographical location response to a <see cref="RequestLocation"/>.
    /// </summary>
    public class GuestLocation : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.GuestLocation"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.GuestLocation;

        /// <summary>
        /// Guest's latitude.
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Guest's longitude.
        /// </summary>
        public double Longitude { get; set; }
    }
}
