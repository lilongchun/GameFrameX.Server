
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.Json;
using Server.Config.Core;


namespace cfg.test2
{
/// <summary>
/// 矩形
/// </summary>
public sealed partial class Rectangle : test.Shape
{
    public Rectangle(JsonElement _buf)  : base(_buf) 
    {
        Width = _buf.GetProperty("width").GetSingle();
        Height = _buf.GetProperty("height").GetSingle();
    }

    public static Rectangle DeserializeRectangle(JsonElement _buf)
    {
        return new test2.Rectangle(_buf);
    }

    /// <summary>
    /// 宽度
    /// </summary>
    public readonly float Width;
    /// <summary>
    /// 高度
    /// </summary>
    public readonly float Height;
   
    public const int __ID__ = 694982337;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "width:" + Width + ","
        + "height:" + Height + ","
        + "}";
    }
}

}
