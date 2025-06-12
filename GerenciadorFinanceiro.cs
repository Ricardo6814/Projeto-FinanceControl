using FinanceControl.Models;
using FinanceControl.Data;

namespace FinanceControl.Services
{
    public class GerenciadorFinanceiro
    {
        private List<Transacao> transacoes = new();

        public void Iniciar()
        {
            transacoes = BancoDeDados.Carregar();

            while (true)
            {
                Console.Clear();
                Console.WriteLine(" Bem-vindo ao FinanceControl ");
                Console.WriteLine("1 - Adicionar Receita");
                Console.WriteLine("2 - Adicionar Despesa");
                Console.WriteLine("3 - Ver Saldo");
                Console.WriteLine("4 - Listar Transações");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": AdicionarTransacao(true); break;
                    case "2": AdicionarTransacao(false); break;
                    case "3": MostrarSaldo(); break;
                    case "4": ListarTransacoes(); break;
                    case "5": BancoDeDados.Salvar(transacoes); return;
                    default: Console.WriteLine("Opção inválida."); break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        private void AdicionarTransacao(bool ehReceita)
        {
            Console.Write("Descrição: ");
            string desc = Console.ReadLine();
            Console.Write("Valor: R$ ");
            decimal valor = decimal.Parse(Console.ReadLine());

            transacoes.Add(new Transacao
            {
                Data = DateTime.Now,
                Descricao = desc,
                Valor = valor,
                EhReceita = ehReceita
            });

            Console.WriteLine(ehReceita ? "Receita adicionada!" : "Despesa adicionada!");
        }

        private void MostrarSaldo()
        {
            decimal saldo = transacoes
                .Sum(t => t.EhReceita ? t.Valor : -t.Valor);
            Console.WriteLine($"Saldo atual: R$ {saldo:F2}");
        }

        private void ListarTransacoes()
        {
            Console.WriteLine("📄 Transações:");
            foreach (var t in transacoes)
                Console.WriteLine(t);
        }
    }
}