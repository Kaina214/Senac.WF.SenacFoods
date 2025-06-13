using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacFoods
{
    public class Comanda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; } // id da comanda
        public int NumeroMesa { get; set; }// número da mesa associada à comanda
        public int NomeCliente { get; set; }//  nome do cliente associado à comanda
        public int SituacaoComanda { get; set; } // 0 - aberta, 1 - fechada, 2 - cancelada
    }
}
