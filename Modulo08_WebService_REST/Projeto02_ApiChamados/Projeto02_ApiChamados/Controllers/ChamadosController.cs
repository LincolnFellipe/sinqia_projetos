using Projeto02_ApiChamados.Dados;
using Projeto02_ApiChamados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Projeto02_ApiChamados.Controllers
{
    public class ChamadosController : ApiController
    {
		// Propriedade para acessar os métodos de acesso a dados
		private ChamadosDao Dao { get; set; }
		// Construtor incluído para instanciar a classe ChamadosDao,
		// Se nenhuma instancia for encontrada
		public ChamadosController()
		{
			if (Dao == null)
			{
				Dao = new ChamadosDao();
			}
		}
		//HTTP GET - TODOS OS CHAMADOS
		public IEnumerable<Chamado> GetChamados()
		{
			return Dao.BuscarChamados();

		}

		//Http get - Chamados Pendentes
		[HttpGet]
		[Route("chamadosPendentes")]
		public IEnumerable<Chamado> GetChamadosPendentes()
		{
			return Dao.BuscarChamados().Where(p => p.Resolvido == 0);

		}


		//Http get - Chamados Resolvidos
		[HttpGet]
		[Route("chamadosResolvidos")]
		public IEnumerable<Chamado> GetChamadosResolvidos()
		{
			return Dao.BuscarChamados().Where(p => p.Resolvido == 1);

		}

		//HTTPGET - Buscar um chamado pelo Id
		[HttpGet]
		public Chamado GetChamado(int id)
		{
			return Dao.BuscarChamados().FirstOrDefault(p => p.ChamadoId == id);

		}


		// HTTP POST - Incluir um novo chamado
		public HttpResponseMessage PostChamado(Chamado chamado)
		{
			if (Dao.IncluirChamado(chamado))
			{
				var response = Request.CreateResponse<Chamado>(HttpStatusCode.Created, chamado);
				string uri = Url.Link("DefaultApi", new { id = chamado.ChamadoId });
				response.Headers.Location = new Uri(uri);

				return response;
			}
			else
			{
				var erro = new HttpResponseMessage(HttpStatusCode.BadRequest)
				{
					Content = new StringContent("Erro no serviço"),
					ReasonPhrase = "Não foi possivel incluir o chamado"

				};
				throw new HttpResponseException(erro);
			}
		}
		// HTTP DELETE - REMOVER UM CHAMADO PELO ID
		public HttpResponseMessage DeleteChamado(int id)
		{
			if (Dao.RemoverChamado(id))
			{
				var response = new HttpResponseMessage(HttpStatusCode.OK);
				string uri = Url.Link("DefaultApi", new { id });
				response.Headers.Location = new Uri(uri);

				return response;
			}
			else
			{
				var erro = new HttpResponseMessage(HttpStatusCode.BadRequest)
				{
					Content = new StringContent("Erro no serviço"),
					ReasonPhrase = "Este chamado já foi realizado"

				};
				throw new HttpResponseException(erro);
			}
		}
		//HTTP - PUT - ALTERAR UM REGISTRO

		public HttpResponseMessage PutChamado(Chamado chamado)
		{
			if (Dao.AlterarChamado(chamado))
			{
				var response = Request.CreateResponse<Chamado>(HttpStatusCode.Created, chamado);
				string uri = Url.Link("DefaultApi", new { id = chamado.ChamadoId });
				response.Headers.Location = new Uri(uri);

				return response;
			}
			else
			{
				var erro = new HttpResponseMessage(HttpStatusCode.BadRequest)
				{
					Content = new StringContent("Erro no serviço"),
					ReasonPhrase = "Não foi possivel Alterar o chamado"

				};
				throw new HttpResponseException(erro);
			}
		}


    }
}
