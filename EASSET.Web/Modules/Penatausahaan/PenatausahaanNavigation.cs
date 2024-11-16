using Serenity.Navigation;
using MyPages = EASSET.Penatausahaan.Pages;

[assembly: NavigationMenu(3000, "Penatausahaan", icon: null)]
[assembly: NavigationLink(int.MaxValue, "Penatausahaan/Perolehan atau Penerimaan BMD/Aset Tetap Tanah", typeof(MyPages.TanahPage), icon: null)]

[assembly: NavigationLink(int.MaxValue, "Penatausahaan/Perolehan atau Penerimaan BMD/Aset Tetap Peralatan dan Mesin", typeof(MyPages.MesinPage), icon: null)]