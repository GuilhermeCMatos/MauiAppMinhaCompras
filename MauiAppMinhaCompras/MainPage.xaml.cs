namespace MauiAppMinhaCompras
{
    public partial class MainPage : ContentPage
    {
        int count = 0; // Variável usada para contar os cliques do botão.

        public MainPage()
        {
            InitializeComponent(); // Inicializa os componentes da interface gráfica.
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time"; // Ajuste de singular/plural.
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text); // Anuncia o texto para acessibilidade.
        }
    }
}
