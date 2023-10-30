using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerWebASP
{
    public partial class AutoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dropColor.Items.Add("Negro");
            dropColor.Items.Add("Blanco");
            dropColor.Items.Add("Rojo");





        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //Creo un nuevo objeto Auto con los datos del Form
            Auto a = new Auto();
            a.Id = int.Parse(txtId.Text);
            a.Modelo = txtModelo.Text;
            a.Color = dropColor.SelectedValue;
            a.Usado = chkUsado.Checked;

            // ej fecha: a.Fecha = DateTime.Parse(txtFecha.Text);

            // ej RADIO BUTTON: if(radioImportado.Checked)
            //  a.importado = true 
            //else if if(radioNacional.Checked)
            // a.importado = false


            //Ahora, como tengo mi objeto creado, tengo que recuperar mi lista de la sesión para poder agregarle un elem
            //FORMA MAS REBUSCADA -> ((List<Auto>)Session["listaAutos"]).Add(a);

            //Forrma mas facil de entender
            //Me creo una lista temporal y le asigno la lista obtenida y transformada
            //Como el session devuelve un object, lo tengo que transformar a Lista de Autos
            List<Auto> temporal = (List<Auto>)Session["listaAutos"];
            temporal.Add(a);

            Response.Redirect("Default.aspx");

        }
    }
}