using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using XamlBrewer.Uwp.SplitViewSample.Views;

namespace XamlBrewer.Uwp.SplitViewSample
{
    public sealed partial class Shell : Page
    {
        public Shell()
        {
            this.InitializeComponent();

            InitializeOpeningManipulation();
            InitializeClosingManipulation();

            //SplitViewFrame.Navigate(typeof(FirstPage));
        }

        private void Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                var menuItem = e.AddedItems.First() as MenuItem;
                if (menuItem.IsNavigation)
                {
                    SplitViewFrame.Navigate(menuItem.NavigationDestination);
                }
                else
                {
                    menuItem.Command.Execute(null);
                }
            }
        }

        #region Opening Manipulation

        private void InitializeOpeningManipulation()
        {
            this.SplitViewOpener.ManipulationCompleted += SplitViewOpener_ManipulationCompleted;
        }

        private void SplitViewOpener_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {
            if (e.Cumulative.Translation.X > 50)
            {
                MySplitView.IsPaneOpen = true;
            }
        }

        #endregion

        #region Closing Manipulation

        private void InitializeClosingManipulation()
        {
            this.SplitViewPane.ManipulationCompleted += SplitViewPane_ManipulationCompleted;
        }

        private void SplitViewPane_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {
            if (e.Cumulative.Translation.X < -50)
            {
                MySplitView.IsPaneOpen = false;
            }
        }

        #endregion

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }
    }
}
