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
// Root Type: gym.mizu.SeriVenueTableArray

[FlatBufferTable, TypeConverter(typeof(ExpandableObjectConverter))]
public class SeriVenueTableArray : IFlatBufferArchive<SeriVenueTable>
{
    [FlatBufferItem(0)] public SeriVenueTable[] Table { get; set; }
}

[FlatBufferTable, TypeConverter(typeof(ExpandableObjectConverter))]
public class SeriVenueTable
{
    [FlatBufferItem(00)] public int SeriVenueTableId { get; set; }
    [FlatBufferItem(01)] public bool IsEventOnly { get; set; }
    [FlatBufferItem(02)] public bool IsLegend { get; set; }
    [FlatBufferItem(03)] public VenueType VenueType { get; set; }
    [FlatBufferItem(04)] public string McName { get; set; }
    [FlatBufferItem(05)] public string BarkerMessageLabelName { get; set; }
    [FlatBufferItem(06)] public string BarkersMessageLabelName { get; set; }
    [FlatBufferItem(07)] public string EntryMessageLabelName { get; set; }
    [FlatBufferItem(08)] public string EntrysMessageLabelName { get; set; }
    [FlatBufferItem(09)] public string FirstBidMessageLabelName { get; set; }
    [FlatBufferItem(10)] public string NextBidMessageLabelName { get; set; }
    [FlatBufferItem(11)] public string PlayerBidMessageLabelName { get; set; }
    [FlatBufferItem(12)] public string PlayerSuccessBidMessageLabelName { get; set; }
    [FlatBufferItem(13)] public string OtherSuccessBidMessageLabelName { get; set; }
    [FlatBufferItem(14)] public string ReceiveItemMessageLabelName { get; set; }
    [FlatBufferItem(15)] public string InvalidMessageLabelName { get; set; }
    [FlatBufferItem(16)] public string EndMessageLabelName { get; set; }
    [FlatBufferItem(17)] public string UnopenedMessageLabelName { get; set; }
    [FlatBufferItem(18)] public string ProgressFlagName { get; set; }
    [FlatBufferItem(19)] public string ItemIdFlagName { get; set; }
    [FlatBufferItem(20)] public string ItemNumFlagName { get; set; }
    [FlatBufferItem(21)] public string NpcId0FlagName { get; set; }
    [FlatBufferItem(22)] public string NpcId1FlagName { get; set; }
    [FlatBufferItem(23)] public string ItemPositionObjectName { get; set; }
    [FlatBufferItem(24)] public float WindowOffset { get; set; }
}

[FlatBufferEnum(typeof(int))]
public enum VenueType
{
    A = 0,
    B = 1,
    C = 2,
    D = 3,
}
