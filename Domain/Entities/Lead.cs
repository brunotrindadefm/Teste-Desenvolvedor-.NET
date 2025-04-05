using System.Collections.Generic;

namespace Domain.Entities
{
    public class Lead
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public ICollection<Inscricao> Inscricoes { get; set; }
    }
}
