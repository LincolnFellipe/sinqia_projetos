using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_AcessoDados.DAL
{
	public abstract class Dao<T,K>
	{
		public Dao()
		{
			cn = new SqlConnection(conexao);
			cmd = new SqlCommand();
			cmd.Connection = cn;
			adapter = new SqlDataAdapter();
		}

		private string conexao = "Password=Imp@ct@;Persist Security Info=False;User ID=sa;Initial Catalog=DB_ESCOLA;Data Source=.";

		protected SqlConnection cn;
		protected SqlCommand cmd;
		protected SqlDataReader reader; // modo conectado
		protected SqlDataAdapter adapter; // modo desconectado

		protected void AbrirConexao()
		{
			cn.Open();

		}


		protected void FecharConexao()
		{
			if (cn != null && cn.State == ConnectionState.Open)
			{
				cn.Close();
			}
			}
		public abstract void Incluir(T elemento);
		public abstract T Buscar(K chave);
		public abstract IEnumerable<T> ListarCursosTotais(int id = 0);

	}
}
