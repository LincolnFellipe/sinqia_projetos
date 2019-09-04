using DesenvolvimentoWeb.Vendas.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesenvolvimentoWeb.Vendas.Views
{
	public partial class ChamadosResolvidos : System.Web.UI.Page
	{
		HttpClient client;
		static Chamado chamado;
		public  void ResponderChamado()
		{
			if (client == null)
			{
				client = new HttpClient();
				client.BaseAddress = new Uri("http://localhost:52091/");
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			}
		}
		protected async void ListarChamados()
		{
			HttpResponseMessage response = client.GetAsync("chamadosPendentes").Result;

			var resultado = await response.Content.ReadAsStringAsync();

			var lista = JsonConvert.DeserializeObject<Chamado[]>(resultado).ToList();
			chamado = JsonConvert.DeserializeObject<Chamado>(resultado);
			IdChamadoDropDownList.DataSource = lista;
			IdChamadoDropDownList.DataTextField = "ChamadoId";
			IdChamadoDropDownList.DataValueField = "ChamadoId";
			IdChamadoDropDownList.DataBind();
			
		}
		protected async void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				try
				{
					
					HttpResponseMessage response = client.GetAsync("chamadosResolvidos").Result;
					var resultado = await response.Content.ReadAsStringAsync();
					var lista = JsonConvert.DeserializeObject<Chamado[]>(resultado).ToList();
					
					if (response.IsSuccessStatusCode)
					{
						
						IdChamadoDropDownList.DataSource = lista;
						IdChamadoDropDownList.DataTextField = "Descricao";
						IdChamadoDropDownList.DataValueField = "ChamadoId";
						IdChamadoDropDownList.DataBind();
						
					}
				}
				catch
				{
					throw;
				}
			}
		}

		protected void IdChamadoDropDownList_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}