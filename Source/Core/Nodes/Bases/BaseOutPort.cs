namespace AerogelEngine.Core.Nodes.Bases;

public class BaseOutPort : BasePort
{
    public override BasePortDirection direction => BasePortDirection.Output;

    public BaseOutPort(BaseNode owner) : base(owner) { }

    protected override bool CanConnectTo(BasePort other)
    {
        if (other.direction == BasePortDirection.Output) return false;
        if (owner == other.owner) return false;
        return true;
    }
}