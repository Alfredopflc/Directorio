using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DirectorioTelefonico
{
    public partial class Index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["userlogeado"] != null)
            {
                string userlogeado = Session["userlogeado"].ToString();
                lblBienvenida.Text = "Bienvenido/a " + userlogeado;            
            }

            else
                Response.Redirect("Login.aspx");             
                       
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            Session.Remove("userlogeado");
            Response.Redirect("Login.aspx");                   
        }
    }
}