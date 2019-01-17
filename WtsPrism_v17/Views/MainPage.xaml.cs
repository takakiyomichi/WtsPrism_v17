using System;

using Windows.UI.Xaml.Controls;

using WtsPrism_v17.ViewModels;

namespace WtsPrism_v17.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
