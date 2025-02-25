using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Expense_Splitter_App.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    string text;

    void AddGroup()
    {
        Text = string.Empty;
    }
}
