using Projeto02_AcessoDados.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_AcessoDados.DAL
{
	public class CursosDao : Dao<Curso, string>
	{
		public override Curso Buscar(string chave)
		{
			Curso curso = new Curso();
			try
			{
				return curso;
			}
			catch (Exception)
			{

				throw;
			}
			
			/*try
			{
				AbrirConexao();
				Curso busca = new Curso();
				if 


			}
			catch (Exception)
			{

				throw;
			}
			finally {
				FecharConexao();

			}
			*/

		}
		public int StatusInclusaoCurso { get; set; }
		public override void Incluir(Curso elemento)
		{
			try
			{
				AbrirConexao();
				cmd.CommandText = "pr_incluir_curso";
				cmd.CommandType = CommandType.StoredProcedure;


				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@codigo", elemento.Codigo);
				cmd.Parameters.AddWithValue("@idescola", elemento.EscolaInfo.Id);
				cmd.Parameters.AddWithValue("@descricao", elemento.Descricao);
				cmd.Parameters.AddWithValue("@cargahoraria", elemento.CargaHoraria);
				cmd.Parameters.AddWithValue("@preco", elemento.Preco);

				//Parâmetro de saída
				SqlParameter parameter = new SqlParameter();
				parameter.ParameterName = "@status";
				parameter.SqlDbType = SqlDbType.Int;
				parameter.Direction = ParameterDirection.Output;
				cmd.Parameters.Add(parameter);

				cmd.ExecuteNonQuery();
				int status = (int)parameter.Value;
				StatusInclusaoCurso = status;
			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				FecharConexao();
			}
		
	}
		public DataTable ListarCursos(int id)
		{
			DataTable table = new DataTable();
			try
			{
				AbrirConexao();

				string sql = " SELECT C.Codigo, C.Descricao, C.CargaHoraria, C.Preco" +
					" FROM TBCursos C, TBEscolas E WHERE" +
					" C.IdEscola = E.Id AND C.IdEscola = " + id;

				cmd.CommandText = sql;
				cmd.CommandType = CommandType.Text;
				adapter.SelectCommand = cmd;
				adapter.Fill(table);

			}
			catch (Exception)
			{

				throw;
			}
			finally
			{

				FecharConexao();

			}

						return table;
		}
		public override IEnumerable<Curso> ListarCursosTotais(int id = 0)
		{
			List<Curso> cursos = new List<Curso>();

			try
			{
				if (id < 0)
				{
					throw new Exception("Não é permitido parâmetro negativo");
				}

				AbrirConexao();
				string sql = " SELECT * FROM TBCursos";
				if (id > 0)
				{
					sql += " WHERE IdEscola = @IdEscola";
					cmd.Parameters.Clear();
					cmd.Parameters.AddWithValue("@IdEscola", id);
				}
				cmd.CommandText = sql;
				cmd.CommandType = CommandType.Text;
				reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					Curso c = new Curso();
					c.Codigo = (int)reader["Codigo"];
					c.Descricao = (string)reader["Descricao"];
					c.CargaHoraria = (int)reader["CargaHoraria"];
					c.Preco = (float)reader["Preco"];
					c.EscolaInfo = new EscolasDao().Buscar((int)reader["IdEscola"]);
					cursos.Add(c);


				}


			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				FecharConexao();
			}

			return cursos;
		}
	}
}
	

