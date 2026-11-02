using System.Collections.Generic;

public class ParticipantDto
{
    public string Id { get; set; }
    public string Type { get; set; } // "Guest" або "Owner"
    public string Name { get; set; }
    public List<ItemDto> Items { get; set; } = new();
    public decimal Total { get; set; }
    public bool IsSubmitted { get; set; }
}