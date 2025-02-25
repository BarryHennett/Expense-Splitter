using Expense_Splitter_App.ViewModel;
namespace Expense_Splitter_App
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
        }

        private void AddGroupBTN_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GroupExpenseList());
        }


    }

}
