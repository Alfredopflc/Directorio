using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DirectorioTelefonico
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        string patron = "V9828";
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string conectar = ConfigurationManager.ConnectionStrings["conex"].ConnectionString;
            SqlConnection sqlConectar = new SqlConnection(conectar);       
            SqlCommand cmd = new SqlCommand("ValidarUser", sqlConectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Connection.Open();
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = tbUsuario.Text;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = tbPassword.Text;
            cmd.Parameters.Add("@Patron", SqlDbType.VarChar, 50).Value = patron;
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                Session["userlogeado"] = tbUsuario.Text;
                Response.Redirect("Index.aspx");
            }

            else
                lblError.Text = "ERROR: Usuario o contraseña incorrectos";

            cmd.Connection.Close();

        }
    }
}