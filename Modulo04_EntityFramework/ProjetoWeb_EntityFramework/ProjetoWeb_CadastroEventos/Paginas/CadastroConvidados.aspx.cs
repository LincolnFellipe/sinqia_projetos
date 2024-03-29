﻿using ProjetoWeb_CadastroEventos.Dados;
using ProjetoWeb_CadastroEventos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoWeb_CadastroEventos.Paginas
{
	public partial class CadastroConvidados : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			string s = Request.RequestType;
			if (!IsPostBack)
			{

				try
				{
					eventoDropDownList.DataSource = EventosDao.ListarEventos();
					eventoDropDownList.DataTextField = "Descricao";
					eventoDropDownList.DataValueField = "Id";
					eventoDropDownList.DataBind();
				}
				catch (Exception)
				{

					throw;
				}

			}



		}

		protected void incluirButton_Click(object sender, EventArgs e)
		{
			try
			{
				Convidado  convidado = new Convidado();
				convidado.Cpf = cpfTextBox.Text;
				convidado.IdEvento = Convert.ToInt32(eventoDropDownList.SelectedValue);
				convidado.Nome = nomeTextBox.Text;
				convidado.Telefone = telefoneTextBox.Text;
				convidado.Email = emailTextBox.Text;

				ConvidadosDao.IncluirConvidado(convidado);

				mensagemLabel.ForeColor = System.Drawing.Color.Blue;
				mensagemLabel.Text = "Convidado Incluído com sucesso";





				//POST = TUDO QUE VOCE PREENCHE EM FORMULARIOS E MANDA PARA O SERVIDOR E CONSIDERADO METODO POST
				// GET = CHAMADA A URL
				// O BROWSER(NAVEGADOR) É O CLIENTE EM UMA APLICAÇÃO WEB
				// I I S = INTERNET INFORMATION SERVICES 
			}
			catch (Exception ex)
			{
				mensagemLabel.ForeColor = System.Drawing.Color.Red;
				mensagemLabel.Text = ex.Message;

			}
		}
	}
}