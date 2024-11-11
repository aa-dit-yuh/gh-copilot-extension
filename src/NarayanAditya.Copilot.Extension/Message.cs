public record Message
{
    public required string Role { get; init; }
    public required string Content { get; init; }
}
