using AcessoDadosClassLibrary;
using AplicacaoClassLibrary.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoClassLibrary.Dados
{
    public class UsuarioDados
    {
        internal int CriaUsuario(Usuario usuario) {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Sua Procedure aqui";
            //aqui vem os seus parametros
            command.Parameters.Add(Dao.RetornaDbParameter("V_ID_USUARIO", usuario.Id, DbType.Int32, 0, ParameterDirection.Input));
            command.Parameters.Add(Dao.RetornaDbParameter("V_ID_PERFIL", null, DbType.Int32, 9999, ParameterDirection.Output));
            command.CommandType = CommandType.StoredProcedure;
            Dao.ExecutaProcedure(command);
            int id = Convert.ToInt32(command.Parameters["V_ID_PERFIL"].Value.ToString());

            return id;
        }
    }
}
