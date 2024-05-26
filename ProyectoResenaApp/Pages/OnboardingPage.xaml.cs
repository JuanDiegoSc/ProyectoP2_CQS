namespace ProyectoResenaApp.Pages;

public partial class OnboardingPage : ContentPage
{
	public OnboardingPage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        Preferences.Default.Set(UIConstants.OnboardingShown, string.Empty);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginUsuario());
    }
}