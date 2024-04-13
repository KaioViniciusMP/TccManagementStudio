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
		Navigation.PopToRootAsync();
    }

    private void PageEntradaFinanceiraMensal(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new PageEntradaFinanceiraMensal());
    }
}