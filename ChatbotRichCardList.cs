using System;
using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Supports ms bot framework rich cards: https://learn.microsoft.com/en-us/azure/bot-service/rest-api/bot-framework-rest-connector-add-rich-cards?view=azure-bot-service-4.0
    /// </summary>
    public class ChatbotRichCardList : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.RichCardList;

        public DateTimeOffset Timestamp { get; set; }

        public IList<Item> Items { get; set; }

        public ItemLayout Layout { get; set; }

        public class Item
        {
            public string ContentType { get; set; }

            public IDictionary<string, object> Content { get; set; }
        }

        public enum ItemLayout
        {
            List = 0,
            Carousel = 1
        }
    }
}
