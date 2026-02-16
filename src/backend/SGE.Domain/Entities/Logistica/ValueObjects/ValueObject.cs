namespace SGE.Domain.Entities.Logistica.ValueObjects;

public abstract class ValueObject
{
    protected abstract IEnumerable<object> ObterComponentesDeIgualdade ( );

    public override bool Equals ( object? obj )
    {
        if (obj == null || obj.GetType() != GetType())
            return false;

        var outro = (ValueObject)obj;

        return ObterComponentesDeIgualdade()
            .SequenceEqual( outro.ObterComponentesDeIgualdade() );
    }

    public override int GetHashCode ( )
    {
        return ObterComponentesDeIgualdade()
        .Aggregate( 1 , ( atual , objeto ) =>
        {
            unchecked
            {
                return atual * 23 + (objeto?.GetHashCode() ?? 0);
            }
        });
    }
}
