using System.Collections.Generic;

namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the response to <see cref="GetAvailableGroups"/>.
    /// </summary>
    public class GetAvailableGroupsResponse : ChatbotChannelActivityBase
    {
        /// <summary>
        /// The type of the activity. Returns <see cref="ChannelActivityType.GetAvailableGroupsResponse"/>.
        /// </summary>
        public override ChannelActivityType Activity => ChannelActivityType.GetAvailableGroupsResponse;

        /// <summary>
        /// List of available groups and their current status.
        /// </summary>
        public IList<AvailableGroupInfo> AvailableGroups { get; set; }

        /// <summary>
        /// Information about an available group
        /// </summary>
        public class AvailableGroupInfo
        {
            /// <summary>
            /// Group's display name.
            /// </summary>
            public string DisplayName { get; set; }

            /// <summary>
            /// Group's ID.
            /// </summary>
            public int GroupId { get; set; }

            /// <summary>
            /// Current group state.
            /// </summary>
            public AvailableGroupState GroupState { get; set; }

            /// <summary>
            /// Reasons why the group is offline, if applicable.
            /// </summary>
            public AvailableGroupOfflineReason[] GroupOfflineReasons { get; set; }

            /// <summary>
            /// Information about the current group workload.
            /// </summary>
            public AvailableGroupWorkload GroupWorkload { get; set; }

            /// <summary>
            /// Information about the current queue workload.
            /// </summary>
            public AvailableGroupQueueWorkload QueueWorkload { get; set; }
        }

        /// <summary>
        /// Identifies a state of a group.
        /// </summary>
        public enum AvailableGroupState
        {
            /// <summary>
            /// A group does not have any available operators or its queue is full.
            /// The <see cref="AvailableGroupOfflineReason"/> enumeration identifies the reason why the group is offline.
            /// </summary>
            OFFLINE = 0,

            /// <summary>
            /// A group has some available operators.
            /// </summary>
            ONLINE = 1,

            /// <summary>
            /// Some operators are logged in, but all are busy and the group queue is not full.
            /// </summary>
            BUSY = 2
        }

        /// <summary>
        /// Identifies the reason for a group being in the <see cref="AvailableGroupState.OFFLINE"/> state.
        /// </summary>
        public enum AvailableGroupOfflineReason
        {
            /// <summary>
            /// Default enumeration value that is never actually used.
            /// </summary>
            NONE = 0,

            /// <summary>
            /// The group is outside configured business hours.
            /// </summary>
            BUSINESS_HOURS = 1,

            /// <summary>
            /// There are no logged-in operators in the group.
            /// </summary>
            NO_OPERATORS = 2,

            /// <summary>
            /// The group has reached the maximum configured queue size.
            /// </summary>
            QUEUE_FULL = 4,

            /// <summary>
            /// The group was deleted by an administrator.
            /// </summary>
            DELETED = 8,

            /// <summary>
            /// All operators are in the away state, and the away state is treated as offline. This is a tenant-specific configuration.
            /// </summary>
            AWAY_IS_OFFLINE = 16,

            /// <summary>
            /// All operators have blocked the given channel.
            /// </summary>
            CHANNEL_BLOCKED = 32
        }

        /// <summary>
        /// Describes the current workload of a group.
        /// </summary>
        public class AvailableGroupWorkload
        {
            /// <summary>
            /// Sum of all slots of logged operators in group.
            /// </summary>
            public int MaxSlots { get; set; }

            /// <summary>
            /// Sum of all waiting slots of logged operators in group.
            /// </summary>
            public int UsedSlotsWaiting { get; set; }

            /// <summary>
            /// Sum of all accepted slots of logged operators in group.
            /// </summary>
            public int UsedSlotsAccepted { get; set; }

            /// <summary>
            /// Sum of free slots of logged operators in group.
            /// </summary>
            public int FreeSlots { get; set; }
        }

        /// <summary>
        /// Describes the current workload of a group queue.
        /// </summary>
        public class AvailableGroupQueueWorkload
        {
            /// <summary>
            /// Free queue slots of the group.
            /// </summary>
            public int FreeQueueSlotsCountTotal { get; set; }

            /// <summary>
            /// Used queue slots of the group.
            /// </summary>
            public int InQueueCountTotal { get; set; }

            /// <summary>
            /// True if <see cref="FreeQueueSlotsCountTotal"/> is 0.
            /// </summary>
            public bool IsQueueFull { get; set; }
        }
    }
}
