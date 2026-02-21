using SGE.Domain.Common.ValueObjects;

namespace SGE.Domain.WhareHouse.Aggregates.Transacao;
public class Transacao
{
    public int Id;
    public int RelacaoTransacaoId { get; set; }
    public CodigoTransacao Codigo { get; private set; } = null!;
    public Descricao Descricao { get; private set; } = null!;
}
