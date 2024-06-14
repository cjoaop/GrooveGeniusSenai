using GrooveGenius.Model;

namespace GrooveGenius.Pages;

public partial class ProfilePage : ContentPage
{

    private UserModel _usuario;
    public ProfilePage(UserModel usuario)
    {
        InitializeComponent();
        _usuario = usuario;

        lblName.Text = $"{_usuario.Name} ";
        lblEmail.Text = $"{_usuario.Email} ";
        lblPassword.Text = $"{_usuario.Password} ";

    }
    private async void aboutApp(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AboutPage(_usuario));

    }

    private async void profile(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProfilePage(_usuario));
    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage(_usuario));
    }
    private async void Btnsair_Clicked(object sender, EventArgs e)
    {
        App.user = null;
        await Navigation.PopToRootAsync();
    }
}