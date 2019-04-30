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

    public partial class Adiccionweb : System.Web.UI.Page
    {
       LogicNegoc logica = new LogicNegoc();
        ManejaSQL modelo2 = new ManejaSQL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            SqlConnection cn2 = modelo2.AbrirConexion();
            string mensj = ""; string aviso = "se inserto";
            try
            {
                logica.Insertarvicios(cn2, Txtnombre.Text, ref mensj);
                mensaje(aviso);
            }
            catch { }





        }
        public void mensaje(string mensaje)
        {
            Response.Write("<script type='text/javascript'>" + " alert('" + mensaje + "');</script>");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }
    }
}