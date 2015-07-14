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
    class ViewModelBase : BindableBase
    {
        private static ObservableCollection<MenuItem> menu = new ObservableCollection<MenuItem>();

        public ViewModelBase()
        {}

        public ObservableCollection<MenuItem> Menu {
            get { return menu; }
        }
    }
}
