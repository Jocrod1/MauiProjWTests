using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProjWTests
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        int counter;

        [ObservableProperty]
        bool trying;

        [RelayCommand]
        void Count()
        {
            Counter++;
            Trying =  !Trying;
        }
    }
}
