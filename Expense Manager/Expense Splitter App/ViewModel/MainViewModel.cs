using System.ComponentModel;
using Expense_Splitter_App.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Expense_Splitter_App.ViewModel;

public partial class MainViewModel : INotifyPropertyChanged
{
    private Group _selectedGroup;
    public Group SelectedGroup
    {
        get => _selectedGroup;
        set
        {
            _selectedGroup = value;
            OnPropertyChanged();

            // Navigate when a group is selected
            if (_selectedGroup != null)
            {
                NavigateToGroupExpensePage(_selectedGroup);
            }
        }
    }

    public ObservableCollection<Group> Groups {  get; set; }
    public ICommand GroupSelectedCommand { get; }

    public MainViewModel()
    {
        Groups = new ObservableCollection<Group>
        {
                new Group { Id = 1, Name = "Group A" },
                new Group { Id = 2, Name = "Group B" },
                new Group { Id = 3, Name = "Group C" }
        };

        GroupSelectedCommand = new Command<Group>(OnGroupSelected);
    }
    private async void NavigateToGroupExpensePage(Group selectedGroup)
    {
        if (selectedGroup != null)
        {
            await Shell.Current.GoToAsync($"groupexpense?id={selectedGroup.Id}");
        }
    }

    private async void OnGroupSelected(Group selectedGroup)
    {
        if (selectedGroup != null)
        {
            await Shell.Current.GoToAsync($"GroupExpense?id={selectedGroup.Id}");
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
