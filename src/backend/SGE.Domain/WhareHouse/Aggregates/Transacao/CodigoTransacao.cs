using SGE.Domain.Common.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.Domain.WhareHouse.Aggregates.Transacao;

public sealed class CodigoTransacao : ValueObject
{
    public string Codigo { get; } = null!;

    public CodigoTransacao ( string cod )
    {
        if (string.IsNullOrWhiteSpace( cod ))
        {
            throw new ArgumentNullException( "Codigo da transação inválido" );
        }
        Codigo = cod;
    }



    protected override IEnumerable<object> ObterComponentesDeIgualdade ( )
    {
        throw new NotImplementedException();
    }
}
