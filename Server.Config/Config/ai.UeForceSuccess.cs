
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.Json;
using Server.Config.Core;


namespace cfg.ai
{
public sealed partial class UeForceSuccess : ai.Decorator
{
    public UeForceSuccess(JsonElement _buf)  : base(_buf) 
    {
    }

    public static UeForceSuccess DeserializeUeForceSuccess(JsonElement _buf)
    {
        return new ai.UeForceSuccess(_buf);
    }

   
    public const int __ID__ = 195054574;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "nodeName:" + NodeName + ","
        + "flowAbortMode:" + FlowAbortMode + ","
        + "}";
    }
}

}
