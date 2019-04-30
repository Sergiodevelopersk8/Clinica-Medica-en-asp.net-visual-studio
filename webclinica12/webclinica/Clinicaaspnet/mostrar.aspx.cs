using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModeloSql;
using Model;
using System.Data.SqlClient;
using System.Web.Security;
using System.Data;
using System.Configuration;


namespace Clinicaaspnet
{
    public partial class mostrar : System.Web.UI.Page
    {

        LogicNegoc logica = new LogicNegoc();
        ManejaSQL modelo2 = new ManejaSQL();


        protected void Page_Load(object sender, EventArgs e)
        {
			if (!IsPostBack)
			{
				cargarexpe();
			}
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn2 = modelo2.AbrirConexion();
            string quw = ""; string aviso = "";
			cargarexpe();
			try
            {
                //logica.tablamexpornombre(Txtnombre.Text, ref mensj);
                mensaje(aviso);
                //GridView1.DataSource = logica.tablamexpornombre(Txtnombre.Text, ref mensj);
                //GridView1.DataBind();
            }
            catch { }
        }

		public void cargarexpe()
		{
			string eee = "";
			GridView1.DataSource = logica.gridexpedient(Txtnombre.Text, ref eee);
			GridView1.DataBind();
		}

        public void mensaje(string mensaje)
        {
            Response.Write("<script type='text/javascript'>" + " alert('" + mensaje + "');</script>");

        }
    }
}