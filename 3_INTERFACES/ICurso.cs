using _2_ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_INTERFACES
{
    public interface ICurso
    {
        void guardar(Curso curso);
        void modificar(Curso curso);
        void borrar(Curso curso);
        DataSet cargar();
    }
}
