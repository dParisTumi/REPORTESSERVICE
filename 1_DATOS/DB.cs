using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//IMPORTAMOS LOS ESPACIOS DE NOMBRES
using System.Data; //DATASETS
using System.Data.SqlClient; //PROVIDER ADO.NET
using System.Configuration;
using System.Diagnostics.Contracts;
using System.CodeDom; //WEBCONFIG

namespace _1_DATOS
{
    public class DB
    {
        private string cadena;
        private SqlConnection cn; //conexión
        private SqlCommand cm; //consulta sql, procedimiento almacenado
        private DataSet ds; //conj de datos
        private SqlDataAdapter adp; //adaptador de consulta (select)

        public DB()
        {
            cadena = ConfigurationManager.ConnectionStrings["cadena"].ToString();
            //cadena = "";
            cn = new SqlConnection(cadena);
        }

        public DataSet EjecutarDS(List<SqlParameter> param, string sql)
        {
            cm = new SqlCommand(sql,cn);
            foreach (var item in param)
            {
                cm.Parameters.Add(item);
            }
            ds = new DataSet();
            adp = new SqlDataAdapter(cm);
            adp.Fill(ds);
            return ds;
        }
        public void EjecutarOperacion(List<SqlParameter> param, string sql)
        {
            cm = new SqlCommand(sql,cn);
            foreach (var item in param)
            {
                cm.Parameters.Add(item);
            }
            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();
        }
    }
}
