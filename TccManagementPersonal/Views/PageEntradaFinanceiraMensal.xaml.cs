namespace TccManagementPersonal.Views;

public partial class PageEntradaFinanceiraMensal : ContentPage
{
	public PageEntradaFinanceiraMensal()
	{
		InitializeComponent();
	}

    private void CancelarOperacao(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }

    private void DefinicaoFeita(object sender, EventArgs e)
    {
        DisplayAlert("Success", "Definição feita com sucesso!", "fechar");
        Navigation.PopAsync();
    }
}