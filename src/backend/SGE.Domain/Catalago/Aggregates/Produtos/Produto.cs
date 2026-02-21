using SGE.Domain.Catalago.Aggregates.FamiliaProdutos;
using SGE.Domain.Catalago.Aggregates.OrigemProdutos;
namespace SGE.Domain.Catalago.Aggregates.Produtos;
public class Produto
{
    private Produto ( ) { }
    private Produto ( OrigemProduto origem , FamiliaProduto familia , CodigoProduto codigo ) => ( OrigemId , FamiliaId , Codigo ) = ( origem.Id , familia.Id , codigo );
    public Guid OrigemId { get; private set; }
    public Guid FamiliaId { get; private set; }
    public Guid Id { get; private set; }
    public CodigoProduto Codigo { get; private set; } = null!;
    public bool Status { get; private set; } = true;

    public static Produto Create ( OrigemProduto origem , FamiliaProduto familia , int sequencial )
    {
        var codigo = CodigoProduto.Create(
            origem.Codigo,
            familia.Codigo,
            sequencial );

        return new Produto( origem , familia , codigo );
    }

    public void AlterarStatus ( )
    {
        Status = !Status;
    }
}
