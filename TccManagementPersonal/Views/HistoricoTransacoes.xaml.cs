namespace TccManagementPersonal.Views;

public partial class HistoricoTransacoes : ContentPage
{
    public HistoricoTransacoes(string TipoTransicao)
	{
        InitializeComponent();

        tituloRequisicao.Text = TipoTransicao;

        // Criando uma lista de transações
        List<Transacao> transacoes = new List<Transacao>();

        // Adicionando alguns itens de exemplo
        transacoes.Add(new Transacao { Titulo = "Compra de supermercado", Subtitulo = "Alimentação", Valor = "R$100,00" });
        transacoes.Add(new Transacao { Titulo = "Passeio no parque", Subtitulo = "Lazer", Valor = "R$50,00" });
        transacoes.Add(new Transacao { Titulo = "Passeio no parque", Subtitulo = "Lazer", Valor = "R$50,00" });
        transacoes.Add(new Transacao { Titulo = "Passeio no parque", Subtitulo = "Lazer", Valor = "R$50,00" });
        transacoes.Add(new Transacao { Titulo = "Passeio no parque", Subtitulo = "Lazer", Valor = "R$50,00" });
        transacoes.Add(new Transacao { Titulo = "Passeio no parque", Subtitulo = "Lazer", Valor = "R$50,00" });
        transacoes.Add(new Transacao { Titulo = "Passeio no parque", Subtitulo = "Lazer", Valor = "R$50,00" });
        transacoes.Add(new Transacao { Titulo = "Passeio no parque", Subtitulo = "Lazer", Valor = "R$50,00" });
        transacoes.Add(new Transacao { Titulo = "Passeio no parque", Subtitulo = "Lazer", Valor = "R$50,00" });
        transacoes.Add(new Transacao { Titulo = "Passeio no parque", Subtitulo = "Lazer", Valor = "R$50,00" });
        transacoes.Add(new Transacao { Titulo = "Passeio no parque", Subtitulo = "Lazer", Valor = "R$50,00" });

        // Atribuindo a lista como a fonte de dados do ListView
        ItemsListView.ItemsSource = transacoes;


        if (TipoTransicao == "Investimentos")
		{
            //Fazer requisicao na api de investimentos
            tituloRequisicao.Text = TipoTransicao;

        }
		else if (TipoTransicao == "Alimentacao")
		{
            //Fazer requisicao na api de alimentacao
            tituloRequisicao.Text = TipoTransicao;
        }
        else if (TipoTransicao == "Transporte")
		{
            //Fazer requisicao na api de transporte
            tituloRequisicao.Text = TipoTransicao;
        }
        else if (TipoTransicao == "Compras")
		{
            //Fazer requisicao na api de compras
            tituloRequisicao.Text = TipoTransicao;
        }
        else if (TipoTransicao == "Saude")
		{
            //Fazer requisicao na api de saude
            tituloRequisicao.Text = TipoTransicao;
        }
        else if (TipoTransicao == "Lazer")
        {
            //Fazer requisicao na api de lazer
            tituloRequisicao.Text = TipoTransicao;
        }
        else
        {
            //Fazer requisicao na api de historicos gerais
            tituloRequisicao.Text = TipoTransicao;
        }

        
    }
}

public class Transacao
{
    public string Titulo { get; set; }
    public string Subtitulo { get; set; }
    public string Valor { get; set; }
    // Adicione mais propriedades conforme necessário
}