using System.Collections.Generic;

namespace Domain.Entities
{
    public class Oferta
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Descricao { get; set; }
        public int VagasDisponiveis { get; set; }
        public ICollection<Inscricao> Inscricoes { get; set; }
    }
}
