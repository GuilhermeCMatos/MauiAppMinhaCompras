using MauiAppMinhaCompras.Models;

namespace MauiAppMinhaCompras.Views;

public partial class ListaProduto : ContentPage
{
	ObservableCollection<Produto> lista = new ObservableCollection<Produto>();
	public ListaProduto()
	{
		InitializeComponent();

		lst_produtos.ItemsSource = lista;
	}

    protected async override void OnAppearing()
    {
        List<Produto> tpm = await App.Db.GetAll();
		tpm.ForEach(i => lista.Add(i));
    }

    private void TollbarItem_Clicked(object sender, EventArgs e)
	{
		try
		{
			Navegation.PushAsync(new Views.NovoProduto());
		}
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
	}

    private async void txt_search_TextChanged(object sender, TextChangedEventArgs e)
	{
		string q = e.NewTextValue;

		lista.Clear();

		List<Produto> tmp = await App.Db.Search();

		tmp.ForEach(i => lista.Add(i));
	}

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		double soma = lista.Sun(i => 1.Total);

		string msg = $"O total � {soma:C}";

		DisplayAlert("Total dos Produtos", msg, "OK");
    }

    private void MenuItem_Clicked(object sender, EventArgs e)
    {

    }
}