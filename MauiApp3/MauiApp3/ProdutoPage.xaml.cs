namespace MauiApp3;

public partial class ProdutoPage : ContentPage
{
	public ProdutoPage()
	{
		InitializeComponent();
	}

    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ListaProdutoPage());
    }
}