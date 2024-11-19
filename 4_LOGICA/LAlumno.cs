using _1_DATOS;
using _2_ENTIDADES;
using _3_INTERFACES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_LOGICA
{
    public class LAlumno : IAlumno
    {
        public void borrar(Alumno alumno)
        {
            
        }

        public DataSet cargar()
        {
            List<SqlParameter> param=new List<SqlParameter>();
            string sql = "SELECT * FROM ALUMNO";
            DB db = new DB();
            return db.EjecutarDS(param, sql);
        }

        public void guardar(Alumno alumno)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@NOM", alumno.Nombres));
            param.Add(new SqlParameter("@APE", alumno.Apellidos));
            string sql = "INSERT INTO ALUMNO (NOMBRES, APELLIDOS) VALUES (@NOM, @APE)";
            DB dB = new DB();
            dB.EjecutarOperacion(param, sql);

        }

        public void modificar(Alumno alumno)
        {
            
        }
    }
}
