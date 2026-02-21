using SGE.Domain.Common.ValueObjects;
namespace SGE.Domain.Catalago.Aggregates.FamiliaProdutos;
public sealed class CodigoFamilia : ValueObject
{
    public int Valor { get; }
    public CodigoFamilia ( int valor )
    {
        if (valor <= 0 || valor > 99)
            throw new ArgumentException( "Código de família inválido, máximo 2 dígitos" );
        Valor = valor;
    }
    public override string ToString ( )
    => $"{Valor:D2}";

    protected override IEnumerable<object> ObterComponentesDeIgualdade ( )
    {
        yield return Valor;
    }
}
