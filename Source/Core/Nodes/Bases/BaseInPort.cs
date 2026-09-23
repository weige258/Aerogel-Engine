namespace AerogelEngine.Core.Nodes.Bases;

public class BaseInPort : BasePort
{
    public override BasePortDirection direction => BasePortDirection.Input;

    public BaseInPort(BaseNode owner) : base(owner) { }

    protected override bool CanConnectTo(BasePort other)
    {
        if (other.direction == BasePortDirection.Input) return false;
        if (owner == other.owner) return false;
        if (connections.Count > 0) return false;
        return true;
    }
}