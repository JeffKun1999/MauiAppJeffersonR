namespace MauiAppJeffersonR
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.NewPageJeffersonRuiz), typeof(Views.NewPageJeffersonRuiz));
        }
    }
}
