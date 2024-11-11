public record Request
{
    public bool Stream { get; init; }
    public List<Message> Messages { get; init; } = [];
}
