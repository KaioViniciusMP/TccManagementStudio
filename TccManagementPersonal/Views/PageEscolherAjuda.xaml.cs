namespace TccManagementPersonal.Views;

public partial class PageEscolherAjuda : ContentPage
{
	public PageEscolherAjuda()
	{
		InitializeComponent();
	}

    private void PageRelatarProblema(object sender, TappedEventArgs e)
    {
		Navigation.PushAsync(new PageRelatarProblema());
    }

    private void PagePrivacidadeSeguranca(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new PagePrivacidadeSegurança());
    }
}