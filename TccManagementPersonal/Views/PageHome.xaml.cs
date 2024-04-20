using TccManagementPersonal.Componentes;

namespace TccManagementPersonal.Views;

public partial class PageHome : ContentPage
{
    /*bool isDragQueen;
    double initialX = 0;
    double initialY = 0;*/
    public PageHome()
    {
        InitializeComponent();
    }

    private void GoPageEscolherModalidade(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PageEscolherModalidade());
    }

    private void PageServicesConfiguracoes(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new PageServicesConfiguracoes());
    }

    private void PageEscolherAjuda(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new PageEscolherAjuda());
    }

    private void PageEntradaFinanceiraExtra(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new PageEntradaFinanceiraExtra());
    }

    private void PaginaTeste(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new PageEntrada());
    }

    private void PlanejamentoFinanceiro(object sender, TappedEventArgs e)
    {
        DisplayAlert("Aviso", "Em breve teremos novidades.\n \nPagina indisponivel no momento", "Fechar");
    }

    private void HistoricoTransacoesInvestimentos(object sender, TappedEventArgs e)
    {
        string historicoTransacoesInvestimentos = "Investimentos";
        Navigation.PushAsync(new HistoricoTransacoes(historicoTransacoesInvestimentos));
    }

    private void HistoricoTransacoesAlimentacao(object sender, TappedEventArgs e)
    {
        string historicoTransacoesAlimentacao = "Alimentacao";
        Navigation.PushAsync(new HistoricoTransacoes(historicoTransacoesAlimentacao));
    }

    private void HistoricoTransacoesTransporte(object sender, TappedEventArgs e)
    {
        string historicoTransacoesTransporte = "Transporte";
        Navigation.PushAsync(new HistoricoTransacoes(historicoTransacoesTransporte));
    }

    private void HistoricoTransacoesCompras(object sender, TappedEventArgs e)
    {
        string historicoTransacoesCompras = "Compras";
        Navigation.PushAsync(new HistoricoTransacoes(historicoTransacoesCompras));
    }

    private void HistoricoTransacoesSaude(object sender, TappedEventArgs e)
    {
        string historicoTransacoesSaude = "Saude";
        Navigation.PushAsync(new HistoricoTransacoes(historicoTransacoesSaude));
    }

    private void HistoricoTransacoesLazer(object sender, TappedEventArgs e)
    {
        string historicoTransacoesLazer = "Lazer";
        Navigation.PushAsync(new HistoricoTransacoes(historicoTransacoesLazer));
    }

    /*
     <Grid RowDefinitions="*,*" x:Name="grid">
        <StackLayout Grid.Row="0"  BackgroundColor="Purple">
            <Label x:Name="log"/>
            <Label x:Name="log1"/>
            <Label x:Name="log2"/>

        </StackLayout>


        <StackLayout Grid.Row="1" x:Name="div" BackgroundColor="White">
            <StackLayout.GestureRecognizers>
                <DragGestureRecognizer CanDrag="True"/>
                <PointerGestureRecognizer PointerPressed="PointerGestureRecognizer_PointerEntered" PointerMoved="PointerGestureRecognizer_PointerMoved" PointerReleased="PointerGestureRecognizer_PointerReleased"/>
            </StackLayout.GestureRecognizers>
        </StackLayout>
    </Grid>
     */
    /*private void DragGestureRecognizer_DropCompleted(object sender, DragEventArgs e)
    {
        double initialY = 1000;
        initialY = e.GetPosition(null).Value.Y;
        log.Text = initialY.ToString();

        if (initialY > 10000)
        {
            DisplayAlert("foi", "foi", "foi", "foi");
            // Navigation.PushAsync(new ComponenteModalHome());
        }
    }

    private void PointerGestureRecognizer_PointerEntered(object sender, PointerEventArgs e)
    {
        initialX = e.GetPosition(null).Value.X;
        initialY = e.GetPosition(null).Value.Y;
        isDragQueen = true;
    }

    private void PointerGestureRecognizer_PointerMoved(object sender, PointerEventArgs e)
    {
        if (true)
        {
            log1.Text = e.GetPosition(grid).Value.Y.ToString();
            log2.Text = initialY.ToString();

            double newX = e.GetPosition(grid).Value.X - initialX;
            double newY = e.GetPosition(grid).Value.Y - initialY;


            log.Text = newY.ToString();
            //DisplayAlert("foi", newY.ToString(), "foi");

        }
    }

    private void PointerGestureRecognizer_PointerReleased(object sender, PointerEventArgs e)
    {
        isDragQueen = false;
    }*/
}