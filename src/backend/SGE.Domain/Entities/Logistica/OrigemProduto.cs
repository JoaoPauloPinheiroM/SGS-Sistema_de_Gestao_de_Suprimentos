using SGE.Domain.Entities.Logistica.Enums;

namespace SGE.Domain.Entities.Logistica;

public class OrigemProduto
{
    public int Id { get; private set; }
    public int Codigo { get; private set; }
    public TipoOrigem TipoOrigem { get; private set; }

}
