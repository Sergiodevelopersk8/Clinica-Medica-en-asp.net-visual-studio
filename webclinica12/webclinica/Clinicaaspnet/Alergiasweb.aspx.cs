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
    public partial class Alergiasweb : System.Web.UI.Page
    {
        LogicNegoc logica = new LogicNegoc();
        ManejaSQL modelo2 = new ManejaSQL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaralergias();
            }
        }
        public void cargaralergias()
        {
            string mensj = "";
            GridView1.DataSource = logica.todasalerg(ref mensj);
            GridView1.DataBind();
        }

        public void mensaje(string mensaje)
        {
            Response.Write("<script type='text/javascript'>" + " alert('" + mensaje + "');</script>");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn2 = modelo2.AbrirConexion();
            string mensj = ""; string aviso = "se inserto";
            try
            {
                logica.Insertaralergias(cn2, Txtnombre.Text, ref mensj);
                mensaje(aviso);
            }
            catch { }
        }
    }
}