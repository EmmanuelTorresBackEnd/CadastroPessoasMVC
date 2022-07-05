using Microsoft.EntityFrameworkCore;
using Teste_Londrina_SA.Models;

namespace Teste_Londrina_SA.Data
{
	public class BancoContext : DbContext
	{
		public BancoContext(DbContextOptions<BancoContext> options) : base(options)
		{
		}
		public DbSet<PessoaModel> pessoa { get; set; }
	}
}
