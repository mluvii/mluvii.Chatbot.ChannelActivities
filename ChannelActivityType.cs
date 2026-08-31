namespace mluvii.Chatbot.ChannelActivities
{
    /// <summary>
    /// Represents the type of the activity.
    /// </summary>
    public enum ChannelActivityType
    {
        /// <summary>
        /// Undefined default enumeration value.
        /// Not actually used in any channel activity.
        /// </summary>
        Undefined = 0,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.Forward"/>.
        /// </summary>
        Forward,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.HandOff"/>.
        /// </summary>
        HandOff,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.GetAvailableOperators"/>.
        /// </summary>
        GetAvailableOperators,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.GetAvailableOperatorsResponse"/>.
        /// </summary>
        GetAvailableOperatorsResponse,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.SetCallParams"/>.
        /// </summary>
        SetCallParams,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.SetCallParamsResponse"/>.
        /// </summary>
        SetCallParamsResponse,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.SendGuestOfflineEmail"/>.
        /// </summary>
        SendGuestOfflineEmail,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.GetCallParams"/>.
        /// </summary>
        GetCallParams,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.GetCallParamsResponse"/>.
        /// </summary>
        GetCallParamsResponse,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.ChatbotOpenFileUploadPrompt"/>.
        /// </summary>
        ChatbotOpenFileUploadPrompt,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.ChatbotOpenFileUploadPromptResponse"/>.
        /// </summary>
        ChatbotOpenFileUploadPromptResponse,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.GetGuestIdentity"/>.
        /// </summary>
        GetGuestIdentity,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.GetGuestIdentityResponse"/>.
        /// </summary>
        GetGuestIdentityResponse,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.EnableGuestUpload"/>.
        /// </summary>
        EnableGuestUpload,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.EnableGuestUploadResponse"/>.
        /// </summary>
        EnableGuestUploadResponse,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.DisableGuestUpload"/>.
        /// </summary>
        DisableGuestUpload,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.DisableGuestUploadResponse"/>.
        /// </summary>
        DisableGuestUploadResponse,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.GuestFileUpload"/>.
        /// </summary>
        GuestFileUpload,
        /// <summary>
        /// Chatbot API only.
        /// <br />
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.Ping"/>.
        /// </summary>
        Ping,
        /// <summary>
        /// Chatbot API only.
        /// <br />
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.ChatbotText"/>.
        /// </summary>
        Text,
        /// <summary>
        /// Chatbot API only.
        /// <br />
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.RichCardList"/>.
        /// </summary>
        RichCardList,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.GetAvailableGroups"/>.
        /// </summary>
        GetAvailableGroups,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.GetAvailableGroupsResponse"/>.
        /// </summary>
        GetAvailableGroupsResponse,
        /// <summary>
        /// Chatbot API only.
        /// <br />
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.ChatbotConversationStarted"/>.
        /// </summary>
        ConversationStarted,
        /// <summary>
        /// Chatbot API only.
        /// <br />
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.ChatbotConversationEnded"/>.
        /// </summary>
        ConversationEnded,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.GetHeroCards"/>.
        /// </summary>
        GetHeroCards,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.GetHeroCardsResponse"/>.
        /// </summary>
        GetHeroCardsResponse,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.SendHeroCard"/>.
        /// </summary>
        SendHeroCard,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.SendHeroCardResponse"/>.
        /// </summary>
        SendHeroCardResponse,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.Typing"/>.
        /// </summary>
        Typing,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.EnableGuestInput"/>.
        /// </summary>
        EnableGuestInput,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.DisableGuestInput"/>.
        /// </summary>
        DisableGuestInput,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.GuestInputChangeResponse"/>.
        /// </summary>
        GuestInputChangeResponse,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.EndConversation"/>.
        /// </summary>
        EndConversation,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.GetMediaObjects"/>.
        /// </summary>
        GetMediaObjects,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.GetMediaObjectsResponse"/>.
        /// </summary>
        GetMediaObjectsResponse,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.ShareFile"/>.
        /// </summary>
        ShareFile,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.ShareFileResponse"/>.
        /// </summary>
        ShareFileResponse,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.HeroCardSubmission"/>.
        /// </summary>
        HeroCardSubmission,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.HeroCardQuickReply"/>.
        /// </summary>
        HeroCardQuickReply,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.AssignCrmIdentity"/>.
        /// </summary>
        AssignCrmIdentity,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.AssignCrmIdentityResponse"/>.
        /// </summary>
        AssignCrmIdentityResponse,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.ObtainCrmIdentity"/>.
        /// </summary>
        ObtainCrmIdentity,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.ObtainCrmIdentityResponse"/>.
        /// </summary>
        ObtainCrmIdentityResponse,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.SetTag"/>.
        /// </summary>
        SetTag,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.UnsetTag"/>.
        /// </summary>
        UnsetTag,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.RequestLocation"/>.
        /// </summary>
        RequestLocation,
        /// <summary>
        /// Implemented by <see cref="mluvii.Chatbot.ChannelActivities.GuestLocation"/>.
        /// </summary>
        GuestLocation
    }
}
