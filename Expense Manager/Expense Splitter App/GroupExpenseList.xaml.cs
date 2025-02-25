using Microsoft.Maui.Controls;
using Expense_Splitter_App.ViewModel;

namespace Expense_Splitter_App;

[QueryProperty(nameof(GroupId), "id")]

public partial class GroupExpenseList : ContentPage
{

    private int _groupId;
    public int GroupId
    {
        get => _groupId;
        set
        {
            _groupId = value;
            BindingContext = new GroupExpenseViewModel(value);
        }
    }

    public GroupExpenseList()
    {
        InitializeComponent();
    }
}