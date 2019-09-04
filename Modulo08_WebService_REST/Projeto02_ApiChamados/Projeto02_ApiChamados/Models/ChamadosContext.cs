using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projeto02_ApiChamados.Models
{
	public class ChamadosContext : DbContext
	{
		//Estabelecendo a conexão com o banco enviando a string de conexao para a superclasse
		public ChamadosContext() : base("name=ChamadosConnection")
		{

		}
		//Definimos a coleção (DBSet) 

		public DbSet<Chamado> Chamados { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			// Definindo o nome da tabela a ser zerada!
			modelBuilder.Entity<Chamado>().ToTable("TBChamados");
			// Definindo paramêtros dos campos
			modelBuilder.Entity<Chamado>().Property(p => p.Data).IsRequired();
			modelBuilder.Entity<Chamado>().Property(p => p.Documento).HasMaxLength(14).IsRequired();
			modelBuilder.Entity<Chamado>().Property(p => p.Assunto).HasMaxLength(20).IsRequired();
			modelBuilder.Entity<Chamado>().Property(p => p.Descricao).HasMaxLength(100).IsRequired();
			modelBuilder.Entity<Chamado>().Property(p => p.Resposta).HasMaxLength(100);
			modelBuilder.Entity<Chamado>().Property(p => p.Resolvido).IsRequired();




		}
	}
}