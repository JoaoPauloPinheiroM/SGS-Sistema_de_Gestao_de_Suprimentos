
using SGE.Domain.Catalago.Aggregates.Produto;
using SGE.Domain.Organizacao.Aggregates.Empresa;
using SGE.Domain.Organizacao.Aggregates.Filial;

namespace SGE.Domain.Services.DomainServices;

public interface IInativacaoProdutoService
{
    public void ValidarInativacao (Produto produto );
}
