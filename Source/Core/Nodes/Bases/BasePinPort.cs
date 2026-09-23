namespace AerogelEngine.Core.Nodes.Bases;

public class BasePinPort : BasePort
{
    public override BasePortDirection direction => BasePortDirection.Pin;

    public BasePinPort(BaseNode owner) : base(owner) { }

    protected override bool CanConnectTo(BasePort other)
    {
        if (other.direction != BasePortDirection.Pin) return false;
        if (owner == other.owner) return false;
        return true;
    }
}