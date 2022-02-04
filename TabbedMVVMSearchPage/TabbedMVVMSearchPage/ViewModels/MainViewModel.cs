using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace TabbedMVVMSearchPage.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public List<string> MyColors 
        { get { return _myColors; }
            set
            {
                _myColors = value;
                OnPropertyChanged();
            }
        }

        List<string> colors = new List<string>
        {
            "Red", "Blue", "Green", "Magenta", "Yellow", "Navy", "Orange"
        };
        private string _keyword;
        private List<string> _suggestions = new List<string>();
        private bool _isVisible;
        private List<string> _myColors = new List<string>();

        public Command SearchCommand
        {
            get
            {
                return new Command(Search);
            }
        }

        public Command addCommand
        {
            get
            {
                return new Command(add);
            }
        }

        private void add()
        {
            //var color = e.Item as string;
            var c = _myColors;
            c.Add(_keyword);
            MyColors = c.ToList();
            //_myColors.Add(color);
            //ColorsListView.ItemsSource = myColors;
            IsVisible = false;
        }

        public bool IsVisible
        {
            get { return _isVisible; }
            set
            {
                _isVisible = value;
                OnPropertyChanged();
            }
        }

        public List<string> Suggestions
        {
            get { return _suggestions; }
            set
            {
                _suggestions = value;
                OnPropertyChanged();
            }
        }

        private void Search(object obj)
        {
            if (_keyword.Length >= 1)
            {
                Suggestions = colors.Where(c => c.ToLower()
                .Contains(_keyword.ToLower())).ToList();

                //Suggestions.IsVisible = true;
            }
            else
            {
                //SuggestionsListView.IsVisible = false;
            }
        }

        public string Keyword
        {
            get { return _keyword; }
            set
            {
                _keyword = value;
                OnPropertyChanged();
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
