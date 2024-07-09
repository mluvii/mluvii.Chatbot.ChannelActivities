using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    public class GetAvailableGroupsResponse : ChatbotChannelActivityBase
    {
        public override ChannelActivityType Activity => ChannelActivityType.GetAvailableGroupsResponse;

        public IList<AvailableGroupInfo> AvailableGroups { get; set; }

        public class AvailableGroupInfo
        {
            public string DisplayName { get; set; }

            public int GroupId { get; set; }

            public AvailableGroupState GroupState { get; set; }

            public AvailableGroupOfflineReason[] GroupOfflineReasons { get; set; }

            public AvailableGroupWorkload GroupWorkload { get; set; }

            public AvailableGroupQueueWorkload QueueWorkload { get; set; }
        }

        public enum AvailableGroupState
        {
            OFFLINE = 0,
            ONLINE = 1,
            BUSY = 2
        }

        public enum AvailableGroupOfflineReason
        {
            NONE = 0,
            BUSINESS_HOURS = 1,
            NO_OPERATORS = 2,
            QUEUE_FULL = 4,
            DELETED = 8,
            AWAY_IS_OFFLINE = 16,
            CHANNEL_BLOCKED = 32
        }

        public class AvailableGroupWorkload
        {
            public int MaxSlots { get; set; }

            public int UsedSlotsWaiting { get; set; }

            public int UsedSlotsAccepted { get; set; }

            public int FreeSlots { get; set; }
        }

        public class AvailableGroupQueueWorkload
        {
            public int FreeQueueSlotsCountTotal { get; set; }

            public int InQueueCountTotal { get; set; }

            public bool IsQueueFull { get; set; }
        }
    }
}
