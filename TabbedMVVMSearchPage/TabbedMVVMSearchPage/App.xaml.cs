using System;
using TabbedMVVMSearchPage.Services;
using TabbedMVVMSearchPage.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedMVVMSearchPage
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
