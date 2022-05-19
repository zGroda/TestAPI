using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entidades
{
    public class Produto : EntidadeBase
    {
        [MaxLength(25)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Descricao { get; set; }
        public DateTime DataDeValidade { get; set; }
        public Marca Marca { get; set; }
        public int MarcaId { get; set; }
        public Tipo Tipo { get; set; }
        public int TipoId { get; set; }
    }
}
