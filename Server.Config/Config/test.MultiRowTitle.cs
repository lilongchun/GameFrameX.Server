
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
public sealed partial class MultiRowTitle : Server.Config.Core.BeanBase
{
    public MultiRowTitle(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetInt32();
        Name = _buf.GetProperty("name").GetString();
        X1 = test.H1.DeserializeH1(_buf.GetProperty("x1"));
        {if (_buf.TryGetProperty("x2_0", out var _j) && _j.ValueKind != JsonValueKind.Null) { X20 = test.H2.DeserializeH2(_j); } else { X20 = null; } }
        { var __json0 = _buf.GetProperty("x2"); X2 = new System.Collections.Generic.List<test.H2>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { test.H2 __v0;  __v0 = test.H2.DeserializeH2(__e0);  X2.Add(__v0); }   }
        { var __json0 = _buf.GetProperty("x3"); int _n0 = __json0.GetArrayLength(); X3 = new test.H2[_n0]; int __index0=0; foreach(JsonElement __e0 in __json0.EnumerateArray()) { test.H2 __v0;  __v0 = test.H2.DeserializeH2(__e0);  X3[__index0++] = __v0; }   }
        { var __json0 = _buf.GetProperty("x4"); int _n0 = __json0.GetArrayLength(); X4 = new test.H2[_n0]; int __index0=0; foreach(JsonElement __e0 in __json0.EnumerateArray()) { test.H2 __v0;  __v0 = test.H2.DeserializeH2(__e0);  X4[__index0++] = __v0; }   }
    }

    public static MultiRowTitle DeserializeMultiRowTitle(JsonElement _buf)
    {
        return new test.MultiRowTitle(_buf);
    }

    public readonly int Id;
    public readonly string Name;
    public readonly test.H1 X1;
    public readonly test.H2 X20;
    public readonly System.Collections.Generic.List<test.H2> X2;
    public readonly test.H2[] X3;
    public readonly test.H2[] X4;
   
    public const int __ID__ = 540002427;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        X1?.ResolveRef(tables);
        X20?.ResolveRef(tables);
        foreach (var _e in X2) { _e?.ResolveRef(tables); }
        foreach (var _e in X3) { _e?.ResolveRef(tables); }
        foreach (var _e in X4) { _e?.ResolveRef(tables); }
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "name:" + Name + ","
        + "x1:" + X1 + ","
        + "x20:" + X20 + ","
        + "x2:" + StringUtil.CollectionToString(X2) + ","
        + "x3:" + StringUtil.CollectionToString(X3) + ","
        + "x4:" + StringUtil.CollectionToString(X4) + ","
        + "}";
    }
}

}
