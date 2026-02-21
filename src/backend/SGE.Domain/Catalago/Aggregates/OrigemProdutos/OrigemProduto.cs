namespace SGE.Domain.Catalago.Aggregates.OrigemProdutos;
public class OrigemProduto
{
    private OrigemProduto ( ) { }
    private OrigemProduto ( CodigoOrigem codigo , TipoOrigem tipoOrigem ) => ( Codigo , TipoOrigem ) = ( codigo , tipoOrigem );
    public Guid Id { get; private set; }
    public CodigoOrigem Codigo { get; private set; } = null!;
    public TipoOrigem TipoOrigem { get; private set; }

    public static OrigemProduto Create ( int valor , TipoOrigem tipoOrigem )
    {
        var codigo = new CodigoOrigem ( valor );
        return new OrigemProduto ( codigo , tipoOrigem );
    }

}
