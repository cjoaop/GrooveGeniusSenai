using GrooveGenius.Model;

namespace GrooveGenius.Pages;

public partial class CadUserPage : ContentPage
{
    UserModel _user;

    public CadUserPage()
    {
        _user = new UserModel();

        this.BindingContext = _user;

        InitializeComponent();
    }

    private async void btnCad_Clicked(object sender, EventArgs e)
    {

        if (string.IsNullOrEmpty(_user.Email) && string.IsNullOrEmpty(_user.Password) && string.IsNullOrEmpty(_user.Name))
        {
            await DisplayAlert("Erro", "Preencha todas as informações", "Fechar");
            return;
        }
        var cadastro = await App.BancoDados.UserDataTable.SaveUser(_user);

        if (cadastro > 0)
        {
            await DisplayAlert("Sucesso", "Usuário cadastrado com sucesso", "Fechar");
            await Navigation.PopAsync();
        }


    }
}