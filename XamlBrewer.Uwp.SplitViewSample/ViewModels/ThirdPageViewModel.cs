using Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace XamlBrewer.Uwp.SplitViewSample.ViewModels
{
    class ThirdPageViewModel : ViewModelBase
    {
        private string message = string.Empty;

        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }

        public ICommand ThirdPageCommand
        {
            get { return new DelegateCommand(ThirdPage_Executed); }
        }

        private void ThirdPage_Executed()
        {
            if (message == String.Empty)
            {
                Message = "SplitView Rocks";
            }
            else
            {
                Message = String.Empty;
            }
        }
    }
}
