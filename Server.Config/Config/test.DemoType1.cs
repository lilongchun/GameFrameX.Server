
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.Json;
using Server.Config.Core;


namespace cfg.test
{
public sealed partial class DemoType1 : Server.Config.Core.BeanBase
{
    public DemoType1(JsonElement _buf) 
    {
        X1 = _buf.GetProperty("x1").GetInt32();
    }

    public static DemoType1 DeserializeDemoType1(JsonElement _buf)
    {
        return new test.DemoType1(_buf);
    }

    public readonly int X1;
   
    public const int __ID__ = -367048296;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
    }

    public override string ToString()
    {
        return "{ "
        + "x1:" + X1 + ","
        + "}";
    }
}

}
