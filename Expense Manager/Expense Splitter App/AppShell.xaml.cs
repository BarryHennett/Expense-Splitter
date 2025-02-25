namespace Expense_Splitter_App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(GroupExpenseList), typeof(GroupExpenseList));
        }
    }
}
