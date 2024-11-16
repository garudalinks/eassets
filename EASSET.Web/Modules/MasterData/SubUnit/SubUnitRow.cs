using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace EASSET.MasterData;

[ConnectionKey("Default"), Module("MasterData"), TableName("tbmSubUnit")]
[DisplayName("Sub Unit"), InstanceName("Sub Unit"), GenerateFields]
[ReadPermission("Sub Unit:View")]
//[ModifyPermission("Kecamatan:Modify")]
[InsertPermission("Sub Unit:Insert")]
[UpdatePermission("Sub Unit:Update")]
[DeletePermission("Sub Unit:Delete")]
[ServiceLookupPermission("Sub Unit:General")]


[DataAuditLog]
[LookupScript]
public sealed partial class SubUnitRow : Row<SubUnitRow.RowFields>, IIdRow, INameRow
{

    const string jOPD = nameof(jOPD);

    [DisplayName("Sub Unit Id"), Column("SubUnitID"), Size(20), PrimaryKey, IdProperty]
    public string SubUnitId { get => fields.SubUnitId[this]; set => fields.SubUnitId[this] = value; }

    [DisplayName("Unit Nama"), Column("UnitID"), Size(20), ForeignKey("tbmUnit", "UnitID"), LeftJoin(jOPD), TextualField(nameof(UnitNama))]
    [ServiceLookupEditor(typeof(OPDRow), Service = "MasterData/OPD/List")]
    public string UnitId { get => fields.UnitId[this]; set => fields.UnitId[this] = value; }

    [DisplayName("Sub Unit Kode"), Size(15)]
    public string SubUnitKode { get => fields.SubUnitKode[this]; set => fields.SubUnitKode[this] = value; }

    [DisplayName("Sub Unit Nama"), Size(100), NameProperty]
    public string SubUnitNama { get => fields.SubUnitNama[this]; set => fields.SubUnitNama[this] = value; }

    [DisplayName("Th Ang"), Size(4)]
    public string ThAng { get => fields.ThAng[this]; set => fields.ThAng[this] = value; }

    [DisplayName("Op"), Column("OP"), Size(30)]
    public string Op { get => fields.Op[this]; set => fields.Op[this] = value; }

    [DisplayName("Lu"), Column("LU")]
    public DateTime? Lu { get => fields.Lu[this]; set => fields.Lu[this] = value; }

    [DisplayName("Pc"), Column("PC"), Size(100)]
    public string Pc { get => fields.Pc[this]; set => fields.Pc[this] = value; }

    [DisplayName("Dlt"), Column("DLT")]
    public bool? Dlt { get => fields.Dlt[this]; set => fields.Dlt[this] = value; }

    [DisplayName("Alamat"), Column("alamat"), Size(200)]
    public string Alamat { get => fields.Alamat[this]; set => fields.Alamat[this] = value; }

    [DisplayName("Npwp"), Column("NPWP"), Size(30)]
    public string Npwp { get => fields.Npwp[this]; set => fields.Npwp[this] = value; }

    //FK
    [DisplayName("SKPD/Unit Kerja"), Expression($"{jOPD}.[UnitNama]")]
    public string UnitNama { get => fields.UnitNama[this]; set => fields.UnitNama[this] = value; }
}