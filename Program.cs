using FinanceControl.Services;

class Program
{
    static void Main(string[] args)
    {
        var sistema = new GerenciadorFinanceiro();
        sistema.Iniciar();
    }
}