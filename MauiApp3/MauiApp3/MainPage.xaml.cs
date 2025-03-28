namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private void btnProduto_Clicked(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Nome = "Buzina";
            produto.Preco = 300;
            produto.Categoria = "Acessórios";
            produto.Descricao = "Buzina com som de trem";
            produto.Estoque = 100;
            produto.Imagem = ImageSource.FromFile("trem.png");

            Navigation.PushAsync(new ProdutoPage() { BindingContext = produto });
        }

        private void btnListaProduto_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaProdutoPage());
        }
    }

}
