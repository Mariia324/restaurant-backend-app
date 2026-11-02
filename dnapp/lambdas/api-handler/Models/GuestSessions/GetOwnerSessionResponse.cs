namespace APIHandler.Models.GuestSessions;

public class GetOwnerSessionResponse
{
    public string GuestSessionId { get; set; }

    public GetOwnerSessionResponse(string guestSessionId)
    {
        GuestSessionId = guestSessionId;
    }
}