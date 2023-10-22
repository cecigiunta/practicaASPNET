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
        public string user { set; get; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Recupero los parametros desde el objeto session
            user = Session["usuario"] != null ? Session["usuario"].ToString() : "";
            lblUser.Text = user + " Tu ingreso fue exitoso!!";
        }
    }
}