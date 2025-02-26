
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
public partial class TbDemoGroup
{
    private readonly System.Collections.Generic.Dictionary<int, test.DemoGroup> _dataMap;
    private readonly System.Collections.Generic.List<test.DemoGroup> _dataList;
    
    public TbDemoGroup(JsonElement _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, test.DemoGroup>();
        _dataList = new System.Collections.Generic.List<test.DemoGroup>();
        
        foreach(JsonElement _ele in _buf.EnumerateArray())
        {
            test.DemoGroup _v;
            _v = test.DemoGroup.DeserializeDemoGroup(_ele);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, test.DemoGroup> DataMap => _dataMap;
    public System.Collections.Generic.List<test.DemoGroup> DataList => _dataList;

    public test.DemoGroup GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.DemoGroup Get(int key) => _dataMap[key];
    public test.DemoGroup this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}
