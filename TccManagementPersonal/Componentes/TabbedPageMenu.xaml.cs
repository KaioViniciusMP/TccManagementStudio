using TccManagementPersonal.Views;

namespace TccManagementPersonal.Componentes;

public partial class TabbedPageMenu : StackLayout
{
	public TabbedPageMenu()
	{
		InitializeComponent();
	}

    private void PopPageHome(object sender, TappedEventArgs e)
    {
		Navigation.PushAsync(new PageHome());
    }

    private void PageEntradaFinanceiraMensal(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new PageEntradaFinanceiraMensal());
    }

    private void OpcoesPersonalizacaogAndConfig(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new PageOpcoesPersonalizacaoConfig());
    }

    private void HistoricoCompletoTransacoes(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ());
    }
}