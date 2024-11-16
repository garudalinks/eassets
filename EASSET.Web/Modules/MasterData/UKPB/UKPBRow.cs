using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace EASSET.MasterData;

[ConnectionKey("Default"), Module("MasterData"), TableName("tbmUKPB50")]
[DisplayName("Ukpb"), InstanceName("Ukpb"), GenerateFields]
[ReadPermission("Ukpb:View")]
[InsertPermission("Ukpb:Insert")]
[UpdatePermission("Ukpb:Update")]
[DeletePermission("Ukpb:Delete")]
[ServiceLookupPermission("Ukpb:General")]
public sealed partial class UKPBRow : Row<UKPBRow.RowFields>, IIdRow, INameRow
{
    const string jUPB = nameof(jUPB);
    const string jOPD = nameof(jOPD);
    const string jSubUnit = nameof(jSubUnit);

    [DisplayName("Ukpbid"), Column("UKPBID"), Size(20), PrimaryKey, IdProperty]
    public string Ukpbid { get => fields.Ukpbid[this]; set => fields.Ukpbid[this] = value; }

    [DisplayName("UPB"), Column("UPBID"), Size(20), NotNull, ForeignKey("tbmUpb", "UPBID"),LeftJoin(jUPB), TextualField(nameof(UpbNama))]
    [ServiceLookupEditor(typeof(UPBRow), Service = "MasterData/UPB/List")]
    public string Upbid { get => fields.Upbid[this]; set => fields.Upbid[this] = value; }
    [DisplayName("SKPD"), Column("UnitID"), Size(20), NotNull, ForeignKey("tbmUnit", "UnitID"), LeftJoin(jOPD), TextualField(nameof(UnitNama))]
    [ServiceLookupEditor(typeof(OPDRow), Service = "MasterData/OPD/List")]
    public string UnitId { get => fields.UnitId[this]; set => fields.UnitId[this] = value; }
    [DisplayName("Unit Kerja"), Column("SubUnitID"), Size(20), ForeignKey("tbmSubUnit", "SubUnitID"), LeftJoin(jSubUnit), TextualField(nameof(SubUnitNama))]
    [ServiceLookupEditor(typeof(SubUnitRow), Service = "MasterData/SubUnit/List")]
    public string SubUnitId { get => fields.SubUnitId[this]; set => fields.SubUnitId[this] = value; }

    [DisplayName("Kode UKPB"), Column("UKPBKode"), Size(10)]
    public string UkpbKode { get => fields.UkpbKode[this]; set => fields.UkpbKode[this] = value; }

    [DisplayName("Nama UKPB"), Column("UKPBNama"), Size(100), NotNull, NameProperty, QuickSearch]
    public string UkpbNama { get => fields.UkpbNama[this]; set => fields.UkpbNama[this] = value; }

    [DisplayName("Alamat"), Column("UKPBAlamat"), Size(254)]
    public string UkpbAlamat { get => fields.UkpbAlamat[this]; set => fields.UkpbAlamat[this] = value; }

    [DisplayName("Th Ang"), Size(4)]
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
    [DisplayName("UPB"), Expression($"{jUPB}.[UpbNama]")]
    public string UpbNama { get => fields.UpbNama[this]; set => fields.UpbNama[this] = value; }
    [DisplayName("SKPD"), Expression($"{jOPD}.[UnitNama]")]
    public string UnitNama { get => fields.UnitNama[this]; set => fields.UnitNama[this] = value; }
    [DisplayName("Unit Kerja"), Expression($"{jSubUnit}.[SubUnitNama]")]
    public string SubUnitNama { get => fields.SubUnitNama[this]; set => fields.SubUnitNama[this] = value; }
}