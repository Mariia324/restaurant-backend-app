using APIHandler.Models.GuestSessions;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace APIHandler.Services.GuestSessions;

public interface IGuestSessionService
{
    Task<CreatGuestSessionResponse> CreateGuestSessionAsync(CreateGuestSessionRequest request);
    Task AddDishAsync(string guestSessionId, string dishId, int quantity);
    Task RemoveDishAsync(string guestSessionId, string dishId, int quantity);
    Task<GroupReservationStatusResponse> GetGroupReservationStatusAsync(string groupReservationId);
    Task<bool> IsAuthorizedAsync(string guestSessionToken, string guestSessionId);
    Task SubmitCartAsync(string guestSessionId);
    Task<GuestMenuResponse> GetGuestMenuAsync(string guestSessionId);
    Task<GetAllSessionsResponse> DeleteGuestSessionAsync(string userId, string groupReservationId, string guestSessionId);
    Task<GetGuestSessionResponse> GetGuestSessionInfoAsync(string guestSessionId);


    Task<GroupSessionsResponseDto> GetGroupSessionsAsync(string groupReservationId, CancellationToken cancellationToken = default);
    Task<GroupSessionsResponseDto> DeleteGuestSessionAsync(string groupReservationId, string guestSessionId, CancellationToken cancellationToken = default);
    Task<GetOwnerSessionResponse> GetOwnerSessionIdAsync(string reservationId, string userId);
}
