
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
public partial class TbTestBeRef
{
    private readonly System.Collections.Generic.Dictionary<int, test.TestBeRef> _dataMap;
    private readonly System.Collections.Generic.List<test.TestBeRef> _dataList;
    
    public TbTestBeRef(JsonElement _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, test.TestBeRef>();
        _dataList = new System.Collections.Generic.List<test.TestBeRef>();
        
        foreach(JsonElement _ele in _buf.EnumerateArray())
        {
            test.TestBeRef _v;
            _v = test.TestBeRef.DeserializeTestBeRef(_ele);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, test.TestBeRef> DataMap => _dataMap;
    public System.Collections.Generic.List<test.TestBeRef> DataList => _dataList;

    public test.TestBeRef GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.TestBeRef Get(int key) => _dataMap[key];
    public test.TestBeRef this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}
