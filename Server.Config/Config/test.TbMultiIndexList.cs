
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
public partial class TbMultiIndexList
{
    private readonly System.Collections.Generic.List<test.MultiIndexList> _dataList;

    private System.Collections.Generic.Dictionary<int, test.MultiIndexList> _dataMap_id1;
    private System.Collections.Generic.Dictionary<long, test.MultiIndexList> _dataMap_id2;
    private System.Collections.Generic.Dictionary<string, test.MultiIndexList> _dataMap_id3;

    public TbMultiIndexList(JsonElement _buf)
    {
        _dataList = new System.Collections.Generic.List<test.MultiIndexList>();
        
        foreach(JsonElement _ele in _buf.EnumerateArray())
        {
            test.MultiIndexList _v;
            _v = test.MultiIndexList.DeserializeMultiIndexList(_ele);
            _dataList.Add(_v);
        }
        _dataMap_id1 = new System.Collections.Generic.Dictionary<int, test.MultiIndexList>();
        _dataMap_id2 = new System.Collections.Generic.Dictionary<long, test.MultiIndexList>();
        _dataMap_id3 = new System.Collections.Generic.Dictionary<string, test.MultiIndexList>();
    foreach(var _v in _dataList)
    {
        _dataMap_id1.Add(_v.Id1, _v);
        _dataMap_id2.Add(_v.Id2, _v);
        _dataMap_id3.Add(_v.Id3, _v);
    }
    }

    public System.Collections.Generic.List<test.MultiIndexList> DataList => _dataList;

    public test.MultiIndexList GetById1(int key) => _dataMap_id1.TryGetValue(key, out test.MultiIndexList __v) ? __v : null;
    public test.MultiIndexList GetById2(long key) => _dataMap_id2.TryGetValue(key, out test.MultiIndexList __v) ? __v : null;
    public test.MultiIndexList GetById3(string key) => _dataMap_id3.TryGetValue(key, out test.MultiIndexList __v) ? __v : null;
    
    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }
}

}
