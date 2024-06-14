using GrooveGenius.Model;

namespace GrooveGenius.Pages;

public partial class HomePage : ContentPage
{
    private UserModel _usuario;
    public HomePage(UserModel usuario)
	{
        _usuario = usuario;
        InitializeComponent();
	}

    private async void aboutApp(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AboutPage(_usuario));

    }

    private async void profile(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProfilePage(_usuario));

    }

    private async void ggStar(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new starboyPage(_usuario));

    }

    private async void ggCome(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LittlePage(_usuario));
    }

    private async void ggFlashing(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlashingPage(_usuario));
    }

    private async void ggJudas(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new JudasPages(_usuario));
    }
}