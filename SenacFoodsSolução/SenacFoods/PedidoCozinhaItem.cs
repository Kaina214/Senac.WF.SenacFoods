

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage;

namespace SenacFoods;

public class PedidoCozinhaItem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } // Identificador único do item do pedido de cozinha
    public int PedidoCozinhaId { get; set; } // Identificador do pedido de cozinha associado
    public int ComandaintemId { get; set; } // Identificador do item da comanda associado
}
