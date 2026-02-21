using SGE.Domain.Common.ValueObjects;

namespace SGE.Domain.WhareHouse.Aggregates.Estoques;
public class Estoque
{
    public int Id { get; set; }
    public int FilialId { get; set; }

    public Descricao Descricao { get; set; } = null!;

}
