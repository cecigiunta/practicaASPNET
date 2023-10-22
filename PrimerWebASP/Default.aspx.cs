using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerWebASP
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //En el Load de la página DEfault, capturamos el valor
            //Dentro del corchete, va el parámetro tal cual como lo puse en la URL
            //Devuelve un object, así que le tengo que hacer .ToString

            //Uso operador TERNARIO para validar que no sea null
            string user = Request.QueryString["nombre"] != null ? Request.QueryString["nombre"].ToString() : "Logueate!!";
            lblUser.Text = user + "Tu ingreso fue exitoso!!";
        }
    }
}