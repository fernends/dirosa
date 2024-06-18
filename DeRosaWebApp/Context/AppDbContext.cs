﻿using DeRosaWebApp.Models;
using DeRosaWebApp.Models.Entities;
using DeRosaWebApp.Models.Management;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DeRosaWebApp.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Carrinho> Carrinhos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemCarrinho> ItemCarrinhos { get; set; }
        public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }
        public DbSet<Admin> Administradores { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<ManagementHome> ManagementsHome { get; set; }
        public DbSet<ManagementSobre> ManagementsSobre { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           //optionsBuilder.UseSqlServer(connectionString: @"Data Source=DESKTOP-G01SU5G;Database=DeRosaDb;Integrated Security=True; TrustServerCertificate=True");
           //optionsBuilder.UseSqlServer(connectionString: @"Server=serverderosa.database.windows.net;Database=derosa;User Id=nends;Password=Derosa123+;");
           optionsBuilder.UseSqlServer(connectionString: @"Data Source=SQL8006.site4now.net;Initial Catalog=db_aa9b15_derosa;User Id=db_aa9b15_derosa_admin;Password=derosa123");
        }                   // exemplo: connectionString: @"Data Source=DESKTOP-QG1NG7E;Database=DeRosaDb;Integrated Security=True; TrustServerCertificate=True"
    }
}