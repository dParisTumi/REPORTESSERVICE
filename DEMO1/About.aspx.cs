using _4_LOGICA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEMO1
{
    public partial class About : Page
    {
        public DataSet data;
        protected void Page_Load(object sender, EventArgs e)
        {
            data = new LCurso().cargar();
            var test = data;
        }
    }
}