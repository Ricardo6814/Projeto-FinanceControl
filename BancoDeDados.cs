using FinanceControl.Models;

namespace FinanceControl.Data
{
    public static class BancoDeDados
    {
        private const string caminho = "transacoes.txt";

        public static void Salvar(List<Transacao> transacoes)
        {
            using StreamWriter writer = new(caminho);
            foreach (var t in transacoes)
            {
                writer.WriteLine($"{t.Data};{t.Descricao};{t.Valor};{t.EhReceita}");
            }
        }

        public static List<Transacao> Carregar()
        {
            List<Transacao> lista = new();

            if (!File.Exists(caminho)) return lista;

            foreach (var linha in File.ReadAllLines(caminho))
            {
                var partes = linha.Split(';');
                lista.Add(new Transacao
                {
                    Data = DateTime.Parse(partes[0]),
                    Descricao = partes[1],
                    Valor = decimal.Parse(partes[2]),
                    EhReceita = bool.Parse(partes[3])
                });
            }

            return lista;
        }
    }
}