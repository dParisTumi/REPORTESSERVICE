using _2_ENTIDADES;
using _4_LOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEMO1
{
    public partial class CursoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnGuardar.Click += (s, a) =>
            {
                Curso curso = new Curso();
                curso.Nombre = txtNombre.Text;
                curso.Tipo = int.Parse( txtTipo.Text);
                curso.Ciclo = int.Parse( txtCiclo.Text);
                curso.Creditos = int.Parse(txtCreditos.Text);
                new LCurso().guardar(curso);
                Response.Redirect("CursoForm.aspx");
            };
        }
    }
}