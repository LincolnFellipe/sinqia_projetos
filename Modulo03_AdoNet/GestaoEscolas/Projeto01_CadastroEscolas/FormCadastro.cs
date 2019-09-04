using Projeto01_CadastroEscolas.RepositoryDao;
using Projeto02_AcessoDados.DAL;
using Projeto02_AcessoDados.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto01_CadastroEscolas
{
	public partial class formCadastro : Form
	{
		public formCadastro()
		{
			InitializeComponent();
			ListarEscolas();
		}

		private void incluirEscolaButton_Click(object sender, EventArgs e)
		{
			try
			{
				Escola escola = new Escola();
				escola.Descricao = descricaoEscolaTextBox.Text;
				escola.Endereco = enderecoEscolaTextBox.Text;
				escola.Telefone = telefoneEscolaTextBox.Text;
				EscolasDao dao = Repository.GetEscolasDao();
				dao.Incluir(escola);
				MessageBox.Show("Evento incluido com sucesso");

				

				//Limpando os campos de entrada
				descricaoEscolaTextBox.Clear();
				enderecoEscolaTextBox.Clear();
				telefoneEscolaTextBox.Clear();
				


				descricaoEscolaTextBox.Focus();
				ListarEscolas();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

			}
		}
		private void ListarEscolas()
		{
			try
			{
				EscolasDao dao = Repository.GetEscolasDao();
				escolaComboBox.DataSource = dao.ListarCursosTotais();
				escolaComboBox.DisplayMember = "Descricao"; // text
				escolaComboBox.ValueMember = "Id"; // value
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				//this.Close();			
			}
		}


		private void buscarEscolaButton_Click(object sender, EventArgs e)
		{
			try
			{
				int Id = (int)escolaComboBox.SelectedValue;
				CursosDao dao = Repository.GetCursosDao();
				ListarEscolas();
				cursosDataGridView.DataSource = dao.ListarCursos(Id);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		
		}

		private void incluirCursoButton_Click(object sender, EventArgs e)
		{
			try
			{
				Curso curso = new Curso();
				CursosDao dao = Repository.GetCursosDao();

				curso.Codigo = Convert.ToInt32(codigoCursoTextBox.Text);
				curso.Descricao = descricaoCursoTextBox.Text;
				curso.CargaHoraria = Convert.ToInt32(cargahorariaCursoTextBox.Text);
				curso.Preco = Convert.ToDouble(precoTextBox.Text);
				

				// Obtendo o IDEvento a partir do combobox
				int id = (int)escolaComboBox.SelectedValue;
				curso.EscolaInfo = Repository.GetEscolasDao().Buscar(id);

				// Incluindo o convidado no banco de dados
				dao.Incluir(curso);
				if (dao.StatusInclusaoCurso == 1)
				{
					MessageBox.Show("Curso alterado com sucesso");

				}
				else
				{
					MessageBox.Show("Curso incluído com sucesso");
				}
				descricaoCursoTextBox.Clear();
				cargahorariaCursoTextBox.Clear();
				precoTextBox.Clear();
				codigoCursoTextBox.Clear();
				codigoCursoTextBox.Focus();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buscarCodigoButton_Click(object sender, EventArgs e)
		{
		
		}
		private void buscarcurso(Curso chave) {
			Curso curso = new Curso();
			CursosDao dao = Repository.GetCursosDao();
			try
			{
				if (dao.StatusInclusaoCurso == 1)
				{
					descricaoCursoTextBox.Text = curso.Descricao;
					//cargahorariaCursoTextBox.Text = Convert.ToInt32(curso.CargaHoraria);
					//precoTextBox.Text = (double)curso.Preco;

				}
				


			}
			catch (Exception ex)
			{
				MessageBox.Show("O curso não existe!");

			}

		}
		


	}
	}

