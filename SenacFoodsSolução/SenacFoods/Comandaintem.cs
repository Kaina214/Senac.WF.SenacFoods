
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SenacFoods;

public class Comandaitem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } // Identificador único do item da comanda
    public int CardapioItemId { get; set; } // Identificador do item do cardápio associado
    public int ComandaId { get; set; } // Identificador da comanda associada

  
    
}
