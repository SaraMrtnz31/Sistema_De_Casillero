using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Casillero
{
    public class ComboBox
    {
        DBConexion con = new DBConexion();
        SqlDataAdapter adap;
        DataTable data;

        public DataTable CargarComboCategoria()
        {
            adap = new SqlDataAdapter("SP_CargarCBO", con.conexion);
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            data = new DataTable();
            adap.Fill(data);
            return data;
        }

        public DataTable CargarComboRol()
        {
            adap = new SqlDataAdapter("SP_CargarCBO", con.conexion);
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            data = new DataTable();
            adap.Fill(data);
            return data;
        }

        public DataTable CargarComboCargo()
        {
            adap = new SqlDataAdapter("SP_CargarCBO", con.conexion);
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            data = new DataTable();
            adap.Fill(data);
            return data;
        }
    }
}
