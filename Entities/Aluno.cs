using System.ComponentModel.DataAnnotations;

namespace WebIdentity.Entities;

public class Aluno
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(80, ErrorMessage = "Este campo é obrigatório")]
    public string? Nome { get; set; }

    [EmailAddress]
    [Required, MaxLength(120, ErrorMessage = "Este campo é obrigatório")]
    public string? Email { get; set; }

    public int Idade { get; set; }

    [MaxLength(80)]
    public string? Curso { get; set; }
}
