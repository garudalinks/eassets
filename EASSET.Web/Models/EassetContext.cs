using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EASSET.Models;

public partial class EassetContext : DbContext
{
    public EassetContext()
    {
    }

    public EassetContext(DbContextOptions<EassetContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BusinessUnit> BusinessUnits { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<FileSystem> FileSystems { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Mail> Mail { get; set; }

    public virtual DbSet<Meeting> Meetings { get; set; }

    public virtual DbSet<MeetingAgenda> MeetingAgendas { get; set; }

    public virtual DbSet<MeetingAgendaType> MeetingAgendaTypes { get; set; }

    public virtual DbSet<MeetingDecision> MeetingDecisions { get; set; }

    public virtual DbSet<MeetingDecisionRelevant> MeetingDecisionRelevants { get; set; }

    public virtual DbSet<MeetingLocation> MeetingLocations { get; set; }

    public virtual DbSet<MeetingType> MeetingTypes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolePermission> RolePermissions { get; set; }

    public virtual DbSet<TaKibA> TaKibAs { get; set; }

    public virtual DbSet<TaKibB> TaKibBs { get; set; }

    public virtual DbSet<TaKibC> TaKibCs { get; set; }

    public virtual DbSet<TaKibD> TaKibDs { get; set; }

    public virtual DbSet<TaKibE> TaKibEs { get; set; }

    public virtual DbSet<TaKibF> TaKibFs { get; set; }

    public virtual DbSet<TblKibA> TblKibAs { get; set; }

    public virtual DbSet<TblKibAPengalihan> TblKibAPengalihans { get; set; }

    public virtual DbSet<TblKibAPerolehan1> TblKibAPerolehan1s { get; set; }

    public virtual DbSet<TblKibAPerolehan2> TblKibAPerolehan2s { get; set; }

    public virtual DbSet<TblKibAPerolehan3> TblKibAPerolehan3s { get; set; }

    public virtual DbSet<TblKibAPihaklain> TblKibAPihaklains { get; set; }

    public virtual DbSet<TblKibASementara> TblKibASementaras { get; set; }

    public virtual DbSet<TblKibAtribusi> TblKibAtribusis { get; set; }

    public virtual DbSet<TblKibB> TblKibBs { get; set; }

    public virtual DbSet<TblKibBPengalihan> TblKibBPengalihans { get; set; }

    public virtual DbSet<TblKibBPerolehan1> TblKibBPerolehan1s { get; set; }

    public virtual DbSet<TblKibBPihaklain> TblKibBPihaklains { get; set; }

    public virtual DbSet<TblKibBSementara> TblKibBSementaras { get; set; }

    public virtual DbSet<TblLoggpsTrack> TblLoggpsTracks { get; set; }

    public virtual DbSet<TblRkbmd> TblRkbmds { get; set; }

    public virtual DbSet<TbmAkun108> TbmAkun108s { get; set; }

    public virtual DbSet<TbmJenis108> TbmJenis108s { get; set; }

    public virtual DbSet<TbmKelompok108> TbmKelompok108s { get; set; }

    public virtual DbSet<TbmObjek108> TbmObjek108s { get; set; }

    public virtual DbSet<TbmRo108> TbmRo108s { get; set; }

    public virtual DbSet<TbmRuang> TbmRuangs { get; set; }

    public virtual DbSet<TbmStrukRekening108> TbmStrukRekening108s { get; set; }

    public virtual DbSet<TbmSubRo108> TbmSubRo108s { get; set; }

    public virtual DbSet<TbmSubSubRo108> TbmSubSubRo108s { get; set; }

    public virtual DbSet<TbmSubUnit> TbmSubUnits { get; set; }

    public virtual DbSet<TbmUkpb> TbmUkpbs { get; set; }

    public virtual DbSet<TbmUkpb50> TbmUkpb50s { get; set; }

    public virtual DbSet<TbmUnit> TbmUnits { get; set; }

    public virtual DbSet<TbmUpb> TbmUpbs { get; set; }

    public virtual DbSet<TbmUpb50> TbmUpb50s { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserPermission> UserPermissions { get; set; }

    public virtual DbSet<UserPreference> UserPreferences { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<VersionInfo> VersionInfos { get; set; }

    public virtual DbSet<VwKodeSubSubRo108> VwKodeSubSubRo108s { get; set; }

    public virtual DbSet<VwStrukRekening108> VwStrukRekening108s { get; set; }

    public virtual DbSet<VwStrukRekening108Ro> VwStrukRekening108Ros { get; set; }

    public virtual DbSet<VwSubKegiatan> VwSubKegiatans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=10.20.30.24;Database=EASSET;User Id=usersikekah;Password=N4tuna@#S!k3kah;Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BusinessUnit>(entity =>
        {
            entity.HasKey(e => e.UnitId);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.ParentUnit).WithMany(p => p.InverseParentUnit)
                .HasForeignKey(d => d.ParentUnitId)
                .HasConstraintName("FK_BusinessUnits_ParentUnit");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.IdentityNo).HasMaxLength(20);
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(30);

            entity.HasOne(d => d.User).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Contacts_UserId");
        });

        modelBuilder.Entity<FileSystem>(entity =>
        {
            entity.HasKey(e => e.FullPath);

            entity.ToTable("FileSystem");

            entity.HasIndex(e => new { e.ParentPath, e.Filename }, "IX_FileSystem_Parent_Name");

            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Extension)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Filename)
                .IsRequired()
                .HasMaxLength(200);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LastWriteTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.ParentPathNavigation).WithMany(p => p.InverseParentPathNavigation)
                .HasForeignKey(d => d.ParentPath)
                .HasConstraintName("FK_FileSystem_ParentPath");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasIndex(e => e.LanguageId, "IX_Languages_LanguageId").IsUnique();

            entity.Property(e => e.LanguageId)
                .IsRequired()
                .HasMaxLength(10);
            entity.Property(e => e.LanguageName)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<Mail>(entity =>
        {
            entity.Property(e => e.Bcc)
                .HasMaxLength(2000)
                .HasColumnName("BCC");
            entity.Property(e => e.Cc)
                .HasMaxLength(2000)
                .HasColumnName("CC");
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.LockExpiration).HasColumnType("datetime");
            entity.Property(e => e.MailFrom).HasMaxLength(100);
            entity.Property(e => e.MailTo).HasMaxLength(2000);
            entity.Property(e => e.Priority).HasDefaultValue(2);
            entity.Property(e => e.ReplyTo).HasMaxLength(100);
            entity.Property(e => e.SentDate).HasColumnType("datetime");
            entity.Property(e => e.Subject)
                .IsRequired()
                .HasMaxLength(400);
            entity.Property(e => e.Uid).HasColumnName("UID");
        });

