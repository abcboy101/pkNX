using System.ComponentModel;
using FlatSharp.Attributes;
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global
#nullable disable

namespace pkNX.Structures.FlatBuffers;

// Generated by FlatSharp
// FileIdentifier: 
// FileExtension: 
// Object Count: 2
// Enum Count: 1
// Root Type: gym.mizu.SeriNpcTableArray

[FlatBufferTable, TypeConverter(typeof(ExpandableObjectConverter))]
public class SeriNpcTableArray : IFlatBufferArchive<SeriNpcTable>
{
    [FlatBufferItem(0)] public SeriNpcTable[] Table { get; set; }
}

[FlatBufferTable, TypeConverter(typeof(ExpandableObjectConverter))]
public class SeriNpcTable
{
    [FlatBufferItem(00)] public int SeriNpcTableId { get; set; }
    [FlatBufferItem(01)] public bool IsEventOnly { get; set; }
    [FlatBufferItem(02)] public string NpcName { get; set; }
    [FlatBufferItem(03)] public string TemplateName { get; set; }
    [FlatBufferItem(04)] public ItemID WishItemId { get; set; }
    [FlatBufferItem(05)] public float BaseBudgetRate { get; set; }
    [FlatBufferItem(06)] public float WishBudgetRate { get; set; }
    [FlatBufferItem(07)] public int MinBidPrice { get; set; }
    [FlatBufferItem(08)] public int MaxBidPrice { get; set; }
    [FlatBufferItem(09)] public string BidMessageLabelName { get; set; }
    [FlatBufferItem(10)] public string LargeMessageLabelName { get; set; }
    [FlatBufferItem(11)] public string WishMessageLabelName { get; set; }
    [FlatBufferItem(12)] public string BlessingMessageLabelName { get; set; }
    [FlatBufferItem(13)] public float WindowOffset { get; set; }
}
