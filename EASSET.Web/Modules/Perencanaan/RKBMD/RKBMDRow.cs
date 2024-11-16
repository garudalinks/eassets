using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace EASSET.Perencanaan;

[ConnectionKey("Default"), Module("Perencanaan"), TableName("tbl_RKBMD")]
[DisplayName("Rkbmd"), InstanceName("Rkbmd"), GenerateFields]
[ReadPermission("Rkbmd:View")]
[InsertPermission("Rkbmd:Insert")]
[UpdatePermission("Rkbmd:Update")]
[DeletePermission("Rkbmd:Delete")]
[ServiceLookupPermission("Rkbmd:General")]
public sealed partial class RKBMDRow : Row<RKBMDRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Rkbmdid"), Column("RKBMDID"), Size(20), IdProperty]
    public string Rkbmdid { get => fields.Rkbmdid[this]; set => fields.Rkbmdid[this] = value; }

    [DisplayName("Unit Id"), Column("UnitID"), Size(50)]
    public string UnitId { get => fields.UnitId[this]; set => fields.UnitId[this] = value; }

    [DisplayName("No")]
    public double? NoUrut { get => fields.NoUrut[this]; set => fields.NoUrut[this] = value; }

    [DisplayName("Keterangan"), Size(255)]
    public string Keterangan { get => fields.Keterangan[this]; set => fields.Keterangan[this] = value; }

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

    [DisplayName("Sub Unit Id"), Column("SubUnitID"), Size(50)]
    public string SubUnitId { get => fields.SubUnitId[this]; set => fields.SubUnitId[this] = value; }

    [DisplayName("Sub Keg Id"), Column("SubKegID"), Size(50)]
    public string SubKegId { get => fields.SubKegId[this]; set => fields.SubKegId[this] = value; }

    [DisplayName("Kode Rekening"), Size(100), QuickSearch, NameProperty]
    public string KodeRekening { get => fields.KodeRekening[this]; set => fields.KodeRekening[this] = value; }

    [DisplayName("Uraian Rekening"), Size(255)]
    public string NamaRekening { get => fields.NamaRekening[this]; set => fields.NamaRekening[this] = value; }

    [DisplayName("Jumlah yang diusulkan"), Column("Jml_Usulan")]
    public double? JmlUsulan { get => fields.JmlUsulan[this]; set => fields.JmlUsulan[this] = value; }

    [DisplayName("Jumlah kebutuhan maksimal"), Column("Jml_Keb_Max")]
    public double? JmlKebMax { get => fields.JmlKebMax[this]; set => fields.JmlKebMax[this] = value; }

    [DisplayName("Jumlah yang tersedia"), Column("Jml_Existing")]
    public double? JmlExisting { get => fields.JmlExisting[this]; set => fields.JmlExisting[this] = value; }

    [DisplayName("Sub Keg Kode"), Size(50)]
    public string SubKegKode { get => fields.SubKegKode[this]; set => fields.SubKegKode[this] = value; }

    [DisplayName("Sub Kegiatan"), Size(255)]
    public string SubKegNama { get => fields.SubKegNama[this]; set => fields.SubKegNama[this] = value; }

    [DisplayName("Sub Sub Ro108 Id"), Column("SubSubRO108ID"), Size(50)]
    public string SubSubRo108Id { get => fields.SubSubRo108Id[this]; set => fields.SubSubRo108Id[this] = value; }

    [DisplayName("Satuan"), Size(255)]
    public string Satuan { get => fields.Satuan[this]; set => fields.Satuan[this] = value; }

    [DisplayName("Rkpdid"), Column("RKPDID"), Size(50)]
    public string Rkpdid { get => fields.Rkpdid[this]; set => fields.Rkpdid[this] = value; }
}