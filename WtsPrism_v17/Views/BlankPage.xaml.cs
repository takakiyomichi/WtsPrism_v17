using System;

using Windows.UI.Xaml.Controls;

using WtsPrism_v17.ViewModels;

namespace WtsPrism_v17.Views
{
    public sealed partial class BlankPage : Page
    {
        private BlankViewModel ViewModel => DataContext as BlankViewModel;

        public BlankPage()
        {
            InitializeComponent();
        }
    }
}
