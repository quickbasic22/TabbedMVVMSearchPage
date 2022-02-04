using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TabbedMVVMSearchPage.Models;
using TabbedMVVMSearchPage.ViewModels;
using TabbedMVVMSearchPage.Views;
using System;

namespace TabbedMVVMSearchPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        
        //List<string> colors = new List<string>
        //{
        //    "Red", "Blue", "Green", "Magenta", "Yellow", "Navy", "Orange"
        //};

        //ObservableCollection<string> myColors = new ObservableCollection<string>();



        //private void ColorSearchBar_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    var keyword = ColorSearchBar.Text;

        //    if (keyword.Length >= 1)
        //    {
        //        var suggestions = colors.Where(c => c.ToLower().Contains(keyword.ToLower()));
        //        SuggestionsListView.ItemsSource = suggestions;
        //        SuggestionsListView.IsVisible = true;

        //    }
        //    else
        //    {
        //        SuggestionsListView.IsVisible = false;
        //    }

        //}

        //private void SuggestionsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    //var color = e.Item as string;
        //    //myColors.Add(color);
        //    //ColorsListView.ItemsSource = myColors;
        //    //SuggestionsListView.IsVisible = false;
        //}
    }
}