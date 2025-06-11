using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SenacFoods
{
    public class ComandaDBContext:DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }  // conjunto de usuários
        public DbSet<Cardapiointem> CardapioItens { get; set; }// conjunto de itens do cardápio
        public DbSet<Mesa> Mesas { get; set; }// conjunto de mesas
        public DbSet<Comanda> Comandas { get; set; }// conjunto de comandas
    }
}
