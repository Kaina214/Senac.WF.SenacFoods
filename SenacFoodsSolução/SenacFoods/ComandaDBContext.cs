using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SenacFoods;

public class ComandaDBContext:DbContext
{
    //colar em baixo
    public ComandaDBContext() : base()
    {
        
    }

    // conexao com o banco de dados
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var conexao = "Server=localhost;Database=senacfoods;User=root;Password=";
        optionsBuilder.UseMySql(conexao , ServerVersion.AutoDetect(conexao));
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Usuario> Usuarios { get; set; }  // conjunto de usuários
    public DbSet<Cardapiointem> CardapioItens { get; set; }// conjunto de itens do cardápio
    public DbSet<Mesa> Mesas { get; set; }// conjunto de mesas
    public DbSet<Comanda> Comandas { get; set; }// conjunto de comandas
    public DbSet<Comandaitem> ComandaItens { get; set; } // conjunto de itens da comanda
    public DbSet<PedidoCozinha> PedidosCozinha { get; set; } // conjunto de pedidos da cozinha
    public DbSet<PedidoCozinhaItem> PedidosCozinhaItems { get; set; }// conjunto de itens dos pedidos da cozinha
}
