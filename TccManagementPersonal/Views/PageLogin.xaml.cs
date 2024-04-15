namespace TccManagementPersonal.Views;

public partial class PageLogin : ContentPage
{
	public PageLogin()
	{
		InitializeComponent();
	}

    private void Cadastro(object sender, TappedEventArgs e)
    {
		Navigation.PushAsync(new PageCadastro());
    }

    private void Home(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PageHome());
    }
}