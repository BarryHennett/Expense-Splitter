using Expense_Splitter_App.ViewModel;
using Expense_Splitter_App.Model;

namespace Expense_Splitter_App
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }


        

        private void AddGroupBTN_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           // Navigation.PushAsync(new GroupExpenseList());
        }
    }
}