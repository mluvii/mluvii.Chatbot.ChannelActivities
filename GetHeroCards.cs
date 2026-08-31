namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Retrieves available hero cards.
    /// </summary>
    public class GetHeroCards : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.GetHeroCards"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.GetHeroCards;
    }
}
