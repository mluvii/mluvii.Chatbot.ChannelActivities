using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    public class GetMediaObjectsResponse : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.GetMediaObjectsResponse;

        public IList<FileStoreItemInfo> FileStoreItems { get; set; }

        public class FileStoreItemInfo
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }
    }
}
