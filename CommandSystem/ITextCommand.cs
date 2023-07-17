namespace CommandSystem
{
    public interface ITextCommand : ICommand
    {
        public ICommand? Execute(string? text);
    }
}
