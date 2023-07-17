namespace CommandSystem
{
    public interface IMessageCommand : ICommand
    {
        public string? Message { get; }
    }
}
