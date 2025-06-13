using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SenacFoods;

public class PedidoCozinha
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } // Identificador único do pedido de cozinha
    public int ComandaId { get; set; } // Identificador da comanda associada ao pedido
     public int SituacaoId { get; set; } // Situação do pedido (0 - Pendente, 1 - Em preparo, 2 - Pronto, 3 - Entregue)
}

