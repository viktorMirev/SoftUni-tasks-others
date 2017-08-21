using System.Collections.Generic;

public abstract class AbstractCommand : ICommand
{
    public IList<string> Args { get;private set; }
    public IManager Manager { get;private set; }

    public AbstractCommand(IList<string> args, IManager manager)
    {
        this.Args = args;
        this.Manager = manager;
    }
    public abstract string Execute();
}