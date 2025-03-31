using MauiAppMinhaCompras.Helpers;

namespace MauiAppMinhaCompras
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper _db;

        public static SQLiteDatabeseHelper Db
        {
            get
            {
                if (_db == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData),
                        "banco_sqlite_compras.db3");

                    _db = new SQLiteDatabeseHelper(".... db3"); //* Provável erro de instanciamento. O caminho do banco de dados deveria ser usado aqui.
                }

                return _db;
            }
        }
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new Views.ListaProduto()); //* Esqueceram o ponto e vírgula no final da linha.
        }
    }

}
