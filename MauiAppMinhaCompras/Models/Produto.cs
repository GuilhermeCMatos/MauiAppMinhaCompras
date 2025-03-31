using SQLite;

namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {
        [PrimaryKey, AutoIncrement]

        //Id do produto
        public int Id { get; set; }

        //Nome do produto
        public string Descricao { get; set; }

        //Quantidade do produto
        public double Quantidade { get; set; }

        //Preço do produto
        public double Preco { get; set; }

        //Total do produto
        public double Total { get => Quantidade * Preco; }
    }
}
