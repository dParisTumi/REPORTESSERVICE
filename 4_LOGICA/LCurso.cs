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
    public class LCurso : ICurso
    {
        public void borrar(Curso curso)
        {

        }

        public DataSet cargar()
        {
            List<SqlParameter> param = new List<SqlParameter>();
            string sql = "SELECT * FROM CURSO";
            DB db = new DB();
            return db.EjecutarDS(param, sql);
        }

        public void guardar(Curso curso)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@NOM", curso.Nombre));
            parameters.Add(new SqlParameter("@TIPO", curso.Tipo));
            parameters.Add(new SqlParameter("@CICLO", curso.Ciclo));
            parameters.Add(new SqlParameter("@CREDITOS", curso.Creditos));
            string sql = "INSERT INTO CURSO(NOMBRE,TIPO,CICLO,CREDITOS) VALUES(@NOM,@TIPO,@CICLO,@CREDITOS)";
            DB dB = new DB();
            dB.EjecutarOperacion(parameters, sql);
        }

        public void modificar(Curso curso)
        {
            throw new NotImplementedException();
        }
    }
}
