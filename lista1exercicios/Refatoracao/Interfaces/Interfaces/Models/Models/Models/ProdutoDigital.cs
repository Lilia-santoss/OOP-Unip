namespace ECommerceRefatorado.Models {
    public class ProdutoDigital : Produto {
        public string UrlDownload { get; private set; }

        public ProdutoDigital(string nome, decimal preco, string url)
            : base(nome, preco) {
            UrlDownload = url;
        }

        public override void Exibir() {
            Console.WriteLine($"{Nome} (Digital): {Preco:C} - Link: {UrlDownload}");
        }
    }
}
