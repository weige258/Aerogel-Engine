namespace AerogelEngine.Core.Nodes.Bases;

public enum BasePortDirection
{
    Input,
    Output,
    Pin
}

public abstract class BasePort
{
    public BaseNode owner;
    public List<BasePort> connections;
    public abstract BasePortDirection direction { get; }

    public BasePort(BaseNode owner)
    {
        this.owner = owner;
        this.connections = new List<BasePort>();
    }

    protected abstract bool CanConnectTo(BasePort other);

    public bool ConnectTo(BasePort other)
    {
        if (!CanConnectTo(other)) return false;
        connections.Add(other);
        other.connections.Add(this);
        return true;
    }

    public void DisconnectFrom(BasePort other)
    {
        connections.Remove(other);
        other.connections.Remove(this);
    }

    public void DisconnectAll()
    {
        foreach (var other in connections.ToList())
            other.connections.Remove(this);
        connections.Clear();
    }
}