namespace LoginForm;

public partial class Student : ContentPage
{
	public Student()
	{
		InitializeComponent();
    }
    

    private async void OnDashboardTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DashboardPage());
    }
    private async void OnMenuTapped(object sender, EventArgs e)
    {
        DropDownPanel.IsVisible = !DropDownPanel.IsVisible;
    }
    private async void StudentsList(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Student());
    }
    private async void OnDashboardClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DashboardPage());
    }
    private async void OnInstructorTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DashboardPage());
    }

}