namespace TccManagementPersonal.Views;

public partial class PageEscolherModalidade : ContentPage
{
	public PageEscolherModalidade()
	{
		InitializeComponent();
	}

    private void btnService(object sender, EventArgs e)
    {
        var botaoClicado = sender as Button;
        if (botaoClicado.Text == "Lazer")
        {
            Navigation.PushAsync(new PageTransfencia(botaoClicado.Text));
        }
        else if(botaoClicado.Text == "Compras")
        {
            Navigation.PushAsync(new PageTransfencia(botaoClicado.Text));
        }
        else if(botaoClicado.Text == "Saúde")
        {
            Navigation.PushAsync(new PageTransfencia(botaoClicado.Text));
        }
        else if(botaoClicado.Text == "Transporte")
        {
            Navigation.PushAsync(new PageTransfencia(botaoClicado.Text));
        }
        else if(botaoClicado.Text == "Alimentação")
        {
            Navigation.PushAsync(new PageTransfencia(botaoClicado.Text));
        }
        else
        {
            Navigation.PushAsync(new PageTransfencia(botaoClicado.Text));
        }
    }
}