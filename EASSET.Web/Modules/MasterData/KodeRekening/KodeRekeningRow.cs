using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace EASSET.MasterData;

[ConnectionKey("Default"), Module("MasterData"), TableName("vwStrukRekening108")]
[DisplayName("Kode Rekening"), InstanceName("Kode Rekening"), GenerateFields]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed partial class KodeRekeningRow : Row<KodeRekeningRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), IdProperty]
    public long? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Akun108 Id"), Column("Akun108ID"), Size(20), NotNull, NameProperty]
    public string Akun108Id { get => fields.Akun108Id[this]; set => fields.Akun108Id[this] = value; }

    [DisplayName("Akun View"), Size(261), QuickSearch]
    public string AkunView { get => fields.AkunView[this]; set => fields.AkunView[this] = value; }

    [DisplayName("Kelompok108 Id"), Column("Kelompok108ID"), Size(20), NotNull]
    public string Kelompok108Id { get => fields.Kelompok108Id[this]; set => fields.Kelompok108Id[this] = value; }

    [DisplayName("Kelompok View"), Size(271), QuickSearch]
    public string KelompokView { get => fields.KelompokView[this]; set => fields.KelompokView[this] = value; }

    [DisplayName("Jenis108 Id"), Column("Jenis108ID"), Size(20), NotNull]
    public string Jenis108Id { get => fields.Jenis108Id[this]; set => fields.Jenis108Id[this] = value; }

    [DisplayName("Jenis View"), Size(281), QuickSearch]
    public string JenisView { get => fields.JenisView[this]; set => fields.JenisView[this] = value; }

    [DisplayName("Objek108 Id"), Column("Objek108ID"), Size(20), NotNull]
    public string Objek108Id { get => fields.Objek108Id[this]; set => fields.Objek108Id[this] = value; }

    [DisplayName("Objek View"), Size(291), QuickSearch]
    public string ObjekView { get => fields.ObjekView[this]; set => fields.ObjekView[this] = value; }

    [DisplayName("Ro108 Id"), Column("RO108ID"), Size(20), NotNull]
    public string Ro108Id { get => fields.Ro108Id[this]; set => fields.Ro108Id[this] = value; }

    [DisplayName("Ro View"), Column("ROView"), Size(301), QuickSearch]
    public string RoView { get => fields.RoView[this]; set => fields.RoView[this] = value; }

    [DisplayName("Sub Ro108 Id"), Column("SubRO108ID"), Size(20), NotNull]
    public string SubRo108Id { get => fields.SubRo108Id[this]; set => fields.SubRo108Id[this] = value; }

    [DisplayName("Sub Ro View"), Column("SubROView"), Size(311),QuickSearch]
    public string SubRoView { get => fields.SubRoView[this]; set => fields.SubRoView[this] = value; }

    [DisplayName("Sub Sub Ro108 Id"), Column("SubSubRO108ID"), Size(20), NotNull]
    public string SubSubRo108Id { get => fields.SubSubRo108Id[this]; set => fields.SubSubRo108Id[this] = value; }

    [DisplayName("Sub Sub Ro View"), Column("SubSubROView"), Size(321), QuickSearch]
    public string SubSubRoView { get => fields.SubSubRoView[this]; set => fields.SubSubRoView[this] = value; }

    [DisplayName("Kode Rekening108"), Size(70), QuickSearch]
    public string KodeRekening108 { get => fields.KodeRekening108[this]; set => fields.KodeRekening108[this] = value; }

    [DisplayName("Th Ang"), Size(4)]
    public string ThAng { get => fields.ThAng[this]; set => fields.ThAng[this] = value; }

    [DisplayName("Is Enabled"), Column("isEnabled"), NotNull]
    public short? IsEnabled { get => fields.IsEnabled[this]; set => fields.IsEnabled[this] = value; }
}