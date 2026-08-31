using System;
using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents a list of rich cards.
    /// Supports Microsoft Bot Framework rich cards: https://learn.microsoft.com/en-us/azure/bot-service/rest-api/bot-framework-rest-connector-add-rich-cards?view=azure-bot-service-4.0
    /// </summary>
    public class RichCardList : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.RichCardList"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.RichCardList;

        /// <summary>
        /// The activity timestamp.
        /// </summary>
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// The list of rich card items.
        /// </summary>
        public IList<Item> Items { get; set; }

        /// <summary>
        /// The layout of the items (List or Carousel).
        /// </summary>
        public ItemLayout Layout { get; set; }

        /// <summary>
        /// An item of the rich car
        /// </summary>
        public class Item
        {
            /// <summary>
            /// The content type of the card.
            /// </summary>
            public string ContentType { get; set; }

            /// <summary>
            /// The content of the card.
            /// </summary>
            public IDictionary<string, object> Content { get; set; }
        }

        /// <summary>
        /// Identifies the layout of the rich card items.
        /// Mapped to the attachmentLayout property of the Microsoft Bot Framework hero card.
        /// </summary>
        public enum ItemLayout
        {
            /// <summary>
            /// Display rich cards in the list format.
            /// </summary>
            List = 0,
            /// <summary>
            /// Display rich cards in the carousel format.
            /// </summary>
            Carousel = 1
        }
    }
}
