using ApiAula.Entities;
using ApiAula.Exceptions;
using ApiAula.Interfaces;

namespace ApiAula.Services
{
    public sealed class ProdutoService : IProdutoServico
    {

        private readonly List<Produto> _lista = new List<Produto>()
        {
            new Produto()
            {
                CodigoBarra = "10000001",
                Descricao = "Coca-Cola 350ml",
                Valor = 4.99m,
            }
        };

        public Produto ObterPorCodigoBarra(string codigoBarra)
        {
            var produto = _lista.FirstOrDefault(x => x.CodigoBarra == codigoBarra);

            if (produto == null)
                throw new NotFoundException("Produto não encontrado!");

            return produto;
        }

        public IEnumerable<Produto> ObterTodos() => _lista;
    }
}
