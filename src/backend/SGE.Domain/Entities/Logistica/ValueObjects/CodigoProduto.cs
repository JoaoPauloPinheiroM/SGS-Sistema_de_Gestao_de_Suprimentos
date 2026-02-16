
namespace SGE.Domain.Entities.Logistica.ValueObjects;

public sealed class CodigoProduto : ValueObject
{

    public int Origem { get; }
    public int Familia { get; }
    public int Sequencial { get; }

    public CodigoProduto ( int origem , int familia , int sequencial )
    {
        if (origem <= 0 || origem > 99)
            throw new ArgumentException( "Origem inválida, máximo 2 dígitos" );

        if (familia <= 0 || familia > 99)
            throw new ArgumentException( "Família inválida, máximo 2 dígitos" );

        if (sequencial <= 0 || sequencial > 9999)
            throw new ArgumentException( "Sequencial inválido, máximo 4 dígitos" );

        Origem = origem;
        Familia = familia;
        Sequencial = sequencial;
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
