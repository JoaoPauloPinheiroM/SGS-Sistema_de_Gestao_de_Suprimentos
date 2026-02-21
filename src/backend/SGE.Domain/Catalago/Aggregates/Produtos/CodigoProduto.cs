using SGE.Domain.Catalago.Aggregates.FamiliaProdutos;
using SGE.Domain.Catalago.Aggregates.OrigemProdutos;
using SGE.Domain.Common.ValueObjects;

namespace SGE.Domain.Catalago.Aggregates.Produtos;

public sealed class CodigoProduto : ValueObject
{
    private CodigoProduto ( ){}
    private CodigoProduto ( int origem , int familia , int sequencial ) =>( Origem , Familia , Sequencial ) = ( origem , familia , sequencial );
    public int Origem { get; }
    public int Familia { get; }
    public int Sequencial { get; }

    public static CodigoProduto Create ( 
        CodigoOrigem origem,
        CodigoFamilia familia,
        int sequencial )
    {
        if (sequencial <= 0 || sequencial > 9999)
            throw new ArgumentException( "Sequencial inválido." );

        return new CodigoProduto(
            origem.Valor ,
            familia.Valor ,
            sequencial );
    }

    public override string ToString ( )
    => $"{Origem:D2}{Familia:D2}.{Sequencial:D4}";

    protected override IEnumerable<object> ObterComponentesDeIgualdade ( )
    {
        yield return Origem;
        yield return Familia;
        yield return Sequencial;
    }
}
