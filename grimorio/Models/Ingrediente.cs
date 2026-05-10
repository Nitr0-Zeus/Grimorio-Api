namespace GrimorioDigital.Models;

public class Ingrediente
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public string Raridade { get; set; } = string.Empty; // Comum | Incomum | Raro | Lendario
    public int Quantidade { get; set; }

    // Navegação
    public ICollection<PocaoIngrediente> PocaoIngredientes { get; set; } = new List<PocaoIngrediente>();
}
