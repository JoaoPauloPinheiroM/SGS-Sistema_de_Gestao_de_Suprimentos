namespace SGE.Domain.WhareHouse.Aggregates.Movimentacao;
public class Movimento
{
    public int Id { get; private set; }
    public int EstoqueId { get; private set; }
    public int ProdutoId { get; private set; }
    public double Qtde { get; private set; }
    public DateOnly Data { get; private set; }
}
