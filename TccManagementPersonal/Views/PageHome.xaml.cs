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