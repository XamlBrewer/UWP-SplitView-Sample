using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using XamlBrewer.Uwp.SplitViewSample.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace XamlBrewer.Uwp.SplitViewSample.Views
{
    public sealed partial class ThirdPage : Page
    {
        private MenuItem myItem;

        public ThirdPage()
        {
            this.InitializeComponent();

           myItem = new MenuItem() { Glyph= "", Text = "Credits", Command = (DataContext as ThirdPageViewModel).ThirdPageCommand };
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            (this.DataContext as ViewModelBase).Menu.Add(myItem);
            base.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            (this.DataContext as ViewModelBase).Menu.Remove(myItem);
            base.OnNavigatedFrom(e);
        }
    }
}
