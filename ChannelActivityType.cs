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
        /// Implemented by <see cref="Forward"/>.
        /// </summary>
        Forward,
        /// <summary>
        /// Implemented by <see cref="HandOff"/>.
        /// </summary>
        HandOff,
        /// <summary>
        /// Implemented by <see cref="GetAvailableOperators"/>.
        /// </summary>
        GetAvailableOperators,
        /// <summary>
        /// Implemented by <see cref="GetAvailableOperatorsResponse"/>.
        /// </summary>
        GetAvailableOperatorsResponse,
        /// <summary>
        /// Implemented by <see cref="SetCallParams"/>.
        /// </summary>
        SetCallParams,
        /// <summary>
        /// Implemented by <see cref="SetCallParamsResponse"/>.
        /// </summary>
        SetCallParamsResponse,
        /// <summary>
        /// Implemented by <see cref="SendGuestOfflineEmail"/>.
        /// </summary>
        SendGuestOfflineEmail,
        /// <summary>
        /// Implemented by <see cref="GetCallParams"/>.
        /// </summary>
        GetCallParams,
        /// <summary>
        /// Implemented by <see cref="GetCallParamsResponse"/>.
        /// </summary>
        GetCallParamsResponse,
        /// <summary>
        /// Implemented by <see cref="ChatbotOpenFileUploadPrompt"/>.
        /// </summary>
        ChatbotOpenFileUploadPrompt,
        /// <summary>
        /// Implemented by <see cref="ChatbotOpenFileUploadPromptResponse"/>.
        /// </summary>
        ChatbotOpenFileUploadPromptResponse,
        /// <summary>
        /// Implemented by <see cref="GetGuestIdentity"/>.
        /// </summary>
        GetGuestIdentity,
        /// <summary>
        /// Implemented by <see cref="GetGuestIdentityResponse"/>.
        /// </summary>
        GetGuestIdentityResponse,
        /// <summary>
        /// Implemented by <see cref="EnableGuestUpload"/>.
        /// </summary>
        EnableGuestUpload,
        /// <summary>
        /// Implemented by <see cref="EnableGuestUploadResponse"/>.
        /// </summary>
        EnableGuestUploadResponse,
        /// <summary>
        /// Implemented by <see cref="DisableGuestUpload"/>.
        /// </summary>
        DisableGuestUpload,
        /// <summary>
        /// Implemented by <see cref="DisableGuestUploadResponse"/>.
        /// </summary>
        DisableGuestUploadResponse,
        /// <summary>
        /// Implemented by <see cref="GuestFileUpload"/>.
        /// </summary>
        GuestFileUpload,
        /// <summary>
        /// Chatbot API only.
        /// <br />
        /// Implemented by <see cref="Ping"/>.
        /// </summary>
        Ping,
        /// <summary>
        /// Chatbot API only.
        /// <br />
        /// Implemented by <see cref="ChatbotText"/>.
        /// </summary>
        Text,
        /// <summary>
        /// Chatbot API only.
        /// <br />
        /// Implemented by <see cref="RichCardList"/>.
        /// </summary>
        RichCardList,
        /// <summary>
        /// Implemented by <see cref="GetAvailableGroups"/>.
        /// </summary>
        GetAvailableGroups,
        /// <summary>
        /// Implemented by <see cref="GetAvailableGroupsResponse"/>.
        /// </summary>
        GetAvailableGroupsResponse,
        /// <summary>
        /// Chatbot API only.
        /// <br />
        /// Implemented by <see cref="ChatbotConversationStarted"/>.
        /// </summary>
        ConversationStarted,
        /// <summary>
        /// Chatbot API only.
        /// <br />
        /// Implemented by <see cref="ChatbotConversationEnded"/>.
        /// </summary>
        ConversationEnded,
        /// <summary>
        /// Implemented by <see cref="GetHeroCards"/>.
        /// </summary>
        GetHeroCards,
        /// <summary>
        /// Implemented by <see cref="GetHeroCardsResponse"/>.
        /// </summary>
        GetHeroCardsResponse,
        /// <summary>
        /// Implemented by <see cref="SendHeroCard"/>.
        /// </summary>
        SendHeroCard,
        /// <summary>
        /// Implemented by <see cref="SendHeroCardResponse"/>.
        /// </summary>
        SendHeroCardResponse,
        /// <summary>
        /// Implemented by <see cref="Typing"/>.
        /// </summary>
        Typing,
        /// <summary>
        /// Implemented by <see cref="EnableGuestInput"/>.
        /// </summary>
        EnableGuestInput,
        /// <summary>
        /// Implemented by <see cref="DisableGuestInput"/>.
        /// </summary>
        DisableGuestInput,
        /// <summary>
        /// Implemented by <see cref="GuestInputChangeResponse"/>.
        /// </summary>
        GuestInputChangeResponse,
        /// <summary>
        /// Implemented by <see cref="EndConversation"/>.
        /// </summary>
        EndConversation,
        /// <summary>
        /// Implemented by <see cref="GetMediaObjects"/>.
        /// </summary>
        GetMediaObjects,
        /// <summary>
        /// Implemented by <see cref="GetMediaObjectsResponse"/>.
        /// </summary>
        GetMediaObjectsResponse,
        /// <summary>
        /// Implemented by <see cref="ShareFile"/>.
        /// </summary>
        ShareFile,
        /// <summary>
        /// Implemented by <see cref="ShareFileResponse"/>.
        /// </summary>
        ShareFileResponse,
        /// <summary>
        /// Implemented by <see cref="HeroCardSubmission"/>.
        /// </summary>
        HeroCardSubmission,
        /// <summary>
        /// Implemented by <see cref="HeroCardQuickReply"/>.
        /// </summary>
        HeroCardQuickReply,
        /// <summary>
        /// Implemented by <see cref="AssignCrmIdentity"/>.
        /// </summary>
        AssignCrmIdentity,
        /// <summary>
        /// Implemented by <see cref="AssignCrmIdentityResponse"/>.
        /// </summary>
        AssignCrmIdentityResponse,
        /// <summary>
        /// Implemented by <see cref="ObtainCrmIdentity"/>.
        /// </summary>
        ObtainCrmIdentity,
        /// <summary>
        /// Implemented by <see cref="ObtainCrmIdentityResponse"/>.
        /// </summary>
        ObtainCrmIdentityResponse,
        /// <summary>
        /// Implemented by <see cref="SetTag"/>.
        /// </summary>
        SetTag,
        /// <summary>
        /// Implemented by <see cref="UnsetTag"/>.
        /// </summary>
        UnsetTag,
        /// <summary>
        /// Implemented by <see cref="RequestLocation"/>.
        /// </summary>
        RequestLocation,
        /// <summary>
        /// Implemented by <see cref="GuestLocation"/>.
        /// </summary>
        GuestLocation
    }
}
