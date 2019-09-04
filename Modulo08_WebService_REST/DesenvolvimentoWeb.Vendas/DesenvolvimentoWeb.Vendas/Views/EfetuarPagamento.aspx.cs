using DesenvolvimentoWeb.Vendas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesenvolvimentoWeb.Vendas.Views
{
	public partial class EfetuarPagamento : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				pedidosDropDownList.DataSource = PedidosDao.ListarPedidosVM();
				pedidosDropDownList.DataTextField = "NomeCliente";
				pedidosDropDownList.DataValueField = "NumeroPedido";
				pedidosDropDownList.DataBind();

			}
		}

		protected void pagamentoButton_Click(object sender, EventArgs e)
		{
			try
			{
				// Obtendo o número do pedido
				string numPedido = pedidosDropDownList.SelectedValue;
				//Obtendo o total de itens para o pedido selecionado
				double totalPedido = ItensDao.ListarItensPorPedido(numPedido).Sum(p => p.ValorTotalItem);
				// Obtendo o número do cartão
				string cartao = cartaoTextBox.Text;
				//Instanciando a classe PagamentoContract obtida através do servico
				ServiceProxy.PagamentoContract pagamento = new ServiceProxy.PagamentoContract();
				pagamento.NumeroCartao = cartao;
				pagamento.NumeroPedido = numPedido;
				pagamento.Valor = totalPedido;
				//Instanciando a classe ServicePagamentoCliente, obtida através do webservice
				ServiceProxy.ServicePagamentosClient service = new ServiceProxy.ServicePagamentosClient();
				int resposta = service.EfetuarPagamento(pagamento);

				switch (resposta)
				{
					case 1: throw new Exception("Este cartão não existe");
					case 2: throw new Exception("Este pedido já foi pago");
					case 3: throw new Exception("Não há limite disponível no cartão");
				}


				mensagemLabel.CssClass = "text text-sucess";
				mensagemLabel.Text = "Pedido<strong>" + numPedido + "</strong> pago com sucesso.";
			}
			catch (Exception ex)
			{
				mensagemLabel.CssClass = "text text-danger";
				mensagemLabel.Text = ex.Message;
				
			}
		}
	}
}