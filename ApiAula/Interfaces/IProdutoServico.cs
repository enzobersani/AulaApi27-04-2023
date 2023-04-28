using ApiAula.Entities;

namespace ApiAula.Interfaces
{
    public interface IProdutoServico
    {
        IEnumerable<Produto> ObterTodos();
        Produto ObterPorCodigoBarra(string codigoBarra);
    }
}
