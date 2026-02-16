using SGE.Domain.Entities.Logistica.ValueObjects;

namespace SGE.Domain.Entities.Logistica;

public class Produto
{
    public int OrigemId { get; private set; }
    public int FamiliaId { get; private set; }
    public int Id { get; private set; }
    public int Sequencial { get; private set; }
    public CodigoProduto Codigo { get; private set; } = null!;


}
