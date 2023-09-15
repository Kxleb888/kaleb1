using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_entidad;


namespace Capa_Datos
{
    public class ClassDatos
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_listar_estudiantes()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_estudiantes", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_buscar_estudiantes(ClassEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_estudiantes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombres", obje.nombres);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public String D_mantenmiento_estudiantes(ClassEntidad obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenmiento_estudiantes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", obje.codigo);
            cmd.Parameters.AddWithValue("@apellidos", obje.apellidos);
            cmd.Parameters.AddWithValue("@nombres", obje.nombres);
            cmd.Parameters.AddWithValue("@grado", obje.grado);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value=obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;

        }
            
    }
}
