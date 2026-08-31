namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Enables the guest's text input field.
    /// </summary>
    public class EnableGuestInput : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.EnableGuestInput"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.EnableGuestInput;
    }
}
