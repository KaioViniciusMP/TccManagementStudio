namespace TccManagementPersonal.Views;

public partial class PageTransfencia : ContentPage
{
	public PageTransfencia(string TransferenciaPara)
	{
		InitializeComponent();

        transferenciaPara.Text = TransferenciaPara;

    }

    private void CancelarTransferencia(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void TransferenciaFeita(object sender, EventArgs e)
    {
        DisplayAlert("Success","Parabens Transferencia realizada com sucesso","Fechar");
        Navigation.PopAsync();
    }
}