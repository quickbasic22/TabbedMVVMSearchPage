using System.ComponentModel;
using TabbedMVVMSearchPage.ViewModels;
using Xamarin.Forms;

namespace TabbedMVVMSearchPage.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}