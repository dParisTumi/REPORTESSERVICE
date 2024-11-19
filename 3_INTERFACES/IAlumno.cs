using _2_ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_INTERFACES
{
    public interface IAlumno
    {
        void guardar(Alumno alumno);
        void modificar(Alumno alumno);
        void borrar(Alumno alumno);
        DataSet cargar();
    }
}
