using System.Collections.Generic;
using Teste_Londrina_SA.Models;

namespace Teste_Londrina_SA.Repositorio
{
	public interface IPessoaRepositorio
	{
		PessoaModel ListarPorId(int id);
		List<PessoaModel> BuscarTodos();
		PessoaModel Adicionar(PessoaModel pessoa);
		PessoaModel Atualizar(PessoaModel pessoa);
		bool Apagar(int id);
	}
}
