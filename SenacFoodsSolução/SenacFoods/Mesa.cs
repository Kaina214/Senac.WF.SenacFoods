using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacFoods
{
    public class Mesa
    {
       
        public int Id { get; set; }
        public int NumeroMesa { get; set; }
        // 0 - disponível 1 - ocupado , 2 - reservado
        public bool SituacaoMesa { get; set; }

    }
}
