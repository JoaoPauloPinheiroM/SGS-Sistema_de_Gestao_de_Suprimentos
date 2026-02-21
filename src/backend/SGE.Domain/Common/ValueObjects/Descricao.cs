namespace SGE.Domain.Common.ValueObjects;

public sealed class Descricao : ValueObject
{
    public string Value { get; private set; } = null!;


    public Descricao ( string value )
    {
        if (string.IsNullOrWhiteSpace( value ))
        {
            throw new ArgumentException( "A descrição não pode ser vazia" );
        }
    }

    protected override IEnumerable<object> ObterComponentesDeIgualdade ( )
    {
        yield return Value;
    }
}
