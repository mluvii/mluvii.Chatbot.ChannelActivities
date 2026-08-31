using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the response to <see cref="GetMediaObjects"/>.
    /// </summary>
    public class GetMediaObjectsResponse : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.GetMediaObjectsResponse"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.GetMediaObjectsResponse;

        /// <summary>
        /// List of files stored in mluvii and available for the session.
        /// </summary>
        public IList<FileStoreItemInfo> FileStoreItems { get; set; }

        /// <summary>
        /// Information about a file
        /// </summary>
        public class FileStoreItemInfo
        {
            /// <summary>
            /// File ID.
            /// </summary>
            public int Id { get; set; }

            /// <summary>
            /// File name.
            /// </summary>
            public string Name { get; set; }
        }
    }
}
