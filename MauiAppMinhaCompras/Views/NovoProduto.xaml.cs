using MauiAppMinhasCompras.Models;

namespace MauiAppMinhaCompras.Views;

public partial class NovoProduto : ContentPage
{
    private object txt_descricao;

    public NovoProduto()
	{
		InitializeComponent();
	}


    private async void ToolbarItem_Clicked(object sender, EventArgs e)
	{
		try
		{
			Produto p = new Produto();
			{
                string Descricao = txt_descricao.Text;
                double Quantidade = Convert.ToDouble(txt_quantidade.Text);
                double Preco = Convert.ToDouble(txt_preco.Text);
            }; // Cria uma nova instância de Produto com os valores atribuídos (em NovoProduto.xaml)

            await App.Db.Insert(p); // O produto é criado
            await DisplayAlert("Sucesso!", "Registro Inserido", "OK");

        }catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "OK");  // Se houver um problema vai aparecer uma mensagem de erro
        }
	}
}