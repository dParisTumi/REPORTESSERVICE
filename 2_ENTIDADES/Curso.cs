using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ENTIDADES
{
    public class Curso
    {
        public int IdCurso {  get; set; }
        public string Nombre { get; set; }
        public int Tipo { get; set; }
        public int Ciclo {  get; set; }
        public int Creditos { get; set; }
    }
}
