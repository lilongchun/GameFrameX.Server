
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
public partial class TbMultiUnionIndexList
{
    private readonly System.Collections.Generic.List<test.MultiUnionIndexList> _dataList;

    private System.Collections.Generic.Dictionary<(int, long, string), test.MultiUnionIndexList> _dataMapUnion;

    public TbMultiUnionIndexList(JsonElement _buf)
    {
        _dataList = new System.Collections.Generic.List<test.MultiUnionIndexList>();
        
        foreach(JsonElement _ele in _buf.EnumerateArray())
        {
            test.MultiUnionIndexList _v;
            _v = test.MultiUnionIndexList.DeserializeMultiUnionIndexList(_ele);
            _dataList.Add(_v);
        }
        _dataMapUnion = new System.Collections.Generic.Dictionary<(int, long, string), test.MultiUnionIndexList>();
        foreach(var _v in _dataList)
        {
            _dataMapUnion.Add((_v.Id1, _v.Id2, _v.Id3), _v);
        }
    }

    public System.Collections.Generic.List<test.MultiUnionIndexList> DataList => _dataList;

    public test.MultiUnionIndexList Get(int id1, long id2, string id3) => _dataMapUnion.TryGetValue((id1, id2, id3), out test.MultiUnionIndexList __v) ? __v : null;
    
    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }
}

}
