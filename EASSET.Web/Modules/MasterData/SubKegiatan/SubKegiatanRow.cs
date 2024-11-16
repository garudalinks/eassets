using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace EASSET.MasterData;

[ConnectionKey("Default"), Module("MasterData"), TableName("vwSubKegiatan")]
[DisplayName("Sub Kegiatan"), InstanceName("Sub Kegiatan"), GenerateFields]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed partial class SubKegiatanRow : Row<SubKegiatanRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), IdProperty]
    public long? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Bidang View"), Size(261), QuickSearch]
    public string BidangView { get => fields.BidangView[this]; set => fields.BidangView[this] = value; }

    [DisplayName("Urusan View"), Size(121), QuickSearch]
    public string UrusanView { get => fields.UrusanView[this]; set => fields.UrusanView[this] = value; }

    [DisplayName("Prog View"), Size(286), QuickSearch]
    public string ProgView { get => fields.ProgView[this]; set => fields.ProgView[this] = value; }

    [DisplayName("Keg View"), Size(1046), QuickSearch]
    public string KegView { get => fields.KegView[this]; set => fields.KegView[this] = value; }

    [DisplayName("Sub Keg View"), Size(2566), QuickSearch, NameProperty]
    public string SubKegView { get => fields.SubKegView[this]; set => fields.SubKegView[this] = value; }

    [DisplayName("Sub Keg50 Id"), Column("subKeg50ID"), Size(20), NotNull]
    public string SubKeg50Id { get => fields.SubKeg50Id[this]; set => fields.SubKeg50Id[this] = value; }

    [DisplayName("Sub Keg50 Kode"), Size(20)]
    public string SubKeg50Kode { get => fields.SubKeg50Kode[this]; set => fields.SubKeg50Kode[this] = value; }
}