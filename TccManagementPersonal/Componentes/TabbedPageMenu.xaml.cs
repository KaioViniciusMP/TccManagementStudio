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
}