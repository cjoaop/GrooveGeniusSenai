using GrooveGenius.Model;

namespace GrooveGenius.Pages;

public partial class JudasPages : ContentPage
{
    private UserModel _usuario;
    public JudasPages(UserModel usuario)
	{
        _usuario = usuario;
		InitializeComponent();
	}

    private void btnOpenSpotify(object sender, EventArgs e)
    {
        // Link que você deseja abrir
        string link = "https://www.youtube.com/watch?v=wagn8Wrmzuc";

        // Abre o link no navegador padrão do dispositivo
        Launcher.OpenAsync(new Uri(link));
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage(_usuario));
    }
}