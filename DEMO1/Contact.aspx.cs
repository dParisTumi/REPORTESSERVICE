using _2_ENTIDADES;
using _4_LOGICA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEMO1
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnGuardar.Click += (s, a) =>
            {
                Alumno alumno = new Alumno();
                alumno.Nombres = txtNombres.Text;
                alumno.Apellidos = txtApellidos.Text;
                new LAlumno().guardar(alumno);
                Response.Redirect("Default.aspx");
            };
        }
    }
}