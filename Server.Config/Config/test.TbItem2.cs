
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
public partial class TbItem2
{
    private readonly System.Collections.Generic.Dictionary<int, test.ItemBase> _dataMap;
    private readonly System.Collections.Generic.List<test.ItemBase> _dataList;
    
    public TbItem2(JsonElement _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, test.ItemBase>();
        _dataList = new System.Collections.Generic.List<test.ItemBase>();
        
        foreach(JsonElement _ele in _buf.EnumerateArray())
        {
            test.ItemBase _v;
            _v = test.ItemBase.DeserializeItemBase(_ele);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, test.ItemBase> DataMap => _dataMap;
    public System.Collections.Generic.List<test.ItemBase> DataList => _dataList;

    public T GetOrDefaultAs<T>(int key) where T : test.ItemBase => _dataMap.TryGetValue(key, out var v) ? (T)v : null;
    public T GetAs<T>(int key) where T : test.ItemBase => (T)_dataMap[key];
    public test.ItemBase GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.ItemBase Get(int key) => _dataMap[key];
    public test.ItemBase this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}
