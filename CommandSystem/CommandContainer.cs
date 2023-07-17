namespace CommandSystem
{
    public abstract class CommandContainer
    {
        protected ICommand? _step;

        public CommandContainer Contain(ICommand step)
        {
            _step = step;
            return this;
        }
    }
}
