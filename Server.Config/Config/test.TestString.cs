
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
public sealed partial class TestString : Server.Config.Core.BeanBase
{
    public TestString(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetString();
        S1 = _buf.GetProperty("s1").GetString();
        S2 = _buf.GetProperty("s2").GetString();
        Cs1 = test.CompactString.DeserializeCompactString(_buf.GetProperty("cs1"));
        Cs2 = test.CompactString.DeserializeCompactString(_buf.GetProperty("cs2"));
    }

    public static TestString DeserializeTestString(JsonElement _buf)
    {
        return new test.TestString(_buf);
    }

    public readonly string Id;
    public readonly string S1;
    public readonly string S2;
    public readonly test.CompactString Cs1;
    public readonly test.CompactString Cs2;
   
    public const int __ID__ = 338485823;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        
        Cs1?.ResolveRef(tables);
        Cs2?.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "s1:" + S1 + ","
        + "s2:" + S2 + ","
        + "cs1:" + Cs1 + ","
        + "cs2:" + Cs2 + ","
        + "}";
    }
}

}
