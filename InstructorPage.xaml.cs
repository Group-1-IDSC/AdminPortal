namespace LoginForm;

public partial class InstructorPage : ContentPage
{
	public InstructorPage()
	{
		InitializeComponent();
	}
    private async void OnInstructorTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InstructorPage());
    }
    private async void OnStudentAdminTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Student());
    }


    private async void StudentsList(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Student());
    }
    private async void OnDashboardTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DashboardPage());
    }
    private async void OnInstructorClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InstructorPage());
    }
    private async void OnProfileImageTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Criminology());
    }

}
