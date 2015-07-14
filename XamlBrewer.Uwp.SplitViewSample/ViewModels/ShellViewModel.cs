using Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamlBrewer.Uwp.SplitViewSample.Views;

namespace XamlBrewer.Uwp.SplitViewSample.ViewModels
{
    class ShellViewModel : ViewModelBase
    {
        public ShellViewModel()
        {
            // Build the menu
            Menu.Add(new MenuItem() { Glyph = "", Text = "First", NavigationDestination = typeof(FirstPage) });
            Menu.Add(new MenuItem() { Glyph = "", Text = "Second", NavigationDestination = typeof(SecondPage) });
            Menu.Add(new MenuItem() { Glyph = "", Text = "Third", NavigationDestination = typeof(ThirdPage) });
        }
    }
}
