using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DirectorioTelefonico.Pages
{
    public partial class Index : System.Web.UI.Page
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogeado"] != null)
            {
                string userlogeado = Session["userlogeado"].ToString();
            }

            else
                Response.Redirect("Login.aspx");

            CargarTabla();
        }

        void CargarTabla()
        {
            SqlCommand cmd = new SqlCommand("contacto_read", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvusuarios.DataSource = dt;
            gvusuarios.DataBind();
            con.Close();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/CRUD.aspx?op=C");
        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            string id;
            Button btnConsultar = (Button)sender;
            GridViewRow selectdrow = (GridViewRow)btnConsultar.NamingContainer;
            id = selectdrow.Cells[1].Text;
            Response.Redirect("~/Pages/CRUD.aspx?id="+id+"&op=R");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string id;
            Button btnConsultar = (Button)sender;
            GridViewRow selectdrow = (GridViewRow)btnConsultar.NamingContainer;
            id = selectdrow.Cells[1].Text;
            Response.Redirect("~/Pages/CRUD.aspx?id=" + id + "&op=U");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string id;
            Button btnConsultar = (Button)sender;
            GridViewRow selectdrow = (GridViewRow)btnConsultar.NamingContainer;
            id = selectdrow.Cells[1].Text;
            Response.Redirect("~/Pages/CRUD.aspx?id=" + id + "&op=D");
        }
    }
}