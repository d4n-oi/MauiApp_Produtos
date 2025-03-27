namespace MauiApp3;

public partial class ListaProdutoPage : ContentPage
{
    public ListaProdutoPage()
    {
        List<Produto> lista = Produto.Lista;

        InitializeComponent();

        lstProduto.ItemsSource = lista;
    }

    private void lstProduto_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Produto produto)
        {

            Navigation.PushAsync(new ProdutoPage() { BindingContext = produto });
            lstProduto.SelectedItem = null;
        }
    }

    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}