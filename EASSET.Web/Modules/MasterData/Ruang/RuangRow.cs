using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using StackExchange.Exceptional.Internal;
using System;
using System.ComponentModel;

namespace EASSET.MasterData;

[ConnectionKey("Default"), Module("MasterData"), TableName("tbmRuang")]
[DisplayName("Ruang"), InstanceName("Ruang"), GenerateFields]
[ReadPermission("Ruang:View")]
[InsertPermission("Ruang:Insert")]
[UpdatePermission("Ruang:Update")]
[DeletePermission("Ruang:Delete")]
[ServiceLookupPermission("Ruang:General")]
public sealed partial class RuangRow : Row<RuangRow.RowFields>, IIdRow, INameRow
{
    const string jOPD = nameof(jOPD);
    const string jSubUnit = nameof(jSubUnit);

    [DisplayName("Ruang Id"), Column("RuangID"), PrimaryKey, IdProperty, QuickSearch]
    public string RuangId { get => fields.RuangId[this]; set => fields.RuangId[this] = value; }

    [DisplayName("OPD"), Column("UnitID"), Size(20), ForeignKey("tbmUnit", "UnitID"), LeftJoin(jOPD), NotNull, TextualField(nameof(UnitNama))]
    [ServiceLookupEditor(typeof(OPDRow), Service ="MasterData/OPD/List")]
    public string UnitId { get => fields.UnitId[this]; set => fields.UnitId[this] = value; }

    [DisplayName("Sub Unit"), Column("SubUnitID"), Size(20), ForeignKey("tbmSubUnit", "SubUnitID"), LeftJoin(jSubUnit), TextualField(nameof(SubUnitNama))]
    [ServiceLookupEditor(typeof(SubUnitRow), Service = "MasterData/SubUnit/List")]
    public string SubUnitId { get => fields.SubUnitId[this]; set => fields.SubUnitId[this] = value; }

    [DisplayName("Ruang Kode"), Size(40)]
    public string RuangKode { get => fields.RuangKode[this]; set => fields.RuangKode[this] = value; }

    [DisplayName("Ruang Nama"), NameProperty, NotNull, QuickSearch]
    public string RuangNama { get => fields.RuangNama[this]; set => fields.RuangNama[this] = value; }

    [DisplayName("Th Ang"), Size(4), NotNull]
    public string ThAng { get => fields.ThAng[this]; set => fields.ThAng[this] = value; }

    [DisplayName("Op"), Column("OP"), Size(30)]
    public string Op { get => fields.Op[this]; set => fields.Op[this] = value; }

    [DisplayName("Lu"), Column("LU")]
    public DateTime? Lu { get => fields.Lu[this]; set => fields.Lu[this] = value; }

    [DisplayName("Pc"), Column("PC"), Size(30)]
    public string Pc { get => fields.Pc[this]; set => fields.Pc[this] = value; }

    [DisplayName("Dlt"), Column("DLT")]
    public short? Dlt { get => fields.Dlt[this]; set => fields.Dlt[this] = value; }

    //FK
    [DisplayName("OPD Nama"), Expression($"{jOPD}.[UnitNama]")]
    public string UnitNama { get => fields.UnitNama[this]; set => fields.UnitNama[this] = value; }

    [DisplayName("Sub Unit Nama"), Expression($"{jSubUnit}.[SubUnitNama]")]
    public string SubUnitNama { get => fields.SubUnitNama[this]; set => fields.SubUnitNama[this] = value; }
}