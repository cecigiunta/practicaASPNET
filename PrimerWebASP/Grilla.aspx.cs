using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerWebASP
{
    public partial class Grilla : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Primero, voy a preguntar si la lista no existe
            if (Session["listaAutos"] == null)
            {
                AutoNegocio negocio = new AutoNegocio();

                //Como la grilla no está en memoria, no puedo agregarle cosas como si estuviera.
                //Por eso, la tengo que guardar en Session
                Session.Add("listaAutos", negocio.listar()); 
            }

            //Entonces, ahora que existe, se la asigno al DataSource
            dgvAutos.DataSource = Session["listaAutos"];
            dgvAutos.DataBind();
        }
    }
}