namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Disables the guest's text input field.
    /// </summary>
    public class DisableGuestInput : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.DisableGuestInput"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.DisableGuestInput;
    }
}
