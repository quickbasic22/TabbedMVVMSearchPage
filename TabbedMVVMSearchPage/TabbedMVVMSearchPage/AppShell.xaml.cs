using System;
using System.Collections.Generic;
using TabbedMVVMSearchPage.ViewModels;
using TabbedMVVMSearchPage.Views;
using Xamarin.Forms;

namespace TabbedMVVMSearchPage
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

        }

    }
}
