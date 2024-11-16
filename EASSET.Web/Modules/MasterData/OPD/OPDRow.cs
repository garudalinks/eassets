using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace EASSET.MasterData;

[ConnectionKey("Default"), Module("MasterData"), TableName("tbmUnit")]
[DisplayName("Opd"), InstanceName("Opd"), GenerateFields]
[ReadPermission("Opd:View")]
[InsertPermission("Opd:Insert")]
[UpdatePermission("Opd:Update")]
[DeletePermission("Opd:Delete")]
[ServiceLookupPermission("Opd:General")]

[DataAuditLog]
[LookupScript]
public sealed partial class OPDRow : Row<OPDRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Unit Id"), Column("UnitID"), Size(20), PrimaryKey, IdProperty]
    public string UnitId { get => fields.UnitId[this]; set => fields.UnitId[this] = value; }

    [DisplayName("Unit Kode"), Size(10)]
    public string UnitKode { get => fields.UnitKode[this]; set => fields.UnitKode[this] = value; }

    [DisplayName("Unit Nama"), Size(100), NameProperty, QuickSearch]
    public string UnitNama { get => fields.UnitNama[this]; set => fields.UnitNama[this] = value; }

    [DisplayName("Th Ang"), Size(4)]
    public string ThAng { get => fields.ThAng[this]; set => fields.ThAng[this] = value; }

    [DisplayName("Alamat"), Size(254)]
    public string Alamat { get => fields.Alamat[this]; set => fields.Alamat[this] = value; }

    [DisplayName("Op"), Column("OP")]
    public string Op { get => fields.Op[this]; set => fields.Op[this] = value; }

    [DisplayName("Lu"), Column("LU")]
    public DateTime? Lu { get => fields.Lu[this]; set => fields.Lu[this] = value; }

    [DisplayName("Pc"), Column("PC")]
    public string Pc { get => fields.Pc[this]; set => fields.Pc[this] = value; }

    [DisplayName("Dlt"), Column("DLT")]
    public bool? Dlt { get => fields.Dlt[this]; set => fields.Dlt[this] = value; }

    [DisplayName("Npwp"), Column("NPWP")]
    public string Npwp { get => fields.Npwp[this]; set => fields.Npwp[this] = value; }

    [DisplayName("Is Blud"), Column("isBLUD")]
    public short? IsBlud { get => fields.IsBlud[this]; set => fields.IsBlud[this] = value; }

    [DisplayName("No Urut")]
    public int? NoUrut { get => fields.NoUrut[this]; set => fields.NoUrut[this] = value; }
}