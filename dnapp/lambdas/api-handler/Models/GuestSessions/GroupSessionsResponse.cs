using System.Collections.Generic;

public class GroupSessionsResponseDto
{
    public List<ParticipantDto> Participants { get; set; } = new();
    public decimal Total { get; set; }
}
