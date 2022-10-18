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
    public partial class CRUD : System.Web.UI.Page
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);
        public static string sID = "-1";
        public static string sOpc = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogeado"] != null)
            {
                string userlogeado = Session["userlogeado"].ToString();
            }

            else
                Response.Redirect("Login.aspx");


            if (!Page.IsPostBack)
            {
                if(Request.QueryString["id"] !=null)
                {
                    sID = Request.QueryString["id"].ToString();
                    CargarDatos();
                }

                if (Request.QueryString["op"] != null)
                {
                    sOpc = Request.QueryString["op"].ToString();

                    switch (sOpc)
                    {
                        case "C":
                            this.lbltitulo.Text = "Ingresar nuevo usuario";
                            this.btnCreate.Visible = true;
                            break;

                        case "R":
                            this.lbltitulo.Text = "Consulta de usuario";
                            break;

                        case "U":
                            this.lbltitulo.Text = "Modificar usuario";
                            this.btnUpdate.Visible = true;
                            break;

                        case "D":
                            this.lbltitulo.Text = "Eliminar Usuario";
                            this.btnDelete.Visible = true;
                            break;
           
                    }
                }
            }
        }

        void CargarDatos()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("contactoread", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = sID;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            tbNombre.Text = row[1].ToString();
            tbApe.Text = row[2].ToString();      
            tbTel.Text = row[6].ToString();
            con.Close();
        }
        protected void btnCreate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("contacto_crear", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = tbNombre.Text;
            cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = tbApe.Text;
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = tbTel.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Index.aspx");        
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("contacto_update", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = sID;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = tbNombre.Text;
            cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = tbApe.Text;
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = tbTel.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Index.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("contacto_delete", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = sID;           
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Index.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}