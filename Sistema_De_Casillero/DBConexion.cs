using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Casillero
{
    class DBConexion
    {
       public SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-0LGSNJ6; Initial Catalog=Servicio_Casillero; Integrated Security= True");
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        public DataView miFiltro;

        //abrir y cerrar conexion
        public void Conectar()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la BD, " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void Consulta(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, conexion);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }
        public void ConsultaTR(string sql, ref DataSet dsPrincipal, string tabla)
        {

            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, conexion);
            cmb = new SqlCommandBuilder(da);
            da.Fill(dsPrincipal, tabla);
            da.Dispose();
            conexion.Close();
        }

        public bool Insertar(string sql)
        {
            conexion.Open();
            comando = new SqlCommand(sql, conexion);
            int i = comando.ExecuteNonQuery();
            conexion.Close();
            if (i > 0)//SI LA SENTENCIA SQL SE EJECUTA CORRECTAMENTE SE AGREGAN LOS DATOS
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Eliminar(string tabla, string condicion)
        {
            conexion.Open();
            string eliminar = "delete from " + tabla + " where " + condicion;
            comando = new SqlCommand(eliminar, conexion);
             int i = comando.ExecuteNonQuery();
            conexion.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Actualizar(string tabla, string campos, string condicion)
        {
            conexion.Open();
            string actualizar = "update " + tabla + " set " + campos + " where " + condicion;
            comando = new SqlCommand(actualizar, conexion);
            int i = comando.ExecuteNonQuery();
            conexion.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
