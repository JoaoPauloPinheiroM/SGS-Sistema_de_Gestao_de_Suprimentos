using SGE.Domain.Common.ValueObjects;

namespace SGE.Domain.Catalago.Aggregates.FamiliaProdutos;
public class FamiliaProduto
{
    private FamiliaProduto ( ) {}
    private FamiliaProduto ( CodigoFamilia codigo , Descricao descricao ) => ( Codigo , Descricao ) = ( codigo , descricao );

    public Guid Id { get; private set; }
    public CodigoFamilia Codigo { get; private set; } = null!;
    public Descricao Descricao { get; private set; } = null!;



    public static FamiliaProduto Create ( int valor , Descricao descricao )
    {
        var codigo = new CodigoFamilia ( valor );  
        return new FamiliaProduto ( codigo , descricao );
    }
}
