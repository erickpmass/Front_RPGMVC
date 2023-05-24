using RpgMvc.Models.Enuns;

namespace RpgMvc.Models
{
    public class HabilidadesViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Dano { get; set; }
    }
}