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
            string password = txtPassword.Text;

            //Para enviar parámetros entre paginas, los guardo en el objeto SESIÓN
            //Una vez que se les agrega, lo vamos a poder recuperar estos datos desde CUALQUIER PAGINA haciendo referencia al nombre
            Session.Add("usuario", nombre);
            Session.Add("pass", password);


            Response.Redirect("Default.aspx", false);


        }

    }
}