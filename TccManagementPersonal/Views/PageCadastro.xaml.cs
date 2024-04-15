using TccManagementPersonal.Views;

namespace TccManagementPersonal;

public partial class PageCadastro : ContentPage
{
	public PageCadastro()
	{
		InitializeComponent();
	}

    private void Login(object sender, EventArgs e)
    {
		Navigation.PushAsync(new PageLogin());
    }
}