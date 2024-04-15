namespace TccManagementPersonal.Views;

public partial class PageEntrada : ContentPage
{
	public PageEntrada()
	{
		InitializeComponent();
	}

    private void Login(object sender, EventArgs e)
    {
		Navigation.PushAsync(new PageLogin());
    }
}