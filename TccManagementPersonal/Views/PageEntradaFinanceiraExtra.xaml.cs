namespace TccManagementPersonal.Views;

public partial class PageEntradaFinanceiraExtra : ContentPage
{
	public PageEntradaFinanceiraExtra()
	{
		InitializeComponent();
	}

    private void EntradaExtraDefinida(object sender, EventArgs e)
    {
        DisplayAlert("Success","Entrada extra definida com sucesso!","Fechar");
        Navigation.PopAsync();
    }

    private void OperacaoCancelada(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}