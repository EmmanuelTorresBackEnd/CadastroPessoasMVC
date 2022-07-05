using System.Collections.Generic;
using System.Linq;
using Teste_Londrina_SA.Data;
using Teste_Londrina_SA.Models;

namespace Teste_Londrina_SA.Repositorio
{
	public class PessoaRepositorio : IPessoaRepositorio
	{
		private readonly BancoContext _bancoContext;
		public PessoaRepositorio(BancoContext bancoContext)
		{
			_bancoContext = bancoContext;
		}
		public PessoaModel ListarPorId(int id)
		{
			return _bancoContext.pessoa.FirstOrDefault(x => x.Id == id);
		}
		public List<PessoaModel> BuscarTodos()
		{
			return _bancoContext.pessoa.ToList();
		}
		public PessoaModel Atualizar(PessoaModel pessoa)
		{
			PessoaModel pessoaDB = ListarPorId(pessoa.Id);

			if (pessoaDB == null) throw new System.Exception("Ocorreu um erro ao Atualizar");

			pessoaDB.Nome = pessoa.Nome;
			pessoaDB.Telefone = pessoa.Telefone;
			pessoaDB.Email = pessoa.Email;

			_bancoContext.pessoa.Update(pessoaDB);
			_bancoContext.SaveChanges();

			return pessoaDB;
		}

		public PessoaModel Adicionar(PessoaModel pessoa)
		{
			_bancoContext.pessoa.Add(pessoa);
			_bancoContext.SaveChanges();

			return pessoa;
		}

		public bool Apagar(int Id)
		{
			PessoaModel pessoaDB = ListarPorId(Id);

			if (pessoaDB == null) throw new System.Exception("Houve um erro ao Deletar o Imovel");
			_bancoContext.pessoa.Remove(pessoaDB);
			_bancoContext.SaveChanges();

			return true;
		}
	}

}
