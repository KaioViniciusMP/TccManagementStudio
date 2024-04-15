namespace TccManagementPersonal.Views;

public partial class PageEdicaoUsuario : ContentPage
{
	public PageEdicaoUsuario()
	{
		InitializeComponent();
	}

    private void CancelarOperacao(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }

    private void EdicaoFeita(object sender, EventArgs e)
    {
        DisplayAlert("Success","Atualização feita com sucesso!","fechar");
        Navigation.PopAsync();
    }
}