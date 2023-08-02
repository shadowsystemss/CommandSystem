namespace CommandSystem;

public abstract class CommandManager : CommandContainer
{
    protected abstract void Message(string? text);

    public void Command(string? text)
    {
        if (_step is ITextCommand textCommand)
            _step = textCommand.Execute(text);

        if (_step is IMessageCommand messageCommand)
            Message(messageCommand.Message);

        _step = _step?.Execute();
    }
}
