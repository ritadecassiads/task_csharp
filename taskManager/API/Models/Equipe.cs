namespace API.Models;
public class Equipe
{

    public int EquipeId { get; set; }
    public string? Nome { get; set; }

    public ICollection<EquipeUsuarioTarefa>? EquipeUsuarioTarefas { get; set; }
}