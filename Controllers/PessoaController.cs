using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Teste_Londrina_SA.Models;
using Teste_Londrina_SA.Repositorio;

namespace Teste_Londrina_SA.Controllers
{
	public class PessoaController : Controller
	{
		private readonly IPessoaRepositorio _pessoaRepositorio;
		public PessoaController(IPessoaRepositorio pessoaRepositorio)
		{
			_pessoaRepositorio = pessoaRepositorio;
		}
		public IActionResult Index()
		{
			List<PessoaModel> pessoa = _pessoaRepositorio.BuscarTodos();

			return View(pessoa);
		}
		public IActionResult Criar()
		{
			return View();
		}
		public IActionResult Editar(int Id)
		{
			PessoaModel pessoa =_pessoaRepositorio.ListarPorId(Id);
			return View(pessoa);
		}
		public IActionResult DeletarConfirmacao(int Id)
		{
			PessoaModel pessoa = _pessoaRepositorio.ListarPorId(Id);
			return View(pessoa);
		}
		public IActionResult Deletar(int Id)
		{
			_pessoaRepositorio.Apagar(Id);
			return RedirectToAction("Index");
		}

		[HttpPost]
		public IActionResult Criar(PessoaModel pessoa) 
		{
			if (ModelState.IsValid)
			{
				_pessoaRepositorio.Adicionar(pessoa);
				return RedirectToAction("Index");
			}
			return View(pessoa);
		}
		[HttpPost]
		public IActionResult Editar(PessoaModel pessoa)
		{
			_pessoaRepositorio.Atualizar(pessoa);
			return RedirectToAction("Index");
		}



	}
}
