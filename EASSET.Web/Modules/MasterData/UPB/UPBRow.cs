using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace EASSET.MasterData;

[ConnectionKey("Default"), Module("MasterData"), TableName("tbmUPB")]
[DisplayName("Upb"), InstanceName("Upb"), GenerateFields]
[ReadPermission("Upb:View")]
//[ModifyPermission("Kecamatan:Modify")]
[InsertPermission("Upb:Insert")]
[UpdatePermission("Upb:Update")]
[DeletePermission("Upb:Delete")]
[ServiceLookupPermission("Upb:General")]

[DataAuditLog]
[LookupScript]
public sealed partial class UPBRow : Row<UPBRow.RowFields>, IIdRow, INameRow
{
    const string jOPD = nameof(jOPD);
    const string jSubUnit = nameof(jSubUnit);

    [DisplayName("Upbid"), Column("UPBID"), Size(20), PrimaryKey, IdProperty, QuickSearch]
    public string Upbid { get => fields.Upbid[this]; set => fields.Upbid[this] = value; }

    [DisplayName("SKPD"), Column("UnitID"), Size(20), NotNull, ForeignKey("tbmUnit", "UnitID"), LeftJoin(jOPD), TextualField(nameof(UnitNama))]
    [ServiceLookupEditor(typeof(OPDRow), Service = "MasterData/OPD/List")]
    public string UnitId { get => fields.UnitId[this]; set => fields.UnitId[this] = value; }

    [DisplayName("Unit Kerja"), Column("SubUnitID"), ForeignKey("tbmSubUnit", "SubUnitID"), LeftJoin(jSubUnit), TextualField(nameof(SubUnitNama))]
    [ServiceLookupEditor(typeof(SubUnitRow), Service="MasterData/SubUnit/List")]
    public string SubUnitId { get => fields.SubUnitId[this]; set => fields.SubUnitId[this] = value; }

    [DisplayName("Kode UPB"), Column("UPBKode"), Size(10), QuickSearch(SearchType.Contains), Width(100)]
    public string UpbKode { get => fields.UpbKode[this]; set => fields.UpbKode[this] = value; }

    [DisplayName("Nama UPB"), Column("UPBNama"), Size(100), NotNull, QuickSearch(SearchType.Contains), Width(350), NameProperty]
    public string UpbNama { get => fields.UpbNama[this]; set => fields.UpbNama[this] = value; }

    [DisplayName("Tahun"), Size(4)]
    public string ThAng { get => fields.ThAng[this]; set => fields.ThAng[this] = value; }

    [DisplayName("Op"), Column("OP"), Size(50)]
    public string Op { get => fields.Op[this]; set => fields.Op[this] = value; }

    [DisplayName("Lu"), Column("LU")]
    public DateTime? Lu { get => fields.Lu[this]; set => fields.Lu[this] = value; }

    [DisplayName("Pc"), Column("PC"), Size(50)]
    public string Pc { get => fields.Pc[this]; set => fields.Pc[this] = value; }

    [DisplayName("Dlt"), Column("DLT")]
    public short? Dlt { get => fields.Dlt[this]; set => fields.Dlt[this] = value; }


    //FK
    [DisplayName("SKPD/Unit Kerja"), Expression($"{jOPD}.[UnitNama]")]
    public string UnitNama { get => fields.UnitNama[this]; set => fields.UnitNama[this] = value; }

    [DisplayName("Sub Unit"), Expression($"{jSubUnit}.[SubUnitNama]")]
    public string SubUnitNama { get => fields.SubUnitNama[this]; set => fields.SubUnitNama[this] = value; }
}