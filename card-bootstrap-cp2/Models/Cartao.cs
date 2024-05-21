using System.ComponentModel.DataAnnotations;

namespace card_bootstrap_cp2.Models;

public class Cartao
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Nome { get; set; }
}