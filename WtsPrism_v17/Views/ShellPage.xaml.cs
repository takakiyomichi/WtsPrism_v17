using System;

using Prism.Windows.Mvvm;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using WtsPrism_v17.ViewModels;

namespace WtsPrism_v17.Views
{
    public sealed partial class ShellPage : Page
    {
        private ShellViewModel ViewModel => DataContext as ShellViewModel;

        public Frame ShellFrame => shellFrame;

        public ShellPage()
        {
            InitializeComponent();

            var opacity = this.Opacity;

            var bg = this.Background;

            var paneBg = this.NavigationMenu.PaneBackground;

            NavigationMenu.Background = new SolidColorBrush(Colors.Aqua);
            NavigationMenu.PaneBackground = new SolidColorBrush(Colors.Azure);

            NavigationMenu.PaneForeground = new SolidColorBrush(Colors.Azure);

            NavigationMenu.Opacity = 1;
            NavigationMenu.Foreground = new SolidColorBrush(Colors.Azure);

            NavigationMenu.PaneBackground = new SolidColorBrush(Colors.Azure);

            this.NavigationMenu.PaneForeground = new SolidColorBrush(Colors.Azure);



        }

        public void SetRootFrame(Frame frame)
        {
            shellFrame.Content = frame;
            ViewModel.Initialize(frame);
        }
    }
}
