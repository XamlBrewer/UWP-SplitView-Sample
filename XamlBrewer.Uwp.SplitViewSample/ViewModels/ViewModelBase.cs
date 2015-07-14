using Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlBrewer.Uwp.SplitViewSample.ViewModels
{
    class ViewModelBase : BindableBase
    {
        public ViewModelBase()
        {
            Menu = new ObservableCollection<MenuItem>();
        }

        public ObservableCollection<MenuItem> Menu { get; private set; }
    }
}
