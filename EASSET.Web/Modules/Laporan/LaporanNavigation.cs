using Serenity.Navigation;
using MyPages = EASSET.Laporan.Pages;

[assembly: NavigationMenu(5000, "Laporan", icon: null)]
[assembly: NavigationLink(int.MaxValue, "Laporan/Perolehan & Penerimaan", typeof(MyPages.Laporan), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Laporan/Penggunaan", typeof(MyPages.Laporan), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Laporan/Penerimaan Internal Pengguna Barang", typeof(MyPages.Laporan), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Laporan/Pengeluaran Internal Pengguna Barang", typeof(MyPages.Laporan), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Laporan/Pemanfaatan", typeof(MyPages.Laporan), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Laporan/Reklasifikasi", typeof(MyPages.Laporan), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Laporan/Koreksi", typeof(MyPages.Laporan), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Laporan/Penyusutan & Amortisasi", typeof(MyPages.Laporan), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Laporan/Pengamanan", typeof(MyPages.Laporan), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Laporan/Penghapusan", typeof(MyPages.Laporan), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Laporan/Barang Milik Daerah", typeof(MyPages.Laporan), icon: null)]
