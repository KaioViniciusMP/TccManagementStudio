namespace TccManagementPersonal.Views;

public partial class PageOpcoesPersonalizacaoConfig : ContentPage
{
	public PageOpcoesPersonalizacaoConfig()
	{
		InitializeComponent();
	}

    private void PageHome(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new PageHome());
    }

    private void PersonalizacaoAndConfig(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new PageOpcoesPersonalizacaoConfig());
    }

    private void Ajuda(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new PageEscolherAjuda());
    }

    private async void Sair(object sender, TappedEventArgs e)
    {
        bool escolha = await DisplayAlert("Deseja mesmo deslogar do app?", "Clicando em continuar você esta voltando ao menu inicial do app, concorda mesmo com isso?", "Sim", "Fechar");
        if(escolha)
            await Navigation.PopToRootAsync();
    }
}