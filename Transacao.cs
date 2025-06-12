namespace FinanceControl.Models
{
    public class Transacao
    {
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool EhReceita { get; set; }

        public override string ToString()
        {
            string tipo = EhReceita ? "Receita" : "Despesa";
            return $"{Data:dd/MM/yyyy} - {tipo} - {Descricao} - R${Valor:F2}";
        }
    }
}