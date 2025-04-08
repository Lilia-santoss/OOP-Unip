namespace ECommerceRefatorado.Services {
    public class ProcessadorPagamento : IDisposable {
        public void Processar(decimal valor) {
            Console.WriteLine($"Processando pagamento de {valor:C}...");
        }

        public void Dispose() {
            Console.WriteLine("Conexão com gateway de pagamento encerrada.");
        }
    }
}
