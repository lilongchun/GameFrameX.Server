
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
public abstract partial class Task : ai.FlowNode
{
    public Task(JsonElement _buf)  : base(_buf) 
    {
        IgnoreRestartSelf = _buf.GetProperty("ignore_restart_self").GetBoolean();
    }

    public static Task DeserializeTask(JsonElement _buf)
    {
        switch (_buf.GetProperty("$type").GetString())
        {
            case "UeWait": return new ai.UeWait(_buf);
            case "UeWaitBlackboardTime": return new ai.UeWaitBlackboardTime(_buf);
            case "MoveToTarget": return new ai.MoveToTarget(_buf);
            case "ChooseSkill": return new ai.ChooseSkill(_buf);
            case "MoveToRandomLocation": return new ai.MoveToRandomLocation(_buf);
            case "MoveToLocation": return new ai.MoveToLocation(_buf);
            case "DebugPrint": return new ai.DebugPrint(_buf);
            default: throw new SerializationException();
        }
    }

    public readonly bool IgnoreRestartSelf;
   

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "nodeName:" + NodeName + ","
        + "decorators:" + StringUtil.CollectionToString(Decorators) + ","
        + "services:" + StringUtil.CollectionToString(Services) + ","
        + "ignoreRestartSelf:" + IgnoreRestartSelf + ","
        + "}";
    }
}

}
