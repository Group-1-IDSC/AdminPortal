namespace LoginForm;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Wrap your LoginPage in a NavigationPage
        MainPage = new NavigationPage(new MainPage());
    }
}
