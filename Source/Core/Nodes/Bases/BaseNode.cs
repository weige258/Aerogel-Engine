namespace AerogelEngine.Core.Nodes.Bases;

interface IBaseNode
{
    public abstract List<BasePort> GetPorts();
}

public class BaseNode : IBaseNode
{
    public List<BasePort> GetPorts()
    {
        return new List<BasePort>();
    }
}