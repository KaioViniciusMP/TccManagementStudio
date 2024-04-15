namespace TccManagementPersonal.Views;

public partial class PageServicesConfiguracoes : ContentPage
{
	public PageServicesConfiguracoes()
	{
		InitializeComponent();
	}

    private void EdicaoUsuario(object sender, TappedEventArgs e)
    {
		Navigation.PushAsync(new PageEdicaoUsuario());
    }

    private void EntradaFinanceiraMensal(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new PageEntradaFinanceiraMensal());
    }
}