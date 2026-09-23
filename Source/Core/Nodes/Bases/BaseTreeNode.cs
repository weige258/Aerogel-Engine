using AerogelEngine.Core.Nodes.Bases;

public class BaseTreeNode: BaseNode 
{
    public BaseInPort? father_port=null;
    public BaseOutPort child_ports;

    public BaseTreeNode()
    {
        child_ports = new BaseOutPort(this);
    }
}