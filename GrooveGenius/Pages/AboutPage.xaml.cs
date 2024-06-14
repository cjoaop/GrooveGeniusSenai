using GrooveGenius.Model;

namespace GrooveGenius.Pages;

public partial class AboutPage : ContentPage
{
    private UserModel _usuario;
    public AboutPage(UserModel usuario)
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

    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage(_usuario));
    }
}