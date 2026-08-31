namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Sends a file to the chat session.
    /// <para>
    /// Files can be shared in two ways:
    /// <list type="number">
    /// <item>Using the <see cref="Name"/> of a file stored in mluvii (obtained via <see cref="GetMediaObjects"/>).</item>
    /// <item>Using the <see cref="Url"/> of an externally hosted file.</item>
    /// </list>
    /// </para>
    /// </summary>
    public class ShareFile : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.ShareFile"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.ShareFile;

        /// <summary>
        /// The external URL of the file to share.
        /// </summary>
        public string? Url { get; set; }

        /// <summary>
        /// The name of the file stored in mluvii (obtained via <see cref="GetMediaObjects"/>).
        /// </summary>
        public string? Name { get; set; }
    }
}
