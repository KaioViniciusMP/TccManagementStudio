namespace TccManagementPersonal.Views;

public partial class PageRelatarProblema : ContentPage
{
	public PageRelatarProblema()
	{
		InitializeComponent();
	}

    private void OperacaoCancelada(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void ProblemaEnviado(object sender, EventArgs e)
    {
        DisplayAlert("Success","Envio do problema com sucesso, prometemos que esse problema sera resolvido brevemente!", "Fechar");
        Navigation.PopAsync();
    }
}