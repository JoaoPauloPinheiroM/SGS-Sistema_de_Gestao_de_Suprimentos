using SGE.Domain.WhareHouse.Aggregates.Movimentacao;

namespace SGE.Domain.WhareHouse.Aggregates.Estoques;

public class ProdutoEstoque
{
    public int EstoqueId { get; private set; }
    public int ProdutoId { get; private set; }
    public double Qtde { get; private set; }
    public int Versao { get; private set; }
    private readonly List<Movimento> _novosMovimentos = new();
    public IReadOnlyCollection<Movimento> NovosMovimentos => _novosMovimentos.AsReadOnly();
}
