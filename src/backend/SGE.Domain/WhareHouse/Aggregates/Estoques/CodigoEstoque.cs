using SGE.Domain.Common.ValueObjects;

namespace SGE.Domain.WhareHouse.Aggregates.Estoques;

public class CodigoEstoque : ValueObject
{
    public string Valor { get; private set; }



    protected override IEnumerable<object> ObterComponentesDeIgualdade ( )
    {
        throw new NotImplementedException();
    }
}