        modelBuilder.Entity<Meeting>(entity =>
        {
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.MeetingName)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.MeetingNumber).HasMaxLength(20);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.Location).WithMany(p => p.Meetings)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_Meetings_LocationId");

            entity.HasOne(d => d.MeetingType).WithMany(p => p.Meetings)
                .HasForeignKey(d => d.MeetingTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Meetings_TypeId");

            entity.HasOne(d => d.OrganizerContact).WithMany(p => p.MeetingOrganizerContacts)
                .HasForeignKey(d => d.OrganizerContactId)
                .HasConstraintName("FK_Meetings_Organizer");

            entity.HasOne(d => d.ReporterContact).WithMany(p => p.MeetingReporterContacts)
                .HasForeignKey(d => d.ReporterContactId)
                .HasConstraintName("FK_Meetings_Reporter");

            entity.HasOne(d => d.Unit).WithMany(p => p.Meetings)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK_Meetings_UnitId");
        });

        modelBuilder.Entity<MeetingAgenda>(entity =>
        {
            entity.HasKey(e => e.AgendaId);

            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(2000);

            entity.HasOne(d => d.AgendaType).WithMany(p => p.MeetingAgenda)
                .HasForeignKey(d => d.AgendaTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MeetAgendas_AgendaTypeId");

            entity.HasOne(d => d.Meeting).WithMany(p => p.MeetingAgenda)
                .HasForeignKey(d => d.MeetingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MeetAgendas_MeetingId");

            entity.HasOne(d => d.RequestedByContact).WithMany(p => p.MeetingAgenda)
                .HasForeignKey(d => d.RequestedByContactId)
                .HasConstraintName("FK_MeetAgendas_RequestedBy");
        });

        modelBuilder.Entity<MeetingAgendaType>(entity =>
        {
            entity.HasKey(e => e.AgendaTypeId);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<MeetingDecision>(entity =>
        {
            entity.HasKey(e => e.DecisionId);

            entity.Property(e => e.Description).IsRequired();
            entity.Property(e => e.DueDate).HasColumnType("datetime");

            entity.HasOne(d => d.Agenda).WithMany(p => p.MeetingDecisions)
                .HasForeignKey(d => d.AgendaId)
                .HasConstraintName("FK_MeetDecisions_AgendaId");

            entity.HasOne(d => d.Meeting).WithMany(p => p.MeetingDecisions)
                .HasForeignKey(d => d.MeetingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MeetDecisions_MeetingId");

            entity.HasOne(d => d.ResponsibleContact).WithMany(p => p.MeetingDecisions)
                .HasForeignKey(d => d.ResponsibleContactId)
                .HasConstraintName("FK_MeetDecisions_RequestedBy");
        });

        modelBuilder.Entity<MeetingDecisionRelevant>(entity =>
        {
            entity.HasKey(e => e.DecisionRelevantId);

            entity.ToTable("MeetingDecisionRelevant");

            entity.HasOne(d => d.Contact).WithMany(p => p.MeetingDecisionRelevants)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DecisionRel_ContactId");

            entity.HasOne(d => d.Decision).WithMany(p => p.MeetingDecisionRelevants)
                .HasForeignKey(d => d.DecisionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DecisionRel_DecisionId");
        });

        modelBuilder.Entity<MeetingLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId);

            entity.Property(e => e.Address).HasMaxLength(300);
            entity.Property(e => e.Latitude).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.Longitude).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<MeetingType>(entity =>
        {
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.RoleKey).HasMaxLength(100);
            entity.Property(e => e.RoleName)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<RolePermission>(entity =>
        {
            entity.HasIndex(e => new { e.RoleId, e.PermissionKey }, "UQ_RolePerm_RoleId_PermKey").IsUnique();

            entity.Property(e => e.PermissionKey)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.Role).WithMany(p => p.RolePermissions)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RolePermissions_RoleId");
        });

        modelBuilder.Entity<TaKibA>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ta_kib_a");

            entity.Property(e => e.Alamat)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AsalUsul)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Asal_usul");
            entity.Property(e => e.DevId).HasColumnName("Dev_Id");
            entity.Property(e => e.HakTanah)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Hak_Tanah");
            entity.Property(e => e.Harga).HasColumnType("money");
            entity.Property(e => e.Idpemda)
                .IsRequired()
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("IDPemda");
            entity.Property(e => e.KdAset1).HasColumnName("Kd_Aset1");
            entity.Property(e => e.KdAset2).HasColumnName("Kd_Aset2");
            entity.Property(e => e.KdAset3).HasColumnName("Kd_Aset3");
            entity.Property(e => e.KdAset4).HasColumnName("Kd_Aset4");
            entity.Property(e => e.KdAset5).HasColumnName("Kd_Aset5");
            entity.Property(e => e.KdBidang).HasColumnName("Kd_Bidang");
            entity.Property(e => e.KdData).HasColumnName("Kd_Data");
            entity.Property(e => e.KdDesa).HasColumnName("Kd_Desa");
            entity.Property(e => e.KdHapus).HasColumnName("Kd_Hapus");
            entity.Property(e => e.KdKa).HasColumnName("Kd_KA");
            entity.Property(e => e.KdKabKota).HasColumnName("Kd_Kab_Kota");
            entity.Property(e => e.KdKecamatan).HasColumnName("Kd_Kecamatan");
            entity.Property(e => e.KdMasalah).HasColumnName("Kd_Masalah");
            entity.Property(e => e.KdPemilik).HasColumnName("Kd_Pemilik");
            entity.Property(e => e.KdPenyusutan).HasColumnName("Kd_Penyusutan");
            entity.Property(e => e.KdProv).HasColumnName("Kd_Prov");
            entity.Property(e => e.KdSub).HasColumnName("Kd_Sub");
            entity.Property(e => e.KdUnit).HasColumnName("Kd_Unit");
            entity.Property(e => e.KdUpb).HasColumnName("Kd_UPB");
            entity.Property(e => e.KetMasalah)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Ket_Masalah");
            entity.Property(e => e.Keterangan)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LogEntry)
                .HasColumnType("datetime")
                .HasColumnName("Log_entry");
            entity.Property(e => e.LogUser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Log_User");
            entity.Property(e => e.LuasM2).HasColumnName("Luas_M2");
            entity.Property(e => e.NoId).HasColumnName("No_ID");
            entity.Property(e => e.NoRegister).HasColumnName("No_Register");
            entity.Property(e => e.NoSippt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("No_SIPPT");
            entity.Property(e => e.NoSkguna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("No_SKGuna");
            entity.Property(e => e.NoSp2d)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("No_SP2D");
            entity.Property(e => e.Penggunaan)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SertifikatNomor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sertifikat_Nomor");
            entity.Property(e => e.SertifikatTanggal)
                .HasColumnType("datetime")
                .HasColumnName("Sertifikat_Tanggal");
            entity.Property(e => e.TglPembukuan)
                .HasColumnType("datetime")
                .HasColumnName("Tgl_Pembukuan");
            entity.Property(e => e.TglPerolehan)
                .HasColumnType("datetime")
                .HasColumnName("Tgl_Perolehan");
        });

        modelBuilder.Entity<TaKibB>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ta_kib_b");

            entity.Property(e => e.AsalUsul)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Asal_usul");
            entity.Property(e => e.Bahan)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CC");
            entity.Property(e => e.DevId).HasColumnName("Dev_Id");
            entity.Property(e => e.Harga).HasColumnType("money");
            entity.Property(e => e.Idpemda)
                .IsRequired()
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("IDPemda");
            entity.Property(e => e.KdAset1).HasColumnName("Kd_Aset1");
            entity.Property(e => e.KdAset2).HasColumnName("Kd_Aset2");
            entity.Property(e => e.KdAset3).HasColumnName("Kd_Aset3");
            entity.Property(e => e.KdAset4).HasColumnName("Kd_Aset4");
            entity.Property(e => e.KdAset5).HasColumnName("Kd_Aset5");
            entity.Property(e => e.KdBidang).HasColumnName("Kd_Bidang");
            entity.Property(e => e.KdData).HasColumnName("Kd_Data");
            entity.Property(e => e.KdDesa).HasColumnName("Kd_Desa");
            entity.Property(e => e.KdHapus).HasColumnName("Kd_Hapus");
            entity.Property(e => e.KdKa).HasColumnName("Kd_KA");
            entity.Property(e => e.KdKabKota).HasColumnName("Kd_Kab_Kota");
            entity.Property(e => e.KdKecamatan).HasColumnName("Kd_Kecamatan");
            entity.Property(e => e.KdMasalah).HasColumnName("Kd_Masalah");
            entity.Property(e => e.KdPemilik).HasColumnName("Kd_Pemilik");
            entity.Property(e => e.KdPenyusutan).HasColumnName("Kd_Penyusutan");
            entity.Property(e => e.KdProv).HasColumnName("Kd_Prov");
            entity.Property(e => e.KdRuang).HasColumnName("Kd_Ruang");
            entity.Property(e => e.KdSub).HasColumnName("Kd_Sub");
            entity.Property(e => e.KdUnit).HasColumnName("Kd_Unit");
            entity.Property(e => e.KdUpb).HasColumnName("Kd_UPB");
            entity.Property(e => e.KetMasalah)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Ket_Masalah");
            entity.Property(e => e.Keterangan)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Kondisi)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.LogEntry)
                .HasColumnType("datetime")
                .HasColumnName("Log_entry");
            entity.Property(e => e.LogUser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Log_User");
            entity.Property(e => e.MasaManfaat).HasColumnName("Masa_Manfaat");
            entity.Property(e => e.Merk)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NilaiSisa)
                .HasColumnType("money")
                .HasColumnName("Nilai_Sisa");
            entity.Property(e => e.NoId).HasColumnName("No_ID");
            entity.Property(e => e.NoRegister).HasColumnName("No_Register");
            entity.Property(e => e.NoSippt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("No_SIPPT");
            entity.Property(e => e.NoSkguna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("No_SKGuna");
            entity.Property(e => e.NoSp2d)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("No_SP2D");
            entity.Property(e => e.NomorBpkb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nomor_BPKB");
            entity.Property(e => e.NomorMesin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nomor_Mesin");
            entity.Property(e => e.NomorPabrik)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nomor_Pabrik");
            entity.Property(e => e.NomorPolisi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Nomor_Polisi");
            entity.Property(e => e.NomorRangka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nomor_Rangka");
            entity.Property(e => e.TglPembukuan)
                .HasColumnType("datetime")
                .HasColumnName("Tgl_Pembukuan");
            entity.Property(e => e.TglPerolehan)
                .HasColumnType("datetime")
                .HasColumnName("Tgl_Perolehan");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TaKibC>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ta_kib_c");

            entity.Property(e => e.AsalUsul)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Asal_usul");
            entity.Property(e => e.BertingkatTidak)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Bertingkat_Tidak");
            entity.Property(e => e.BetonTidak)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Beton_tidak");
            entity.Property(e => e.DevId).HasColumnName("Dev_Id");
            entity.Property(e => e.DokumenNomor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Dokumen_Nomor");
            entity.Property(e => e.DokumenTanggal)
                .HasColumnType("datetime")
                .HasColumnName("Dokumen_Tanggal");
            entity.Property(e => e.Harga).HasColumnType("money");
            entity.Property(e => e.Idpemda)
                .IsRequired()
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("IDPemda");
            entity.Property(e => e.KdAset1).HasColumnName("Kd_Aset1");
            entity.Property(e => e.KdAset2).HasColumnName("Kd_Aset2");
            entity.Property(e => e.KdAset3).HasColumnName("Kd_Aset3");
            entity.Property(e => e.KdAset4).HasColumnName("Kd_Aset4");
            entity.Property(e => e.KdAset5).HasColumnName("Kd_Aset5");
            entity.Property(e => e.KdBidang).HasColumnName("Kd_Bidang");
            entity.Property(e => e.KdData).HasColumnName("Kd_Data");
            entity.Property(e => e.KdDesa).HasColumnName("Kd_Desa");
            entity.Property(e => e.KdHapus).HasColumnName("Kd_Hapus");
            entity.Property(e => e.KdKa).HasColumnName("Kd_KA");
            entity.Property(e => e.KdKabKota).HasColumnName("Kd_Kab_Kota");
            entity.Property(e => e.KdKecamatan).HasColumnName("Kd_Kecamatan");
            entity.Property(e => e.KdMasalah).HasColumnName("Kd_Masalah");
            entity.Property(e => e.KdPemilik).HasColumnName("Kd_Pemilik");
            entity.Property(e => e.KdPenyusutan).HasColumnName("Kd_Penyusutan");
            entity.Property(e => e.KdProv).HasColumnName("Kd_Prov");
            entity.Property(e => e.KdSub).HasColumnName("Kd_Sub");
            entity.Property(e => e.KdTanah1).HasColumnName("Kd_Tanah1");
            entity.Property(e => e.KdTanah2).HasColumnName("Kd_Tanah2");
            entity.Property(e => e.KdTanah3).HasColumnName("Kd_Tanah3");
            entity.Property(e => e.KdTanah4).HasColumnName("Kd_Tanah4");
            entity.Property(e => e.KdTanah5).HasColumnName("Kd_Tanah5");
            entity.Property(e => e.KdUnit).HasColumnName("Kd_Unit");
            entity.Property(e => e.KdUpb).HasColumnName("Kd_UPB");
            entity.Property(e => e.KetMasalah)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Ket_Masalah");
            entity.Property(e => e.Keterangan)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.KodeTanah).HasColumnName("Kode_Tanah");
            entity.Property(e => e.Kondisi)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.LogEntry)
                .HasColumnType("datetime")
                .HasColumnName("Log_entry");
            entity.Property(e => e.LogUser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Log_User");
            entity.Property(e => e.Lokasi)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LuasLantai).HasColumnName("Luas_Lantai");
            entity.Property(e => e.MasaManfaat).HasColumnName("Masa_Manfaat");
            entity.Property(e => e.NilaiSisa)
                .HasColumnType("money")
                .HasColumnName("Nilai_Sisa");
            entity.Property(e => e.NoId).HasColumnName("No_ID");
            entity.Property(e => e.NoRegister).HasColumnName("No_Register");
            entity.Property(e => e.NoSippt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("No_SIPPT");
            entity.Property(e => e.NoSkguna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("No_SKGuna");
            entity.Property(e => e.NoSp2d)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("No_SP2D");
            entity.Property(e => e.StatusTanah)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Status_Tanah");
            entity.Property(e => e.TglPembukuan)
                .HasColumnType("datetime")
                .HasColumnName("Tgl_Pembukuan");
            entity.Property(e => e.TglPerolehan)
                .HasColumnType("datetime")
                .HasColumnName("Tgl_Perolehan");
        });

        modelBuilder.Entity<TaKibD>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ta_kib_d");

            entity.Property(e => e.AsalUsul)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Asal_usul");
            entity.Property(e => e.DevId).HasColumnName("Dev_Id");
            entity.Property(e => e.DokumenNomor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Dokumen_Nomor");
            entity.Property(e => e.DokumenTanggal)
                .HasColumnType("datetime")
                .HasColumnName("Dokumen_Tanggal");
            entity.Property(e => e.Harga).HasColumnType("money");
            entity.Property(e => e.Idpemda)
                .IsRequired()
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("IDPemda");
            entity.Property(e => e.KdAset1).HasColumnName("Kd_Aset1");
            entity.Property(e => e.KdAset2).HasColumnName("Kd_Aset2");
            entity.Property(e => e.KdAset3).HasColumnName("Kd_Aset3");
            entity.Property(e => e.KdAset4).HasColumnName("Kd_Aset4");
            entity.Property(e => e.KdAset5).HasColumnName("Kd_Aset5");
            entity.Property(e => e.KdBidang).HasColumnName("Kd_Bidang");
            entity.Property(e => e.KdData).HasColumnName("Kd_Data");
            entity.Property(e => e.KdDesa).HasColumnName("Kd_Desa");
            entity.Property(e => e.KdHapus).HasColumnName("Kd_Hapus");
            entity.Property(e => e.KdKa).HasColumnName("Kd_KA");
            entity.Property(e => e.KdKabKota).HasColumnName("Kd_Kab_Kota");
            entity.Property(e => e.KdKecamatan).HasColumnName("Kd_Kecamatan");
            entity.Property(e => e.KdPemilik).HasColumnName("Kd_Pemilik");
            entity.Property(e => e.KdPenyusutan).HasColumnName("Kd_Penyusutan");
            entity.Property(e => e.KdProv).HasColumnName("Kd_Prov");
            entity.Property(e => e.KdSub).HasColumnName("Kd_Sub");
            entity.Property(e => e.KdTanah1).HasColumnName("Kd_Tanah1");
            entity.Property(e => e.KdTanah2).HasColumnName("Kd_Tanah2");
            entity.Property(e => e.KdTanah3).HasColumnName("Kd_Tanah3");
            entity.Property(e => e.KdTanah4).HasColumnName("Kd_Tanah4");
            entity.Property(e => e.KdTanah5).HasColumnName("Kd_Tanah5");
            entity.Property(e => e.KdUnit).HasColumnName("Kd_Unit");
            entity.Property(e => e.KdUpb).HasColumnName("Kd_UPB");
            entity.Property(e => e.Keterangan)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.KodeTanah).HasColumnName("Kode_Tanah");
            entity.Property(e => e.Kondisi)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Konstruksi)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LogEntry)
                .HasColumnType("datetime")
                .HasColumnName("Log_entry");
            entity.Property(e => e.LogUser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Log_User");
            entity.Property(e => e.Lokasi)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MasaManfaat).HasColumnName("Masa_Manfaat");
            entity.Property(e => e.NilaiSisa)
                .HasColumnType("money")
                .HasColumnName("Nilai_Sisa");
            entity.Property(e => e.NoId).HasColumnName("No_ID");
            entity.Property(e => e.NoRegister).HasColumnName("No_Register");
            entity.Property(e => e.NoSippt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("No_SIPPT");
            entity.Property(e => e.NoSkguna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("No_SKGuna");
            entity.Property(e => e.NoSp2d)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("No_SP2D");
            entity.Property(e => e.StatusTanah)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Status_Tanah");
            entity.Property(e => e.TglPembukuan)
                .HasColumnType("datetime")
                .HasColumnName("Tgl_Pembukuan");
            entity.Property(e => e.TglPerolehan)
                .HasColumnType("datetime")
                .HasColumnName("Tgl_Perolehan");
        });

        modelBuilder.Entity<TaKibE>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ta_kib_e");

            entity.Property(e => e.AsalUsul)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Asal_usul");
            entity.Property(e => e.Bahan)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DevId).HasColumnName("Dev_Id");
            entity.Property(e => e.Harga).HasColumnType("money");
            entity.Property(e => e.Idpemda)
                .IsRequired()
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("IDPemda");
            entity.Property(e => e.Judul)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.KdAset1).HasColumnName("Kd_Aset1");
            entity.Property(e => e.KdAset2).HasColumnName("Kd_Aset2");
            entity.Property(e => e.KdAset3).HasColumnName("Kd_Aset3");
            entity.Property(e => e.KdAset4).HasColumnName("Kd_Aset4");
            entity.Property(e => e.KdAset5).HasColumnName("Kd_Aset5");
            entity.Property(e => e.KdBidang).HasColumnName("Kd_Bidang");
            entity.Property(e => e.KdData).HasColumnName("Kd_Data");
            entity.Property(e => e.KdDesa).HasColumnName("Kd_Desa");
            entity.Property(e => e.KdHapus).HasColumnName("Kd_Hapus");
            entity.Property(e => e.KdKa).HasColumnName("Kd_KA");
            entity.Property(e => e.KdKabKota).HasColumnName("Kd_Kab_Kota");
            entity.Property(e => e.KdKecamatan).HasColumnName("Kd_Kecamatan");
            entity.Property(e => e.KdPemilik).HasColumnName("Kd_Pemilik");
            entity.Property(e => e.KdPenyusutan).HasColumnName("Kd_Penyusutan");
            entity.Property(e => e.KdProv).HasColumnName("Kd_Prov");
            entity.Property(e => e.KdRuang).HasColumnName("Kd_Ruang");
            entity.Property(e => e.KdSub).HasColumnName("Kd_Sub");
            entity.Property(e => e.KdUnit).HasColumnName("Kd_Unit");
            entity.Property(e => e.KdUpb).HasColumnName("Kd_UPB");
            entity.Property(e => e.Keterangan)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Kondisi)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.LogEntry)
                .HasColumnType("datetime")
                .HasColumnName("Log_entry");
            entity.Property(e => e.LogUser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Log_User");
            entity.Property(e => e.MasaManfaat).HasColumnName("Masa_Manfaat");
            entity.Property(e => e.NilaiSisa)
                .HasColumnType("money")
                .HasColumnName("Nilai_Sisa");
            entity.Property(e => e.NoId).HasColumnName("No_ID");
            entity.Property(e => e.NoRegister).HasColumnName("No_Register");
            entity.Property(e => e.NoSippt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("No_SIPPT");
            entity.Property(e => e.NoSkguna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("No_SKGuna");
            entity.Property(e => e.NoSp2d)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("No_SP2D");
            entity.Property(e => e.Pencipta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TglPembukuan)
                .HasColumnType("datetime")
                .HasColumnName("Tgl_Pembukuan");
            entity.Property(e => e.TglPerolehan)
                .HasColumnType("datetime")
                .HasColumnName("Tgl_Perolehan");
            entity.Property(e => e.Ukuran)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TaKibF>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ta_kib_f");

            entity.Property(e => e.AsalUsul)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Asal_usul");
            entity.Property(e => e.BertingkatTidak)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Bertingkat_Tidak");
            entity.Property(e => e.BetonTidak)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Beton_tidak");
            entity.Property(e => e.DokumenNomor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Dokumen_Nomor");
            entity.Property(e => e.DokumenTanggal)
                .HasColumnType("datetime")
                .HasColumnName("Dokumen_Tanggal");
            entity.Property(e => e.Harga).HasColumnType("money");
            entity.Property(e => e.Idpemda)
                .IsRequired()
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("IDPemda");
            entity.Property(e => e.KdAset1).HasColumnName("Kd_Aset1");
            entity.Property(e => e.KdAset2).HasColumnName("Kd_Aset2");
            entity.Property(e => e.KdAset3).HasColumnName("Kd_Aset3");
            entity.Property(e => e.KdAset4).HasColumnName("Kd_Aset4");
            entity.Property(e => e.KdAset5).HasColumnName("Kd_Aset5");
            entity.Property(e => e.KdBidang).HasColumnName("Kd_Bidang");
            entity.Property(e => e.KdDesa).HasColumnName("Kd_Desa");
            entity.Property(e => e.KdHapus).HasColumnName("Kd_Hapus");
            entity.Property(e => e.KdKabKota).HasColumnName("Kd_Kab_Kota");
            entity.Property(e => e.KdKecamatan).HasColumnName("Kd_Kecamatan");
            entity.Property(e => e.KdPemilik).HasColumnName("Kd_Pemilik");
            entity.Property(e => e.KdProv).HasColumnName("Kd_Prov");
            entity.Property(e => e.KdSub).HasColumnName("Kd_Sub");
            entity.Property(e => e.KdTanah1).HasColumnName("Kd_Tanah1");
            entity.Property(e => e.KdTanah2).HasColumnName("Kd_Tanah2");
            entity.Property(e => e.KdTanah3).HasColumnName("Kd_Tanah3");
            entity.Property(e => e.KdTanah4).HasColumnName("Kd_Tanah4");
            entity.Property(e => e.KdTanah5).HasColumnName("Kd_Tanah5");
            entity.Property(e => e.KdUnit).HasColumnName("Kd_Unit");
            entity.Property(e => e.KdUpb).HasColumnName("Kd_UPB");
            entity.Property(e => e.Keterangan)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.KodeTanah).HasColumnName("Kode_Tanah");
            entity.Property(e => e.Kondisi)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Lokasi)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LuasLantai).HasColumnName("Luas_Lantai");
            entity.Property(e => e.NoRegister).HasColumnName("No_Register");
            entity.Property(e => e.StatusTanah)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Status_Tanah");
            entity.Property(e => e.TglPembukuan)
                .HasColumnType("datetime")
                .HasColumnName("Tgl_Pembukuan");
            entity.Property(e => e.TglPerolehan)
                .HasColumnType("datetime")
                .HasColumnName("Tgl_Perolehan");
        });

        modelBuilder.Entity<TblKibA>(entity =>
        {
            entity.HasKey(e => e.KibAId).HasName("PK__tbl_kib___2597CA93A711E914");

            entity.ToTable("tbl_kib_a");

            entity.Property(e => e.KibAId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_a_id");
            entity.Property(e => e.BarangBatasBarat)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_batas_barat");
            entity.Property(e => e.BarangBatasSelatan)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_batas_selatan");
            entity.Property(e => e.BarangBatasTimur)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_batas_timur");
            entity.Property(e => e.BarangBatasUtara)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_batas_utara");
            entity.Property(e => e.BarangCaraperolehan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("barang_caraperolehan");
            entity.Property(e => e.BarangDiinputolehId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("barang_diinputoleh_id");
            entity.Property(e => e.BarangDiinputolehNama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_diinputoleh_nama");
            entity.Property(e => e.BarangDokNamaDok)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_dok_nama_dok");
            entity.Property(e => e.BarangDokNamaKepemilikan)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_dok_nama_kepemilikan");
            entity.Property(e => e.BarangDokNomor)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_dok_nomor");
            entity.Property(e => e.BarangDokTanggal)
                .HasColumnType("datetime")
                .HasColumnName("barang_dok_tanggal");
            entity.Property(e => e.BarangFotodenahFile)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_fotodenah_file");
            entity.Property(e => e.BarangKeterangan)
                .HasMaxLength(600)
                .IsUnicode(false)
                .HasColumnName("barang_keterangan");
            entity.Property(e => e.BarangKodeBarang)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("barang_kode_barang");
            entity.Property(e => e.BarangKodeLokasi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("barang_kode_lokasi");
            entity.Property(e => e.BarangKodeRegBarang)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("barang_kode_reg_barang");
            entity.Property(e => e.BarangKondisiBarang)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("barang_kondisi_barang");
            entity.Property(e => e.BarangLokJalan)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_lok_jalan");
            entity.Property(e => e.BarangLokKabKota)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("barang_lok_kab_kota");
            entity.Property(e => e.BarangLokKecamatanId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("barang_lok_kecamatan_id");
            entity.Property(e => e.BarangLokKecamatanNama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_lok_kecamatan_nama");
            entity.Property(e => e.BarangLokKelurahanDesaId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("barang_lok_kelurahan_desa_id");
            entity.Property(e => e.BarangLokKelurahanDesaNama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_lok_kelurahan_desa_nama");
            entity.Property(e => e.BarangLokKoordinat)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_lok_koordinat");
            entity.Property(e => e.BarangLokProvinsi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("barang_lok_provinsi");
            entity.Property(e => e.BarangLokRtRw)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("barang_lok_rt_rw");
            entity.Property(e => e.BarangLuasTanah).HasColumnName("barang_luas_tanah");
            entity.Property(e => e.BarangNamaBarang)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("barang_nama_barang");
            entity.Property(e => e.BarangNibar)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("barang_nibar");
            entity.Property(e => e.BarangSatuan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("barang_satuan");
            entity.Property(e => e.BarangSpeklainNama1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nama1");
            entity.Property(e => e.BarangSpeklainNama2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nama2");
            entity.Property(e => e.BarangSpeklainNama3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nama3");
            entity.Property(e => e.BarangSpeklainNama4)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nama4");
            entity.Property(e => e.BarangSpeklainNama5)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nama5");
            entity.Property(e => e.BarangSpeklainNilai1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nilai1");
            entity.Property(e => e.BarangSpeklainNilai2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nilai2");
            entity.Property(e => e.BarangSpeklainNilai3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nilai3");
            entity.Property(e => e.BarangSpeklainNilai4)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nilai4");
            entity.Property(e => e.BarangSpeklainNilai5)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nilai5");
            entity.Property(e => e.BarangSpesifikasi)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("barang_spesifikasi");
            entity.Property(e => e.BarangTanggalInput)
                .HasColumnType("datetime")
                .HasColumnName("barang_tanggal_input");
            entity.Property(e => e.BarangTanggalPerolehan)
                .HasColumnType("datetime")
                .HasColumnName("barang_tanggal_perolehan");
            entity.Property(e => e.DateAdd)
                .HasColumnType("datetime")
                .HasColumnName("date_add");
            entity.Property(e => e.DateEdit)
                .HasColumnType("datetime")
                .HasColumnName("date_edit");
            entity.Property(e => e.Dlt)
                .HasDefaultValue((byte)0)
                .HasColumnName("dlt");
            entity.Property(e => e.JenisPenggunaBarang)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("jenis_pengguna_barang");
            entity.Property(e => e.OpAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_add");
            entity.Property(e => e.OpEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_edit");
            entity.Property(e => e.PcAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_add");
            entity.Property(e => e.PcEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_edit");
            entity.Property(e => e.Tahun)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tahun");
            entity.Property(e => e.UnitAlamat)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("unit_alamat");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UnitID");
            entity.Property(e => e.UnitPenggunaBarangId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("unit_pengguna_barang_id");
        });

        modelBuilder.Entity<TblKibAPengalihan>(entity =>
        {
            entity.HasKey(e => e.KibAPengalihanId).HasName("PK__tbl_kib___2597CA93A711E914_copy1");

            entity.ToTable("tbl_kib_a_pengalihan");

            entity.Property(e => e.KibAPengalihanId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_a_pengalihan_id");
            entity.Property(e => e.AsalKodeBarang)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("asal_kode_barang");
            entity.Property(e => e.AsalKodeLokasi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("asal_kode_lokasi");
            entity.Property(e => e.AsalPenggunaBarangId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("asal_pengguna_barang_id");
            entity.Property(e => e.DateAdd)
                .HasColumnType("datetime")
                .HasColumnName("date_add");
            entity.Property(e => e.DateEdit)
                .HasColumnType("datetime")
                .HasColumnName("date_edit");
            entity.Property(e => e.DiinputolehId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_id");
            entity.Property(e => e.DiinputolehNama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_nama");
            entity.Property(e => e.DiinputolehTanggal)
                .HasColumnType("datetime")
                .HasColumnName("diinputoleh_tanggal");
            entity.Property(e => e.Dlt)
                .HasDefaultValue((byte)0)
                .HasColumnName("dlt");
            entity.Property(e => e.DokPendukungLainNomor1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor1");
            entity.Property(e => e.DokPendukungLainNomor2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor2");
            entity.Property(e => e.DokPendukungLainNomor3)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor3");
            entity.Property(e => e.DokPendukungLainTanggal1)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal1");
            entity.Property(e => e.DokPendukungLainTanggal2)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal2");
            entity.Property(e => e.DokPendukungLainTanggal3)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal3");
            entity.Property(e => e.DokPendukungSppspNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_sppsp_nomor");
            entity.Property(e => e.DokPendukungSppspTanggal)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_sppsp_tanggal");
            entity.Property(e => e.DokSumberBastNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_sumber_bast_nomor");
            entity.Property(e => e.DokSumberBastTanggal)
                .HasColumnType("datetime")
                .HasColumnName("dok_sumber_bast_tanggal");
            entity.Property(e => e.JenisPenggunaBarang)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("jenis_pengguna_barang");
            entity.Property(e => e.KibAId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_a_id");
            entity.Property(e => e.OpAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_add");
            entity.Property(e => e.OpEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_edit");
            entity.Property(e => e.PcAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_add");
            entity.Property(e => e.PcEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_edit");
            entity.Property(e => e.PenerimaanHargaSatuan).HasColumnName("penerimaan_harga_satuan");
            entity.Property(e => e.PenerimaanJumlahBarang).HasColumnName("penerimaan_jumlah_barang");
            entity.Property(e => e.PenerimaanNilaiBuku).HasColumnName("penerimaan_nilai_buku");
            entity.Property(e => e.PenerimaanPenyusutan).HasColumnName("penerimaan_penyusutan");
            entity.Property(e => e.PenerimaanSatuan)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("penerimaan_satuan");
            entity.Property(e => e.PenerimaanTanggalPerolehan)
                .HasColumnType("datetime")
                .HasColumnName("penerimaan_tanggal_perolehan");
            entity.Property(e => e.PenerimaanTotalNilaiPerolehan).HasColumnName("penerimaan_total_nilai_perolehan");
            entity.Property(e => e.Tahun)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tahun");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<TblKibAPerolehan1>(entity =>
        {
            entity.HasKey(e => e.KibAPerolehan1Id).HasName("PK__tbl_kib___2597CA93A711E914_copy1_copy3");

            entity.ToTable("tbl_kib_a_perolehan_1");

            entity.Property(e => e.KibAPerolehan1Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_a_perolehan1_id");
            entity.Property(e => e.AttribusiBastNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_bast_nomor");
            entity.Property(e => e.AttribusiBastTanggal)
                .HasColumnType("datetime")
                .HasColumnName("attribusi_bast_tanggal");
            entity.Property(e => e.AttribusiBudgetId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("attribusi_BudgetID");
            entity.Property(e => e.AttribusiDokPendukungLainNama1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_dok_pendukung_lain_nama1");
            entity.Property(e => e.AttribusiDokPendukungLainNama2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_dok_pendukung_lain_nama2");
            entity.Property(e => e.AttribusiDokPendukungLainNama3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_dok_pendukung_lain_nama3");
            entity.Property(e => e.AttribusiDokPendukungLainNomor1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_dok_pendukung_lain_nomor1");
            entity.Property(e => e.AttribusiDokPendukungLainNomor2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_dok_pendukung_lain_nomor2");
            entity.Property(e => e.AttribusiDokPendukungLainNomor3)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_dok_pendukung_lain_nomor3");
            entity.Property(e => e.AttribusiDokPendukungLainTanggal1)
                .HasColumnType("datetime")
                .HasColumnName("attribusi_dok_pendukung_lain_tanggal1");
            entity.Property(e => e.AttribusiDokPendukungLainTanggal2)
                .HasColumnType("datetime")
                .HasColumnName("attribusi_dok_pendukung_lain_tanggal2");
            entity.Property(e => e.AttribusiDokPendukungLainTanggal3)
                .HasColumnType("datetime")
                .HasColumnName("attribusi_dok_pendukung_lain_tanggal3");
            entity.Property(e => e.AttribusiKodeRekening50)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("attribusi_KodeRekening50");
            entity.Property(e => e.AttribusiKontrakKuitansiNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_kontrak_kuitansi_nomor");
            entity.Property(e => e.AttribusiKontrakKuitansiPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_kontrak_kuitansi_penyedia");
            entity.Property(e => e.AttribusiKontrakKuitansiTanggal)
                .HasColumnType("datetime")
                .HasColumnName("attribusi_kontrak_kuitansi_tanggal");
            entity.Property(e => e.AttribusiKontrakPembayaranNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_kontrak_pembayaran_nomor");
            entity.Property(e => e.AttribusiKontrakPembayaranPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_kontrak_pembayaran_penyedia");
            entity.Property(e => e.AttribusiKontrakPembayaranTanggal)
                .HasColumnType("datetime")
                .HasColumnName("attribusi_kontrak_pembayaran_tanggal");
            entity.Property(e => e.AttribusiKontrakSperjanjianNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_kontrak_sperjanjian_nomor");
            entity.Property(e => e.AttribusiKontrakSperjanjianPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_kontrak_sperjanjian_penyedia");
            entity.Property(e => e.AttribusiKontrakSperjanjianTanggal)
                .HasColumnType("datetime")
                .HasColumnName("attribusi_kontrak_sperjanjian_tanggal");
            entity.Property(e => e.AttribusiKontrakSpesananPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_kontrak_spesanan_penyedia");
            entity.Property(e => e.AttribusiKontrakSpkNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_kontrak_spk_nomor");
            entity.Property(e => e.AttribusiKontrakSpkPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_kontrak_spk_penyedia");
            entity.Property(e => e.AttribusiKontrakSpkTanggal)
                .HasColumnType("datetime")
                .HasColumnName("attribusi_kontrak_spk_tanggal");
            entity.Property(e => e.AttribusiNama1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_nama1");
            entity.Property(e => e.AttribusiNama2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_nama2");
            entity.Property(e => e.AttribusiNama3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_nama3");
            entity.Property(e => e.AttribusiNama4)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_nama4");
            entity.Property(e => e.AttribusiNama5)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_nama5");
            entity.Property(e => e.AttribusiNilai1).HasColumnName("attribusi_nilai1");
            entity.Property(e => e.AttribusiNilai2).HasColumnName("attribusi_nilai2");
            entity.Property(e => e.AttribusiNilai3).HasColumnName("attribusi_nilai3");
            entity.Property(e => e.AttribusiNilai4).HasColumnName("attribusi_nilai4");
            entity.Property(e => e.AttribusiNilai5).HasColumnName("attribusi_nilai5");
            entity.Property(e => e.AttribusiSubRo50id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("attribusi_SubRO50ID");
            entity.Property(e => e.AttribusiSubRo50kode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_SubRO50Kode");
            entity.Property(e => e.AttribusiSubRo50nama)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("attribusi_SubRO50Nama");
            entity.Property(e => e.AttribusiSubkeg50Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("attribusi_Subkeg50ID");
            entity.Property(e => e.AttribusiSubkeg50Kode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_Subkeg50Kode");
            entity.Property(e => e.AttribusiSubkeg50Nama)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("attribusi_Subkeg50Nama");
            entity.Property(e => e.BastNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("bast_nomor");
            entity.Property(e => e.BastTanggal)
                .HasColumnType("datetime")
                .HasColumnName("bast_tanggal");
            entity.Property(e => e.BudgetId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BudgetID");
            entity.Property(e => e.DateAdd)
                .HasColumnType("datetime")
                .HasColumnName("date_add");
            entity.Property(e => e.DateEdit)
                .HasColumnType("datetime")
                .HasColumnName("date_edit");
            entity.Property(e => e.DiinputolehId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_id");
            entity.Property(e => e.DiinputolehNama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_nama");
            entity.Property(e => e.DiinputolehTanggal)
                .HasColumnType("datetime")
                .HasColumnName("diinputoleh_tanggal");
            entity.Property(e => e.Dlt)
                .HasDefaultValue((byte)0)
                .HasColumnName("dlt");
            entity.Property(e => e.DokPendukungLainNama1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nama1");
            entity.Property(e => e.DokPendukungLainNama2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nama2");
            entity.Property(e => e.DokPendukungLainNama3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nama3");
            entity.Property(e => e.DokPendukungLainNomor1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor1");
            entity.Property(e => e.DokPendukungLainNomor2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor2");
            entity.Property(e => e.DokPendukungLainNomor3)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor3");
            entity.Property(e => e.DokPendukungLainTanggal1)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal1");
            entity.Property(e => e.DokPendukungLainTanggal2)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal2");
            entity.Property(e => e.DokPendukungLainTanggal3)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal3");
            entity.Property(e => e.HargaSatuanPerolehan).HasColumnName("harga_satuan_perolehan");
            entity.Property(e => e.JenisBelanja)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasComment("1. Belanja Modal\r\n2. Belanja Operasi\r\n3. Belanja Tak Terduga")
                .HasColumnName("jenis_belanja");
            entity.Property(e => e.JenisPenggunaBarang)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("jenis_pengguna_barang");
            entity.Property(e => e.JumlahBarang).HasColumnName("jumlah_barang");
            entity.Property(e => e.KibAId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_a_id");
            entity.Property(e => e.KodeRekening50)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.KontrakKuitansiNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("kontrak_kuitansi_nomor");
            entity.Property(e => e.KontrakKuitansiPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("kontrak_kuitansi_penyedia");
            entity.Property(e => e.KontrakKuitansiTanggal)
                .HasColumnType("datetime")
                .HasColumnName("kontrak_kuitansi_tanggal");
            entity.Property(e => e.KontrakPembayaranNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("kontrak_pembayaran_nomor");
            entity.Property(e => e.KontrakPembayaranPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("kontrak_pembayaran_penyedia");
            entity.Property(e => e.KontrakPembayaranTanggal)
                .HasColumnType("datetime")
                .HasColumnName("kontrak_pembayaran_tanggal");
            entity.Property(e => e.KontrakSperjanjianNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("kontrak_sperjanjian_nomor");
            entity.Property(e => e.KontrakSperjanjianPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("kontrak_sperjanjian_penyedia");
            entity.Property(e => e.KontrakSperjanjianTanggal)
                .HasColumnType("datetime")
                .HasColumnName("kontrak_sperjanjian_tanggal");
            entity.Property(e => e.KontrakSpesananNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("kontrak_spesanan_nomor");
            entity.Property(e => e.KontrakSpesananPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("kontrak_spesanan_penyedia");
            entity.Property(e => e.KontrakSpesananTanggal)
                .HasColumnType("datetime")
                .HasColumnName("kontrak_spesanan_tanggal");
            entity.Property(e => e.KontrakSpkNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("kontrak_spk_nomor");
            entity.Property(e => e.KontrakSpkPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("kontrak_spk_penyedia");
            entity.Property(e => e.KontrakSpkTanggal)
                .HasColumnType("datetime")
                .HasColumnName("kontrak_spk_tanggal");
            entity.Property(e => e.NilaiPerolehanBarang).HasColumnName("nilai_perolehan_barang");
            entity.Property(e => e.OpAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_add");
            entity.Property(e => e.OpEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_edit");
            entity.Property(e => e.PcAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_add");
            entity.Property(e => e.PcEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_edit");
            entity.Property(e => e.SatuanBarang)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("satuan_barang");
            entity.Property(e => e.SubRo50id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SubRO50ID");
            entity.Property(e => e.SubRo50kode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SubRO50Kode");
            entity.Property(e => e.SubRo50nama)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SubRO50Nama");
            entity.Property(e => e.Subkeg50Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Subkeg50ID");
            entity.Property(e => e.Subkeg50Kode)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Subkeg50Nama)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Tahun)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tahun");
            entity.Property(e => e.TotalNilaiBarang).HasColumnName("total_nilai_barang");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<TblKibAPerolehan2>(entity =>
        {
            entity.HasKey(e => e.KibAPerolehan2Id).HasName("PK__tbl_kib___2597CA93A711E914_copy1_copy3_copy1");

            entity.ToTable("tbl_kib_a_perolehan_2");

            entity.Property(e => e.KibAPerolehan2Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_a_perolehan2_id");
            entity.Property(e => e.BastNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("bast_nomor");
            entity.Property(e => e.BastTanggal)
                .HasColumnType("datetime")
                .HasColumnName("bast_tanggal");
            entity.Property(e => e.DateAdd)
                .HasColumnType("datetime")
                .HasColumnName("date_add");
            entity.Property(e => e.DateEdit)
                .HasColumnType("datetime")
                .HasColumnName("date_edit");
            entity.Property(e => e.DiinputolehId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_id");
            entity.Property(e => e.DiinputolehNama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_nama");
            entity.Property(e => e.DiinputolehTanggal)
                .HasColumnType("datetime")
                .HasColumnName("diinputoleh_tanggal");
            entity.Property(e => e.Dlt)
                .HasDefaultValue((byte)0)
                .HasColumnName("dlt");
            entity.Property(e => e.DokPendukungLainNama1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nama1");
            entity.Property(e => e.DokPendukungLainNama2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nama2");
            entity.Property(e => e.DokPendukungLainNama3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nama3");
            entity.Property(e => e.DokPendukungLainNomor1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor1");
            entity.Property(e => e.DokPendukungLainNomor2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor2");
            entity.Property(e => e.DokPendukungLainNomor3)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor3");
            entity.Property(e => e.DokPendukungLainTanggal1)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal1");
            entity.Property(e => e.DokPendukungLainTanggal2)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal2");
            entity.Property(e => e.DokPendukungLainTanggal3)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal3");
            entity.Property(e => e.HargaSatuan).HasColumnName("harga_satuan");
            entity.Property(e => e.JenisPenggunaBarang)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("jenis_pengguna_barang");
            entity.Property(e => e.JumlahBarang).HasColumnName("jumlah_barang");
            entity.Property(e => e.KibAId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_a_id");
            entity.Property(e => e.OpAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_add");
            entity.Property(e => e.OpEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_edit");
            entity.Property(e => e.PcAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_add");
            entity.Property(e => e.PcEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_edit");
            entity.Property(e => e.PemberiHibah)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pemberi_hibah");
            entity.Property(e => e.SatuanBarang)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("satuan_barang");
            entity.Property(e => e.SumberDana)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sumber_dana");
            entity.Property(e => e.Tahun)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tahun");
            entity.Property(e => e.TanggalPerolehan)
                .HasColumnType("datetime")
                .HasColumnName("tanggal_perolehan");
            entity.Property(e => e.TotalNilai).HasColumnName("total_nilai");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<TblKibAPerolehan3>(entity =>
        {
            entity.HasKey(e => e.KibAPerolehan3Id).HasName("PK__tbl_kib___2597CA93A711E914_copy1_copy3_copy1_copy1");

            entity.ToTable("tbl_kib_a_perolehan_3");

            entity.Property(e => e.KibAPerolehan3Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_a_perolehan3_id");
            entity.Property(e => e.DateAdd)
                .HasColumnType("datetime")
                .HasColumnName("date_add");
            entity.Property(e => e.DateEdit)
                .HasColumnType("datetime")
                .HasColumnName("date_edit");
            entity.Property(e => e.DiinputolehId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_id");
            entity.Property(e => e.DiinputolehNama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_nama");
            entity.Property(e => e.DiinputolehTanggal)
                .HasColumnType("datetime")
                .HasColumnName("diinputoleh_tanggal");
            entity.Property(e => e.Dlt)
                .HasDefaultValue((byte)0)
                .HasColumnName("dlt");
            entity.Property(e => e.DokPendukungLainNama1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nama1");
            entity.Property(e => e.DokPendukungLainNama2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nama2");
            entity.Property(e => e.DokPendukungLainNama3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nama3");
            entity.Property(e => e.DokPendukungLainNomor1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor1");
            entity.Property(e => e.DokPendukungLainNomor2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor2");
            entity.Property(e => e.DokPendukungLainNomor3)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor3");
            entity.Property(e => e.DokPendukungLainTanggal1)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal1");
            entity.Property(e => e.DokPendukungLainTanggal2)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal2");
            entity.Property(e => e.DokPendukungLainTanggal3)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal3");
            entity.Property(e => e.DokSpNama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dok_sp_nama");
            entity.Property(e => e.DokSpNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_sp_nomor");
            entity.Property(e => e.DokSpTanggal)
                .HasColumnType("datetime")
                .HasColumnName("dok_sp_tanggal");
            entity.Property(e => e.DokSumberPerolehanNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_sumber_perolehan_nomor");
            entity.Property(e => e.DokSumberPerolehanTanggal)
                .HasColumnType("datetime")
                .HasColumnName("dok_sumber_perolehan_tanggal");
            entity.Property(e => e.HargaSatuan).HasColumnName("harga_satuan");
            entity.Property(e => e.JenisPenggunaBarang)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("jenis_pengguna_barang");
            entity.Property(e => e.JumlahBarang).HasColumnName("jumlah_barang");
            entity.Property(e => e.KibAId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_a_id");
            entity.Property(e => e.OpAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_add");
            entity.Property(e => e.OpEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_edit");
            entity.Property(e => e.PcAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_add");
            entity.Property(e => e.PcEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_edit");
            entity.Property(e => e.PemberiHibah)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pemberi_hibah");
            entity.Property(e => e.SatuanBarang)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("satuan_barang");
            entity.Property(e => e.Tahun)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tahun");
            entity.Property(e => e.TanggalPerolehan)
                .HasColumnType("datetime")
                .HasColumnName("tanggal_perolehan");
            entity.Property(e => e.TotalNilai).HasColumnName("total_nilai");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<TblKibAPihaklain>(entity =>
        {
            entity.HasKey(e => e.KibAPihaklainId).HasName("PK__tbl_kib___2597CA93A711E914_copy1_copy2_copy1");

            entity.ToTable("tbl_kib_a_pihaklain");

            entity.Property(e => e.KibAPihaklainId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_a_pihaklain_id");
            entity.Property(e => e.Alamat)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("alamat");
            entity.Property(e => e.DateAdd)
                .HasColumnType("datetime")
                .HasColumnName("date_add");
            entity.Property(e => e.DateEdit)
                .HasColumnType("datetime")
                .HasColumnName("date_edit");
            entity.Property(e => e.DiinputolehId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_id");
            entity.Property(e => e.DiinputolehNama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_nama");
            entity.Property(e => e.DiinputolehTanggal)
                .HasColumnType("datetime")
                .HasColumnName("diinputoleh_tanggal");
            entity.Property(e => e.Dlt)
                .HasDefaultValue((byte)0)
                .HasColumnName("dlt");
            entity.Property(e => e.DokPendukungLainNomor1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor1");
            entity.Property(e => e.DokPendukungLainNomor2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor2");
            entity.Property(e => e.DokPendukungLainNomor3)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor3");
            entity.Property(e => e.DokPendukungLainTanggal1)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal1");
            entity.Property(e => e.DokPendukungLainTanggal2)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal2");
            entity.Property(e => e.DokPendukungLainTanggal3)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal3");
            entity.Property(e => e.DokSkNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_sk_nomor");
            entity.Property(e => e.DokSkTanggal)
                .HasColumnType("datetime")
                .HasColumnName("dok_sk_tanggal");
            entity.Property(e => e.DokSperjanjianNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_sperjanjian_nomor");
            entity.Property(e => e.DokSperjanjianTanggal)
                .HasColumnType("datetime")
                .HasColumnName("dok_sperjanjian_tanggal");
            entity.Property(e => e.JenisPenggunaBarang)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("jenis_pengguna_barang");
            entity.Property(e => e.JumlahBarang).HasColumnName("jumlah_barang");
            entity.Property(e => e.KibAId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_a_id");
            entity.Property(e => e.OpAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_add");
            entity.Property(e => e.OpEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_edit");
            entity.Property(e => e.PcAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_add");
            entity.Property(e => e.PcEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_edit");
            entity.Property(e => e.Peruntukan)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("peruntukan");
            entity.Property(e => e.PihakLain)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pihak_lain");
            entity.Property(e => e.Satuan)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("satuan");
            entity.Property(e => e.Tahun)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tahun");
            entity.Property(e => e.TanahBangunanDigunakan)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("tanah_bangunan_digunakan");
            entity.Property(e => e.TanggalMulai)
                .HasColumnType("datetime")
                .HasColumnName("tanggal_mulai");
            entity.Property(e => e.TanggalSelesai)
                .HasColumnType("datetime")
                .HasColumnName("tanggal_selesai");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<TblKibASementara>(entity =>
        {
            entity.HasKey(e => e.KibASementaraId).HasName("PK__tbl_kib___2597CA93A711E914_copy1_copy2");

            entity.ToTable("tbl_kib_a_sementara");

            entity.Property(e => e.KibASementaraId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_a_sementara_id");
            entity.Property(e => e.Alamat)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("alamat");
            entity.Property(e => e.DateAdd)
                .HasColumnType("datetime")
                .HasColumnName("date_add");
            entity.Property(e => e.DateEdit)
                .HasColumnType("datetime")
                .HasColumnName("date_edit");
            entity.Property(e => e.DiinputolehId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_id");
            entity.Property(e => e.DiinputolehNama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_nama");
            entity.Property(e => e.DiinputolehTanggal)
                .HasColumnType("datetime")
                .HasColumnName("diinputoleh_tanggal");
            entity.Property(e => e.Dlt)
                .HasDefaultValue((byte)0)
                .HasColumnName("dlt");
            entity.Property(e => e.DokPendukungLainNomor1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor1");
            entity.Property(e => e.DokPendukungLainNomor2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor2");
            entity.Property(e => e.DokPendukungLainNomor3)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor3");
            entity.Property(e => e.DokPendukungLainTanggal1)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal1");
            entity.Property(e => e.DokPendukungLainTanggal2)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal2");
            entity.Property(e => e.DokPendukungLainTanggal3)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal3");
            entity.Property(e => e.DokSperjanjianNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_sperjanjian_nomor");
            entity.Property(e => e.DokSperjanjianTanggal)
                .HasColumnType("datetime")
                .HasColumnName("dok_sperjanjian_tanggal");
            entity.Property(e => e.DokSpersetujuanNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_spersetujuan_nomor");
            entity.Property(e => e.DokSpersetujuanTanggal)
                .HasColumnType("datetime")
                .HasColumnName("dok_spersetujuan_tanggal");
            entity.Property(e => e.JenisPenggunaBarang)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("jenis_pengguna_barang");
            entity.Property(e => e.JumlahBarang).HasColumnName("jumlah_barang");
            entity.Property(e => e.KibAId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_a_id");
            entity.Property(e => e.OpAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_add");
            entity.Property(e => e.OpEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_edit");
            entity.Property(e => e.PcAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_add");
            entity.Property(e => e.PcEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_edit");
            entity.Property(e => e.PenggunaBarangId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pengguna_barang_id");
            entity.Property(e => e.Peruntukan)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("peruntukan");
            entity.Property(e => e.Satuan)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("satuan");
            entity.Property(e => e.Tahun)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tahun");
            entity.Property(e => e.TanahBangunanDigunakan)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("tanah_bangunan_digunakan");
            entity.Property(e => e.TanggalMulai)
                .HasColumnType("datetime")
                .HasColumnName("tanggal_mulai");
            entity.Property(e => e.TanggalSelesai)
                .HasColumnType("datetime")
                .HasColumnName("tanggal_selesai");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<TblKibAtribusi>(entity =>
        {
            entity.HasKey(e => e.KibAtribusiId).HasName("PK__tbl_kib___2597CA93A711E914_copy1_copy1");

            entity.ToTable("tbl_kib_atribusi");

            entity.Property(e => e.KibAtribusiId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_atribusi_id");
            entity.Property(e => e.DateAdd)
                .HasColumnType("datetime")
                .HasColumnName("date_add");
            entity.Property(e => e.DateEdit)
                .HasColumnType("datetime")
                .HasColumnName("date_edit");
            entity.Property(e => e.Dlt)
                .HasDefaultValue((byte)0)
                .HasColumnName("dlt");
            entity.Property(e => e.JenisAtribusi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("{a,b,c,d,e,f}")
                .HasColumnName("jenis_atribusi");
            entity.Property(e => e.JenisBiaya)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("jenis_biaya");
            entity.Property(e => e.KibAId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_a_id");
            entity.Property(e => e.KibAwalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_awal_id");
            entity.Property(e => e.NilaiBiaya).HasColumnName("nilai_biaya");
            entity.Property(e => e.Nourut).HasColumnName("nourut");
            entity.Property(e => e.OpAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_add");
            entity.Property(e => e.OpEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_edit");
            entity.Property(e => e.PcAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_add");
            entity.Property(e => e.PcEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_edit");
            entity.Property(e => e.Tanggal)
                .HasColumnType("datetime")
                .HasColumnName("tanggal");
        });

        modelBuilder.Entity<TblKibB>(entity =>
        {
            entity.HasKey(e => e.KibBId).HasName("PK__tbl_kib___2597CA93A711E914_copy2");

            entity.ToTable("tbl_kib_b");

            entity.Property(e => e.KibBId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_b_id");
            entity.Property(e => e.BarangCaraperolehan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("barang_caraperolehan");
            entity.Property(e => e.BarangDiinputolehId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("barang_diinputoleh_id");
            entity.Property(e => e.BarangDiinputolehNama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_diinputoleh_nama");
            entity.Property(e => e.BarangFotoFile)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_foto_file");
            entity.Property(e => e.BarangIsiSilinder)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("barang_isi_silinder");
            entity.Property(e => e.BarangJenisKendaraan)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("barang_jenis_kendaraan");
            entity.Property(e => e.BarangKeterangan)
                .HasMaxLength(600)
                .IsUnicode(false)
                .HasColumnName("barang_keterangan");
            entity.Property(e => e.BarangKodeBarang)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("barang_kode_barang");
            entity.Property(e => e.BarangKodeLokasi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("barang_kode_lokasi");
            entity.Property(e => e.BarangKodeRegBarang)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("barang_kode_reg_barang");
            entity.Property(e => e.BarangKondisiBarang)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Baik, Rusak Ringan, Rusak Berat atau Usang")
                .HasColumnName("barang_kondisi_barang");
            entity.Property(e => e.BarangLokJalan)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_lok_jalan");
            entity.Property(e => e.BarangLokKabKota)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("barang_lok_kab_kota");
            entity.Property(e => e.BarangLokKecamatanId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("barang_lok_kecamatan_id");
            entity.Property(e => e.BarangLokKecamatanNama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_lok_kecamatan_nama");
            entity.Property(e => e.BarangLokKelurahanDesaId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("barang_lok_kelurahan_desa_id");
            entity.Property(e => e.BarangLokKelurahanDesaNama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_lok_kelurahan_desa_nama");
            entity.Property(e => e.BarangLokProvinsi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("barang_lok_provinsi");
            entity.Property(e => e.BarangLokRtRw)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("barang_lok_rt_rw");
            entity.Property(e => e.BarangMasamanfaat).HasColumnName("barang_masamanfaat");
            entity.Property(e => e.BarangMerek)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("barang_merek");
            entity.Property(e => e.BarangModelKendaraan)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("barang_model_kendaraan");
            entity.Property(e => e.BarangNamaBarang)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("barang_nama_barang");
            entity.Property(e => e.BarangNamapemilik)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_namapemilik");
            entity.Property(e => e.BarangNibar)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("barang_nibar");
            entity.Property(e => e.BarangNoHpGps)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("barang_no_hp_gps");
            entity.Property(e => e.BarangNoMesin)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("barang_no_mesin");
            entity.Property(e => e.BarangNoRangka)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("barang_no_rangka");
            entity.Property(e => e.BarangNobpkb)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("barang_nobpkb");
            entity.Property(e => e.BarangNopol)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("barang_nopol");
            entity.Property(e => e.BarangSisaMasamanfaat)
                .HasComment("Bulan")
                .HasColumnName("barang_sisa_masamanfaat");
            entity.Property(e => e.BarangSpeklainNama1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nama1");
            entity.Property(e => e.BarangSpeklainNama2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nama2");
            entity.Property(e => e.BarangSpeklainNama3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nama3");
            entity.Property(e => e.BarangSpeklainNama4)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nama4");
            entity.Property(e => e.BarangSpeklainNama5)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nama5");
            entity.Property(e => e.BarangSpeklainNilai1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nilai1");
            entity.Property(e => e.BarangSpeklainNilai2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nilai2");
            entity.Property(e => e.BarangSpeklainNilai3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nilai3");
            entity.Property(e => e.BarangSpeklainNilai4)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nilai4");
            entity.Property(e => e.BarangSpeklainNilai5)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barang_speklain_nilai5");
            entity.Property(e => e.BarangSpesifikasi)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("barang_spesifikasi");
            entity.Property(e => e.BarangTahunPembuatan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("barang_tahun_pembuatan");
            entity.Property(e => e.BarangTanggalInput)
                .HasColumnType("datetime")
                .HasColumnName("barang_tanggal_input");
            entity.Property(e => e.BarangTanggalPerolehan)
                .HasColumnType("datetime")
                .HasColumnName("barang_tanggal_perolehan");
            entity.Property(e => e.BarangTipeKendaraan)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("barang_tipe_kendaraan");
            entity.Property(e => e.BarangWarna)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("barang_warna");
            entity.Property(e => e.BarangWarnaTnkb)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("barang_warna_tnkb");
            entity.Property(e => e.DateAdd)
                .HasColumnType("datetime")
                .HasColumnName("date_add");
            entity.Property(e => e.DateEdit)
                .HasColumnType("datetime")
                .HasColumnName("date_edit");
            entity.Property(e => e.Dlt)
                .HasDefaultValue((byte)0)
                .HasColumnName("dlt");
            entity.Property(e => e.JenisPenggunaBarang)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("jenis_pengguna_barang");
            entity.Property(e => e.OpAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_add");
            entity.Property(e => e.OpEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_edit");
            entity.Property(e => e.PcAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_add");
            entity.Property(e => e.PcEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_edit");
            entity.Property(e => e.Tahun)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tahun");
            entity.Property(e => e.UnitAlamat)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("unit_alamat");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UnitID");
            entity.Property(e => e.UnitPenggunaBarangId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("unit_pengguna_barang_id");
        });

        modelBuilder.Entity<TblKibBPengalihan>(entity =>
        {
            entity.HasKey(e => e.KibBPengalihanId).HasName("PK__tbl_kib___2597CA93A711E914_copy1_copy4");

            entity.ToTable("tbl_kib_b_pengalihan");

            entity.Property(e => e.KibBPengalihanId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_b_pengalihan_id");
            entity.Property(e => e.AsalKodeBarang)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("asal_kode_barang");
            entity.Property(e => e.AsalKodeLokasi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("asal_kode_lokasi");
            entity.Property(e => e.AsalPenggunaBarangId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("asal_pengguna_barang_id");
            entity.Property(e => e.DateAdd)
                .HasColumnType("datetime")
                .HasColumnName("date_add");
            entity.Property(e => e.DateEdit)
                .HasColumnType("datetime")
                .HasColumnName("date_edit");
            entity.Property(e => e.DiinputolehId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_id");
            entity.Property(e => e.DiinputolehNama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_nama");
            entity.Property(e => e.DiinputolehTanggal)
                .HasColumnType("datetime")
                .HasColumnName("diinputoleh_tanggal");
            entity.Property(e => e.Dlt)
                .HasDefaultValue((byte)0)
                .HasColumnName("dlt");
            entity.Property(e => e.DokPendukungLainNomor1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor1");
            entity.Property(e => e.DokPendukungLainNomor2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor2");
            entity.Property(e => e.DokPendukungLainNomor3)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor3");
            entity.Property(e => e.DokPendukungLainTanggal1)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal1");
            entity.Property(e => e.DokPendukungLainTanggal2)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal2");
            entity.Property(e => e.DokPendukungLainTanggal3)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal3");
            entity.Property(e => e.DokPendukungSppspNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_sppsp_nomor");
            entity.Property(e => e.DokPendukungSppspTanggal)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_sppsp_tanggal");
            entity.Property(e => e.DokSumberBastNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_sumber_bast_nomor");
            entity.Property(e => e.DokSumberBastTanggal)
                .HasColumnType("datetime")
                .HasColumnName("dok_sumber_bast_tanggal");
            entity.Property(e => e.JenisPenggunaBarang)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("jenis_pengguna_barang");
            entity.Property(e => e.KibBId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_b_id");
            entity.Property(e => e.OpAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_add");
            entity.Property(e => e.OpEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_edit");
            entity.Property(e => e.PcAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_add");
            entity.Property(e => e.PcEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_edit");
            entity.Property(e => e.PenerimaanHargaSatuan).HasColumnName("penerimaan_harga_satuan");
            entity.Property(e => e.PenerimaanJumlahBarang).HasColumnName("penerimaan_jumlah_barang");
            entity.Property(e => e.PenerimaanNilaiBuku).HasColumnName("penerimaan_nilai_buku");
            entity.Property(e => e.PenerimaanPenyusutan).HasColumnName("penerimaan_penyusutan");
            entity.Property(e => e.PenerimaanSatuan)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("penerimaan_satuan");
            entity.Property(e => e.PenerimaanTanggalPerolehan)
                .HasColumnType("datetime")
                .HasColumnName("penerimaan_tanggal_perolehan");
            entity.Property(e => e.PenerimaanTotalNilaiPerolehan).HasColumnName("penerimaan_total_nilai_perolehan");
            entity.Property(e => e.Tahun)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tahun");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<TblKibBPerolehan1>(entity =>
        {
            entity.HasKey(e => e.KibBPerolehan1Id).HasName("PK__tbl_kib___1D0447E59F65D161");

            entity.ToTable("tbl_kib_b_perolehan_1");

            entity.Property(e => e.KibBPerolehan1Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_b_perolehan1_id");
            entity.Property(e => e.AttribusiBastNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_bast_nomor");
            entity.Property(e => e.AttribusiBastTanggal)
                .HasColumnType("datetime")
                .HasColumnName("attribusi_bast_tanggal");
            entity.Property(e => e.AttribusiBudgetId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("attribusi_BudgetID");
            entity.Property(e => e.AttribusiDokPendukungLainNama1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_dok_pendukung_lain_nama1");
            entity.Property(e => e.AttribusiDokPendukungLainNama2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_dok_pendukung_lain_nama2");
            entity.Property(e => e.AttribusiDokPendukungLainNama3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_dok_pendukung_lain_nama3");
            entity.Property(e => e.AttribusiDokPendukungLainNomor1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_dok_pendukung_lain_nomor1");
            entity.Property(e => e.AttribusiDokPendukungLainNomor2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_dok_pendukung_lain_nomor2");
            entity.Property(e => e.AttribusiDokPendukungLainNomor3)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_dok_pendukung_lain_nomor3");
            entity.Property(e => e.AttribusiDokPendukungLainTanggal1)
                .HasColumnType("datetime")
                .HasColumnName("attribusi_dok_pendukung_lain_tanggal1");
            entity.Property(e => e.AttribusiDokPendukungLainTanggal2)
                .HasColumnType("datetime")
                .HasColumnName("attribusi_dok_pendukung_lain_tanggal2");
            entity.Property(e => e.AttribusiDokPendukungLainTanggal3)
                .HasColumnType("datetime")
                .HasColumnName("attribusi_dok_pendukung_lain_tanggal3");
            entity.Property(e => e.AttribusiKodeRekening50)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("attribusi_KodeRekening50");
            entity.Property(e => e.AttribusiKontrakKuitansiNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_kontrak_kuitansi_nomor");
            entity.Property(e => e.AttribusiKontrakKuitansiPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_kontrak_kuitansi_penyedia");
            entity.Property(e => e.AttribusiKontrakKuitansiTanggal)
                .HasColumnType("datetime")
                .HasColumnName("attribusi_kontrak_kuitansi_tanggal");
            entity.Property(e => e.AttribusiKontrakPembayaranNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_kontrak_pembayaran_nomor");
            entity.Property(e => e.AttribusiKontrakPembayaranPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_kontrak_pembayaran_penyedia");
            entity.Property(e => e.AttribusiKontrakPembayaranTanggal)
                .HasColumnType("datetime")
                .HasColumnName("attribusi_kontrak_pembayaran_tanggal");
            entity.Property(e => e.AttribusiKontrakSperjanjianNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_kontrak_sperjanjian_nomor");
            entity.Property(e => e.AttribusiKontrakSperjanjianPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_kontrak_sperjanjian_penyedia");
            entity.Property(e => e.AttribusiKontrakSperjanjianTanggal)
                .HasColumnType("datetime")
                .HasColumnName("attribusi_kontrak_sperjanjian_tanggal");
            entity.Property(e => e.AttribusiKontrakSpesananPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_kontrak_spesanan_penyedia");
            entity.Property(e => e.AttribusiKontrakSpkNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_kontrak_spk_nomor");
            entity.Property(e => e.AttribusiKontrakSpkPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_kontrak_spk_penyedia");
            entity.Property(e => e.AttribusiKontrakSpkTanggal)
                .HasColumnType("datetime")
                .HasColumnName("attribusi_kontrak_spk_tanggal");
            entity.Property(e => e.AttribusiNama1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_nama1");
            entity.Property(e => e.AttribusiNama2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_nama2");
            entity.Property(e => e.AttribusiNama3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_nama3");
            entity.Property(e => e.AttribusiNama4)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_nama4");
            entity.Property(e => e.AttribusiNama5)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("attribusi_nama5");
            entity.Property(e => e.AttribusiNilai1).HasColumnName("attribusi_nilai1");
            entity.Property(e => e.AttribusiNilai2).HasColumnName("attribusi_nilai2");
            entity.Property(e => e.AttribusiNilai3).HasColumnName("attribusi_nilai3");
            entity.Property(e => e.AttribusiNilai4).HasColumnName("attribusi_nilai4");
            entity.Property(e => e.AttribusiNilai5).HasColumnName("attribusi_nilai5");
            entity.Property(e => e.AttribusiSubRo50id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("attribusi_SubRO50ID");
            entity.Property(e => e.AttribusiSubRo50kode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_SubRO50Kode");
            entity.Property(e => e.AttribusiSubRo50nama)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("attribusi_SubRO50Nama");
            entity.Property(e => e.AttribusiSubkeg50Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("attribusi_Subkeg50ID");
            entity.Property(e => e.AttribusiSubkeg50Kode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attribusi_Subkeg50Kode");
            entity.Property(e => e.AttribusiSubkeg50Nama)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("attribusi_Subkeg50Nama");
            entity.Property(e => e.BastNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("bast_nomor");
            entity.Property(e => e.BastTanggal)
                .HasColumnType("datetime")
                .HasColumnName("bast_tanggal");
            entity.Property(e => e.BudgetId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BudgetID");
            entity.Property(e => e.DateAdd)
                .HasColumnType("datetime")
                .HasColumnName("date_add");
            entity.Property(e => e.DateEdit)
                .HasColumnType("datetime")
                .HasColumnName("date_edit");
            entity.Property(e => e.DiinputolehId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_id");
            entity.Property(e => e.DiinputolehNama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_nama");
            entity.Property(e => e.DiinputolehTanggal)
                .HasColumnType("datetime")
                .HasColumnName("diinputoleh_tanggal");
            entity.Property(e => e.Dlt)
                .HasDefaultValue((byte)0)
                .HasColumnName("dlt");
            entity.Property(e => e.DokPendukungLainNama1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nama1");
            entity.Property(e => e.DokPendukungLainNama2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nama2");
            entity.Property(e => e.DokPendukungLainNama3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nama3");
            entity.Property(e => e.DokPendukungLainNomor1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor1");
            entity.Property(e => e.DokPendukungLainNomor2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor2");
            entity.Property(e => e.DokPendukungLainNomor3)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor3");
            entity.Property(e => e.DokPendukungLainTanggal1)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal1");
            entity.Property(e => e.DokPendukungLainTanggal2)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal2");
            entity.Property(e => e.DokPendukungLainTanggal3)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal3");
            entity.Property(e => e.HargaSatuanPerolehan).HasColumnName("harga_satuan_perolehan");
            entity.Property(e => e.JenisBelanja)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasComment("1. Belanja Modal\r\n2. Belanja Operasi\r\n3. Belanja Tak Terduga")
                .HasColumnName("jenis_belanja");
            entity.Property(e => e.JenisPenggunaBarang)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("jenis_pengguna_barang");
            entity.Property(e => e.JumlahBarang).HasColumnName("jumlah_barang");
            entity.Property(e => e.KibBId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_b_id");
            entity.Property(e => e.KodeRekening50)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.KontrakKuitansiNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("kontrak_kuitansi_nomor");
            entity.Property(e => e.KontrakKuitansiPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("kontrak_kuitansi_penyedia");
            entity.Property(e => e.KontrakKuitansiTanggal)
                .HasColumnType("datetime")
                .HasColumnName("kontrak_kuitansi_tanggal");
            entity.Property(e => e.KontrakPembayaranNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("kontrak_pembayaran_nomor");
            entity.Property(e => e.KontrakPembayaranPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("kontrak_pembayaran_penyedia");
            entity.Property(e => e.KontrakPembayaranTanggal)
                .HasColumnType("datetime")
                .HasColumnName("kontrak_pembayaran_tanggal");
            entity.Property(e => e.KontrakSperjanjianNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("kontrak_sperjanjian_nomor");
            entity.Property(e => e.KontrakSperjanjianPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("kontrak_sperjanjian_penyedia");
            entity.Property(e => e.KontrakSperjanjianTanggal)
                .HasColumnType("datetime")
                .HasColumnName("kontrak_sperjanjian_tanggal");
            entity.Property(e => e.KontrakSpesananNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("kontrak_spesanan_nomor");
            entity.Property(e => e.KontrakSpesananPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("kontrak_spesanan_penyedia");
            entity.Property(e => e.KontrakSpesananTanggal)
                .HasColumnType("datetime")
                .HasColumnName("kontrak_spesanan_tanggal");
            entity.Property(e => e.KontrakSpkNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("kontrak_spk_nomor");
            entity.Property(e => e.KontrakSpkPenyedia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("kontrak_spk_penyedia");
            entity.Property(e => e.KontrakSpkTanggal)
                .HasColumnType("datetime")
                .HasColumnName("kontrak_spk_tanggal");
            entity.Property(e => e.NilaiPerolehanBarang).HasColumnName("nilai_perolehan_barang");
            entity.Property(e => e.OpAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_add");
            entity.Property(e => e.OpEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_edit");
            entity.Property(e => e.PcAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_add");
            entity.Property(e => e.PcEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_edit");
            entity.Property(e => e.SatuanBarang)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("satuan_barang");
            entity.Property(e => e.SubRo50id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SubRO50ID");
            entity.Property(e => e.SubRo50kode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SubRO50Kode");
            entity.Property(e => e.SubRo50nama)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SubRO50Nama");
            entity.Property(e => e.Subkeg50Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Subkeg50ID");
            entity.Property(e => e.Subkeg50Kode)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Subkeg50Nama)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Tahun)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tahun");
            entity.Property(e => e.TotalNilaiBarang).HasColumnName("total_nilai_barang");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<TblKibBPihaklain>(entity =>
        {
            entity.HasKey(e => e.KibBPihaklainId).HasName("PK__tbl_kib___2597CA93A711E914_copy1_copy2_copy1_copy1");

            entity.ToTable("tbl_kib_b_pihaklain");

            entity.Property(e => e.KibBPihaklainId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_b_pihaklain_id");
            entity.Property(e => e.Alamat)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("alamat");
            entity.Property(e => e.DateAdd)
                .HasColumnType("datetime")
                .HasColumnName("date_add");
            entity.Property(e => e.DateEdit)
                .HasColumnType("datetime")
                .HasColumnName("date_edit");
            entity.Property(e => e.DiinputolehId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_id");
            entity.Property(e => e.DiinputolehNama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_nama");
            entity.Property(e => e.DiinputolehTanggal)
                .HasColumnType("datetime")
                .HasColumnName("diinputoleh_tanggal");
            entity.Property(e => e.Dlt)
                .HasDefaultValue((byte)0)
                .HasColumnName("dlt");
            entity.Property(e => e.DokPendukungLainNomor1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor1");
            entity.Property(e => e.DokPendukungLainNomor2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor2");
            entity.Property(e => e.DokPendukungLainNomor3)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor3");
            entity.Property(e => e.DokPendukungLainTanggal1)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal1");
            entity.Property(e => e.DokPendukungLainTanggal2)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal2");
            entity.Property(e => e.DokPendukungLainTanggal3)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal3");
            entity.Property(e => e.DokSkNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_sk_nomor");
            entity.Property(e => e.DokSkTanggal)
                .HasColumnType("datetime")
                .HasColumnName("dok_sk_tanggal");
            entity.Property(e => e.DokSperjanjianNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_sperjanjian_nomor");
            entity.Property(e => e.DokSperjanjianTanggal)
                .HasColumnType("datetime")
                .HasColumnName("dok_sperjanjian_tanggal");
            entity.Property(e => e.JenisPenggunaBarang)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("jenis_pengguna_barang");
            entity.Property(e => e.JumlahBarang).HasColumnName("jumlah_barang");
            entity.Property(e => e.KibBId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_b_id");
            entity.Property(e => e.OpAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_add");
            entity.Property(e => e.OpEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_edit");
            entity.Property(e => e.PcAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_add");
            entity.Property(e => e.PcEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_edit");
            entity.Property(e => e.Peruntukan)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("peruntukan");
            entity.Property(e => e.PihakLain)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pihak_lain");
            entity.Property(e => e.Satuan)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("satuan");
            entity.Property(e => e.Tahun)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tahun");
            entity.Property(e => e.TanahBangunanDigunakan)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("tanah_bangunan_digunakan");
            entity.Property(e => e.TanggalMulai)
                .HasColumnType("datetime")
                .HasColumnName("tanggal_mulai");
            entity.Property(e => e.TanggalSelesai)
                .HasColumnType("datetime")
                .HasColumnName("tanggal_selesai");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<TblKibBSementara>(entity =>
        {
            entity.HasKey(e => e.KibBSementaraId).HasName("PK__tbl_kib___2597CA93A711E914_copy1_copy2_copy2");

            entity.ToTable("tbl_kib_b_sementara");

            entity.Property(e => e.KibBSementaraId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_b_sementara_id");
            entity.Property(e => e.Alamat)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("alamat");
            entity.Property(e => e.DateAdd)
                .HasColumnType("datetime")
                .HasColumnName("date_add");
            entity.Property(e => e.DateEdit)
                .HasColumnType("datetime")
                .HasColumnName("date_edit");
            entity.Property(e => e.DiinputolehId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_id");
            entity.Property(e => e.DiinputolehNama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("diinputoleh_nama");
            entity.Property(e => e.DiinputolehTanggal)
                .HasColumnType("datetime")
                .HasColumnName("diinputoleh_tanggal");
            entity.Property(e => e.Dlt)
                .HasDefaultValue((byte)0)
                .HasColumnName("dlt");
            entity.Property(e => e.DokPendukungLainNomor1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor1");
            entity.Property(e => e.DokPendukungLainNomor2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor2");
            entity.Property(e => e.DokPendukungLainNomor3)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_pendukung_lain_nomor3");
            entity.Property(e => e.DokPendukungLainTanggal1)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal1");
            entity.Property(e => e.DokPendukungLainTanggal2)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal2");
            entity.Property(e => e.DokPendukungLainTanggal3)
                .HasColumnType("datetime")
                .HasColumnName("dok_pendukung_lain_tanggal3");
            entity.Property(e => e.DokSperjanjianNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_sperjanjian_nomor");
            entity.Property(e => e.DokSperjanjianTanggal)
                .HasColumnType("datetime")
                .HasColumnName("dok_sperjanjian_tanggal");
            entity.Property(e => e.DokSpersetujuanNomor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dok_spersetujuan_nomor");
            entity.Property(e => e.DokSpersetujuanTanggal)
                .HasColumnType("datetime")
                .HasColumnName("dok_spersetujuan_tanggal");
            entity.Property(e => e.JenisPenggunaBarang)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("jenis_pengguna_barang");
            entity.Property(e => e.JumlahBarang).HasColumnName("jumlah_barang");
            entity.Property(e => e.KibBId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kib_b_id");
            entity.Property(e => e.OpAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_add");
            entity.Property(e => e.OpEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("op_edit");
            entity.Property(e => e.PcAdd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_add");
            entity.Property(e => e.PcEdit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pc_edit");
            entity.Property(e => e.PenggunaBarangId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pengguna_barang_id");
            entity.Property(e => e.Peruntukan)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("peruntukan");
            entity.Property(e => e.Satuan)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("satuan");
            entity.Property(e => e.Tahun)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tahun");
            entity.Property(e => e.TanahBangunanDigunakan)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("tanah_bangunan_digunakan");
            entity.Property(e => e.TanggalMulai)
                .HasColumnType("datetime")
                .HasColumnName("tanggal_mulai");
            entity.Property(e => e.TanggalSelesai)
                .HasColumnType("datetime")
                .HasColumnName("tanggal_selesai");
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<TblLoggpsTrack>(entity =>
        {
            entity.HasKey(e => e.LoggpsTrackid).HasName("PK__tbl_logg__5A018BD3E1DAFE2D");

            entity.ToTable("tbl_loggps_track");

            entity.Property(e => e.LoggpsTrackid).HasColumnName("loggps_trackid");
            entity.Property(e => e.Lat)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("lat");
            entity.Property(e => e.Lon)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("lon");
            entity.Property(e => e.Nohp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nohp");
            entity.Property(e => e.SpeedKmH).HasColumnName("speed_km_h");
            entity.Property(e => e.Tanggal)
                .HasColumnType("datetime")
                .HasColumnName("tanggal");
        });

        modelBuilder.Entity<TblRkbmd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_RKBMD");

            entity.Property(e => e.Dlt).HasColumnName("DLT");
            entity.Property(e => e.JmlExisting).HasColumnName("Jml_Existing");
            entity.Property(e => e.JmlKebMax).HasColumnName("Jml_Keb_Max");
            entity.Property(e => e.JmlUsulan).HasColumnName("Jml_Usulan");
            entity.Property(e => e.Keterangan).HasMaxLength(255);
            entity.Property(e => e.KodeRekening)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Lu)
                .HasColumnType("datetime")
                .HasColumnName("LU");
            entity.Property(e => e.NamaRekening)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Op)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OP");
            entity.Property(e => e.Pc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PC");
            entity.Property(e => e.Rkbmdid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RKBMDID");
            entity.Property(e => e.Rkpdid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RKPDID");
            entity.Property(e => e.Satuan)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SubKegId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SubKegID");
            entity.Property(e => e.SubKegKode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubKegNama)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SubSubRo108id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SubSubRO108ID");
            entity.Property(e => e.SubUnitId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SubUnitID");
            entity.Property(e => e.ThAng)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.UnitId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<TbmAkun108>(entity =>
        {
            entity.HasKey(e => e.Akun108Id).HasName("PK__tbmAkun1__8709F3176C2EE8AB");

            entity.ToTable("tbmAkun108");

            entity.Property(e => e.Akun108Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Akun108ID");
            entity.Property(e => e.AkunKode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AkunNama)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("AKunNama");
            entity.Property(e => e.Dlt).HasColumnName("DLT");
            entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");
            entity.Property(e => e.Keterangan)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Lu)
                .HasColumnType("datetime")
                .HasColumnName("LU");
            entity.Property(e => e.Op)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("OP");
            entity.Property(e => e.Pc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PC");
            entity.Property(e => e.ThAng)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbmJenis108>(entity =>
        {
            entity.HasKey(e => e.Jenis108Id).HasName("PK__tbmJenis__B68BA9F46FFF798F");

            entity.ToTable("tbmJenis108");

            entity.Property(e => e.Jenis108Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Jenis108ID");
            entity.Property(e => e.Dlt).HasColumnName("DLT");
            entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");
            entity.Property(e => e.JenisKode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.JenisNama)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Kelompok108Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Kelompok108ID");
            entity.Property(e => e.Keterangan)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Lu)
                .HasColumnType("datetime")
                .HasColumnName("LU");
            entity.Property(e => e.Op)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("OP");
            entity.Property(e => e.Pc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PC");
            entity.Property(e => e.ThAng)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbmKelompok108>(entity =>
        {
            entity.HasKey(e => e.Kelompok108Id).HasName("PK__tbmKelom__4430C17973D00A73");

            entity.ToTable("tbmKelompok108");

            entity.Property(e => e.Kelompok108Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Kelompok108ID");
            entity.Property(e => e.Akun108Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Akun108ID");
            entity.Property(e => e.Dlt).HasColumnName("DLT");
            entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");
            entity.Property(e => e.KelompokKode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.KelompokNama)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Keterangan)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Lu)
                .HasColumnType("datetime")
                .HasColumnName("LU");
            entity.Property(e => e.Op)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("OP");
            entity.Property(e => e.Pc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PC");
            entity.Property(e => e.ThAng)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbmObjek108>(entity =>
        {
            entity.HasKey(e => e.Objek108Id).HasName("PK__tbmObjek__9FF2EBFC77A09B57");

            entity.ToTable("tbmObjek108");

            entity.Property(e => e.Objek108Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Objek108ID");
            entity.Property(e => e.Dlt).HasColumnName("DLT");
            entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");
            entity.Property(e => e.Jenis108Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Jenis108ID");
            entity.Property(e => e.Keterangan)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Lu)
                .HasColumnType("datetime")
                .HasColumnName("LU");
            entity.Property(e => e.ObjekKode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ObjekNama)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Op)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("OP");
            entity.Property(e => e.Pc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PC");
            entity.Property(e => e.ThAng)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbmRo108>(entity =>
        {
            entity.HasKey(e => e.Ro108id).HasName("PK__tbmRO108__50B7BED57B712C3B");

            entity.ToTable("tbmRO108");

            entity.Property(e => e.Ro108id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RO108ID");
            entity.Property(e => e.Dlt).HasColumnName("DLT");
            entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");
            entity.Property(e => e.Keterangan)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Lu)
                .HasColumnType("datetime")
                .HasColumnName("LU");
            entity.Property(e => e.Objek108Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Objek108ID");
            entity.Property(e => e.Op)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("OP");
            entity.Property(e => e.Pc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PC");
            entity.Property(e => e.Rokode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ROKode");
            entity.Property(e => e.Ronama)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RONama");
            entity.Property(e => e.ThAng)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<TbmRuang>(entity =>
        {
            entity.HasKey(e => e.RuangId);

            entity.ToTable("tbmRuang");

            entity.Property(e => e.RuangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RuangID");
            entity.Property(e => e.Dlt).HasColumnName("DLT");
            entity.Property(e => e.Lu)
                .HasColumnType("datetime")
                .HasColumnName("LU");
            entity.Property(e => e.Op)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OP");
            entity.Property(e => e.Pc)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PC");
            entity.Property(e => e.RuangKode)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.RuangNama)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.SubUnitId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SubUnitID");
            entity.Property(e => e.ThAng)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.UnitId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<TbmStrukRekening108>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbmStrukRekening108");

            entity.HasIndex(e => e.SubSubRo108id, "IX_tbmStrukRekening108_1");

            entity.Property(e => e.Akun108Id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Akun108ID");
            entity.Property(e => e.AkunKode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AkunNama)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");
            entity.Property(e => e.Jenis108Id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Jenis108ID");
            entity.Property(e => e.JenisKode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.JenisNama)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Kelompok108Id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Kelompok108ID");
            entity.Property(e => e.KelompokKode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.KelompokNama)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.KodeRekening108)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Objek108Id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Objek108ID");
            entity.Property(e => e.ObjekKode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ObjekNama)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Ro108id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RO108ID");
            entity.Property(e => e.Rokode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ROKode");
            entity.Property(e => e.Ronama)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RONama");
            entity.Property(e => e.SubRo108id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SubRO108ID");
            entity.Property(e => e.SubRokode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SubROKode");
            entity.Property(e => e.SubRonama)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SubRONama");
            entity.Property(e => e.SubSubRo108id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SubSubRO108ID");
            entity.Property(e => e.SubSubRokode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SubSubROKode");
            entity.Property(e => e.SubSubRonama)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SubSubRONama");
            entity.Property(e => e.ThAng)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbmSubRo108>(entity =>
        {
            entity.HasKey(e => e.SubRo108id).HasName("PK__tbmSubRO__CD6981597F41BD1F");

            entity.ToTable("tbmSubRO108");

            entity.Property(e => e.SubRo108id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SubRO108ID");
            entity.Property(e => e.Dlt).HasColumnName("DLT");
            entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");
            entity.Property(e => e.Keterangan)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Lu)
                .HasColumnType("datetime")
                .HasColumnName("LU");
            entity.Property(e => e.MasaManfaat).HasDefaultValue((byte)0);
            entity.Property(e => e.Op)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("OP");
            entity.Property(e => e.Pc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PC");
            entity.Property(e => e.Ro108id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RO108ID");
            entity.Property(e => e.SubRokode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SubROKode");
            entity.Property(e => e.SubRonama)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SubRONama");
            entity.Property(e => e.ThAng)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbmSubSubRo108>(entity =>
        {
            entity.HasKey(e => e.SubSubRo108id).HasName("PK__tbmSubSu__CC21099203124E03");

            entity.ToTable("tbmSubSubRO108");

            entity.Property(e => e.SubSubRo108id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SubSubRO108ID");
            entity.Property(e => e.Dlt).HasColumnName("DLT");
            entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");
            entity.Property(e => e.Keterangan)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Lu)
                .HasColumnType("datetime")
                .HasColumnName("LU");
            entity.Property(e => e.Op)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("OP");
            entity.Property(e => e.Pc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PC");
            entity.Property(e => e.SubRo108id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SubRO108ID");
            entity.Property(e => e.SubSubRokode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SubSubROKode");
            entity.Property(e => e.SubSubRonama)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SubSubRONama");
            entity.Property(e => e.ThAng)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbmSubUnit>(entity =>
        {
            entity.HasKey(e => e.SubUnitId).HasName("PK_tbmSubUNit");

            entity.ToTable("tbmSubUnit");

            entity.Property(e => e.SubUnitId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SubUnitID");
            entity.Property(e => e.Alamat)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("alamat");
            entity.Property(e => e.Dlt).HasColumnName("DLT");
            entity.Property(e => e.Lu)
                .HasColumnType("datetime")
                .HasColumnName("LU");
            entity.Property(e => e.Npwp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NPWP");
            entity.Property(e => e.Op)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OP");
            entity.Property(e => e.Pc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PC");
            entity.Property(e => e.SubUnitKode)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SubUnitNama)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ThAng)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.UnitId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<TbmUkpb>(entity =>
        {
            entity.HasKey(e => e.Ukpbid);

            entity.ToTable("tbmUKPB");

            entity.Property(e => e.Ukpbid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UKPBID");
            entity.Property(e => e.Dlt).HasColumnName("DLT");
            entity.Property(e => e.Lu)
                .HasColumnType("datetime")
                .HasColumnName("LU");
            entity.Property(e => e.Op)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OP");
            entity.Property(e => e.Pc)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PC");
            entity.Property(e => e.SubUnitId)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SubUnitID");
            entity.Property(e => e.ThAng)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Ukpbkode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UKPBKode");
            entity.Property(e => e.Ukpbnama)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UKPBNama");
            entity.Property(e => e.UnitId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UnitID");
            entity.Property(e => e.Upbid)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPBID");
        });

        modelBuilder.Entity<TbmUkpb50>(entity =>
        {
            entity.HasKey(e => e.Ukpbid);

            entity.ToTable("tbmUKPB50");

            entity.Property(e => e.Ukpbid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UKPBID");
            entity.Property(e => e.Dlt).HasColumnName("DLT");
            entity.Property(e => e.Lu)
                .HasColumnType("datetime")
                .HasColumnName("LU");
            entity.Property(e => e.Op)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OP");
            entity.Property(e => e.Pc)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PC");
            entity.Property(e => e.SubUnitId)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SubUnitID");
            entity.Property(e => e.ThAng)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Ukpbalamat)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("UKPBAlamat");
            entity.Property(e => e.Ukpbkode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UKPBKode");
            entity.Property(e => e.Ukpbnama)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UKPBNama");
            entity.Property(e => e.UnitId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UnitID");
            entity.Property(e => e.Upbid)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPBID");
        });

        modelBuilder.Entity<TbmUnit>(entity =>
        {
            entity.HasKey(e => e.UnitId).HasName("PK_tbmUNit");

            entity.ToTable("tbmUnit");

            entity.Property(e => e.UnitId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UnitID");
            entity.Property(e => e.Alamat)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.Dlt).HasColumnName("DLT");
            entity.Property(e => e.IsBlud).HasColumnName("isBLUD");
            entity.Property(e => e.Lu)
                .HasColumnType("datetime")
                .HasColumnName("LU");
            entity.Property(e => e.Npwp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NPWP");
            entity.Property(e => e.Op)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OP");
            entity.Property(e => e.Pc)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PC");
            entity.Property(e => e.ThAng)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.UnitKode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnitNama)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbmUpb>(entity =>
        {
            entity.HasKey(e => e.Upbid);

            entity.ToTable("tbmUPB");

            entity.Property(e => e.Upbid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPBID");
            entity.Property(e => e.Dlt).HasColumnName("DLT");
            entity.Property(e => e.Lu)
                .HasColumnType("datetime")
                .HasColumnName("LU");
            entity.Property(e => e.Op)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OP");
            entity.Property(e => e.Pc)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PC");
            entity.Property(e => e.SubUnitId)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SubUnitID");
            entity.Property(e => e.ThAng)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.UnitId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UnitID");
            entity.Property(e => e.Upbkode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPBKode");
            entity.Property(e => e.Upbnama)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UPBNama");
        });

        modelBuilder.Entity<TbmUpb50>(entity =>
        {
            entity.HasKey(e => e.Upbid);

            entity.ToTable("tbmUPB50");

            entity.Property(e => e.Upbid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPBID");
            entity.Property(e => e.Dlt).HasColumnName("DLT");
            entity.Property(e => e.Lu)
                .HasColumnType("datetime")
                .HasColumnName("LU");
            entity.Property(e => e.Op)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OP");
            entity.Property(e => e.Pc)
                .IsRequired()
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("PC");
            entity.Property(e => e.SubUnitId)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SubUnitID");
            entity.Property(e => e.ThAng)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.UnitId)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UnitID");
            entity.Property(e => e.Upbalamat)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("UPBAlamat");
            entity.Property(e => e.Upbkode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPBKode");
            entity.Property(e => e.Upbnama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UPBNama");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.Username, "IX_Users_Username").IsUnique();

            entity.Property(e => e.DisplayName)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue((short)1);
            entity.Property(e => e.LastDirectoryUpdate).HasColumnType("datetime");
            entity.Property(e => e.MobilePhoneNumber).HasMaxLength(20);
            entity.Property(e => e.PasswordHash)
                .IsRequired()
                .HasMaxLength(86);
            entity.Property(e => e.PasswordSalt)
                .IsRequired()
                .HasMaxLength(10);
            entity.Property(e => e.Source)
                .IsRequired()
                .HasMaxLength(4);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserImage).HasMaxLength(100);
            entity.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<UserPermission>(entity =>
        {
            entity.HasIndex(e => new { e.UserId, e.PermissionKey }, "UQ_UserPerm_UserId_PermKey").IsUnique();

            entity.Property(e => e.Granted).HasDefaultValue(true);
            entity.Property(e => e.PermissionKey)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.User).WithMany(p => p.UserPermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserPermissions_UserId");
        });

        modelBuilder.Entity<UserPreference>(entity =>
        {
            entity.HasIndex(e => new { e.UserId, e.PreferenceType, e.Name }, "IX_UserPref_UID_PrefType_Name").IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200);
            entity.Property(e => e.PreferenceType)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasIndex(e => new { e.RoleId, e.UserId }, "IX_UserRoles_RoleId_UserId");

            entity.HasIndex(e => new { e.UserId, e.RoleId }, "UQ_UserRoles_UserId_RoleId").IsUnique();

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoles_RoleId");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoles_UserId");
        });

        modelBuilder.Entity<VersionInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VersionInfo");

            entity.HasIndex(e => e.Version, "UC_Version")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.AppliedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1024);
        });

        modelBuilder.Entity<VwKodeSubSubRo108>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwKodeSubSubRO108");

            entity.Property(e => e.Akun108Id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Akun108ID");
            entity.Property(e => e.Akun108Kode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Akun108Nama)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Jen108Id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Jen108ID");
            entity.Property(e => e.Jen108Kode)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Jen108Nama)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Kel108Id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Kel108ID");
            entity.Property(e => e.Kel108Kode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Kel108Nama)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.KodeRekening108)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Oby108Id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Oby108ID");
            entity.Property(e => e.Oby108Kode)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Oby108Nama)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Ro108id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RO108ID");
            entity.Property(e => e.Ro108kode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RO108Kode");
            entity.Property(e => e.Ro108nama)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RO108Nama");
            entity.Property(e => e.SubRo108id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SubRO108ID");
            entity.Property(e => e.SubRo108kode)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("SubRO108Kode");
            entity.Property(e => e.SubRo108nama)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SubRO108Nama");
            entity.Property(e => e.SubSubRo108id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SubSubRO108ID");
            entity.Property(e => e.SubSubRo108nama)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SubSubRO108Nama");
            entity.Property(e => e.SubSubRo108view)
                .HasMaxLength(321)
                .IsUnicode(false)
                .HasColumnName("SubSubRO108View");
            entity.Property(e => e.ThAng)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwStrukRekening108>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwStrukRekening108");

            entity.Property(e => e.Akun108Id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Akun108ID");
            entity.Property(e => e.AkunView)
                .HasMaxLength(261)
                .IsUnicode(false);
            entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");
            entity.Property(e => e.Jenis108Id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Jenis108ID");
            entity.Property(e => e.JenisView)
                .HasMaxLength(281)
                .IsUnicode(false);
            entity.Property(e => e.Kelompok108Id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Kelompok108ID");
            entity.Property(e => e.KelompokView)
                .HasMaxLength(271)
                .IsUnicode(false);
            entity.Property(e => e.KodeRekening108)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Objek108Id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Objek108ID");
            entity.Property(e => e.ObjekView)
                .HasMaxLength(291)
                .IsUnicode(false);
            entity.Property(e => e.Ro108id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RO108ID");
            entity.Property(e => e.Roview)
                .HasMaxLength(301)
                .IsUnicode(false)
                .HasColumnName("ROView");
            entity.Property(e => e.SubRo108id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SubRO108ID");
            entity.Property(e => e.SubRoview)
                .HasMaxLength(311)
                .IsUnicode(false)
                .HasColumnName("SubROView");
            entity.Property(e => e.SubSubRo108id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SubSubRO108ID");
            entity.Property(e => e.SubSubRoview)
                .HasMaxLength(321)
                .IsUnicode(false)
                .HasColumnName("SubSubROView");
            entity.Property(e => e.ThAng)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwStrukRekening108Ro>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwStrukRekening108_RO");

            entity.Property(e => e.Akun108Id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Akun108ID");
            entity.Property(e => e.AkunKode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AkunNama)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Jenis108Id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Jenis108ID");
            entity.Property(e => e.JenisKode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.JenisNama)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Kelompok108Id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Kelompok108ID");
            entity.Property(e => e.KelompokKode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.KelompokNama)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.KodeRo108)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KodeRO108");
            entity.Property(e => e.Objek108Id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Objek108ID");
            entity.Property(e => e.ObjekKode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ObjekNama)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Ro108id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RO108ID");
            entity.Property(e => e.Rokode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ROKode");
            entity.Property(e => e.Ronama)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RONama");
            entity.Property(e => e.ThAng)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSubKegiatan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSubKegiatan");

            entity.Property(e => e.BidangView)
                .HasMaxLength(261)
                .IsUnicode(false);
            entity.Property(e => e.KegView)
                .HasMaxLength(1046)
                .IsUnicode(false);
            entity.Property(e => e.ProgView)
                .HasMaxLength(286)
                .IsUnicode(false);
            entity.Property(e => e.SubKeg50Id)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("subKeg50ID");
            entity.Property(e => e.SubKeg50Kode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SubKegView)
                .HasMaxLength(2566)
                .IsUnicode(false);
            entity.Property(e => e.UrusanView)
                .HasMaxLength(121)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
