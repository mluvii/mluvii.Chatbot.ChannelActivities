namespace mluvii.Chatbot.ChannelActivities
{
    public enum ChannelActivityType
    {
        Undefined,
        Forward, //forward to specific operator (or auto-select)
        HandOff, //return to routing (rules re-evaluated)
        GetAvailableOperators,
        GetAvailableOperatorsResponse,
        SetCallParams,
        SetCallParamsResponse,
        SendGuestOfflineEmail,
        GetCallParams,
        GetCallParamsResponse,
        ChatbotOpenFileUploadPrompt,
        ChatbotOpenFileUploadPromptResponse,
        GetGuestIdentity,
        GetGuestIdentityResponse,
        EnableGuestUpload,
        EnableGuestUploadResponse,
        DisableGuestUpload,
        DisableGuestUploadResponse,
        GuestFileUpload,
        Ping, //Generic chatbot
        Text, //Generic chatbot
        RichCardList, //Generic chatbot
        GetAvailableGroups,
        GetAvailableGroupsResponse,
        ConversationStarted, //Generic chatbot
        ConversationEnded, //Generic chatbot
        GetHeroCards,
        GetHeroCardsResponse,
        SendHeroCard,
        SendHeroCardResponse,
        Typing,
        EnableGuestInput,
        DisableGuestInput,
        GuestInputChangeResponse,
        EndConversation,
        GetMediaObjects,
        GetMediaObjectsResponse,
        ShareFile,
        ShareFileResponse,
        HeroCardSubmission,
        HeroCardQuickReply,
        AssignCrmIdentity,
        AssignCrmIdentityResponse,
        ObtainCrmIdentity,
        ObtainCrmIdentityResponse,
        SetTag,
        UnsetTag,
        RequestLocation,
        GuestLocation
    }
}
