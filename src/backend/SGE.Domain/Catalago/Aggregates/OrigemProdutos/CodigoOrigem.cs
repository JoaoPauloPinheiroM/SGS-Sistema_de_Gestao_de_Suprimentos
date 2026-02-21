using SGE.Domain.Common.ValueObjects;
namespace SGE.Domain.Catalago.Aggregates.OrigemProdutos;
public sealed class CodigoOrigem : ValueObject
{
    public int Valor { get; }
    public CodigoOrigem ( int valor )
    {
        if (valor <= 0 || valor > 99)
            throw new ArgumentException( "Código de origem inválido, máximo 2 dígitos" );
        Valor = valor;
    }
    public override string ToString ( )
    => $"{Valor:D2}";

    protected override IEnumerable<object> ObterComponentesDeIgualdade ( )
    {
        yield return Valor;
    }
}
