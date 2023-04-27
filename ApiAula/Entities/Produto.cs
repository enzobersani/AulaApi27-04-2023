using System.Text.Json.Serialization;

namespace ApiAula.Entities
{
    public sealed class Produto
    {
        [JsonPropertyName("id")]
        public Guid Id { get; private set; }

        [JsonPropertyName("codigoBarra")]
        public string CodigoBarra { get; set; }

        [JsonPropertyName("descrição")]
        public string Descricao { get; set;}

        [JsonPropertyName("valor")]
        public decimal Valor { get; set; }
        public Produto()
        {
            Id = Guid.NewGuid();
        }
    }
}
