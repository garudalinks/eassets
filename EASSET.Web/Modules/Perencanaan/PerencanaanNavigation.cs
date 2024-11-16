using EASSET.MasterData.Pages;
using Serenity.Navigation;
using MyPages = EASSET.Perencanaan.Pages;

[assembly: NavigationMenu(2000, "Perencanaan", icon: null)]
[assembly: NavigationLink(int.MaxValue, "Perencanaan/Rkbmd", typeof(MyPages.RKBMDController1), icon: null)]