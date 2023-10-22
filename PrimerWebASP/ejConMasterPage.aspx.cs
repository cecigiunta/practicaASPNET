using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerWebASP
{
    public partial class ejConMasterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //MANEJAR POSTBACK
            if (!IsPostBack)
            {
                txtNombre.Text = "";

            }

        }

        protected void saludar(object sender, EventArgs e)
        {
            //Se creo automaticamente cuando le di click a la lista de eventos del controlador aspx

            string nombre = txtNombre.Text;
            LabelSaludo.Text = "Hola " + nombre;

            //Para navegar. Response es un objeto de Page, es una propertie
            //Se le agrega un "false" porque suele tirar una excepcion(thread abort exception) y cortar el hilo de ejecucion
            //para evitarlo usamos el false

            //PASARLE PARÁMETROS POR URL - query string
            Response.Redirect("Default.aspx?nombre=" + nombre , false);
        }

        protected void textChanged(object sender, EventArgs e)
        {
            Label2.Text = "El texto cambio";
        }
    }
}