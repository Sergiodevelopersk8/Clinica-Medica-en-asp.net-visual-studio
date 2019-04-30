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
    public partial class Padecimientoweb : System.Web.UI.Page
    {
        LogicNegoc logica = new LogicNegoc();
        ManejaSQL modelo2 = new ManejaSQL();
        protected void Page_Load(object sender, EventArgs e)
        {
            //GridDatosRegistro.Visible = false;
            if(!IsPostBack)
            {
                cargarpadecimientos();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn2 = modelo2.AbrirConexion();
            string mensj = ""; string aviso = "se inserto";
            try
            {
                logica.Insertarpadecimiento(cn2, Txtnombre.Text, ref mensj);
                mensaje(aviso);
            }
            catch { }
        }

        //public void cargaralergias()
        //{
        //    string mensj = "";
        //    GridView1.DataSource = logica.todasalerg(ref mensj);
        //    GridView1.DataBind();
        //}


        public void mensaje(string mensaje)
        {
            Response.Write("<script type='text/javascript'>" + " alert('" + mensaje + "');</script>");

        }

        public void cargarpadecimientos()
        {
            string mensj = "";
            GridView1.DataSource = logica.tablapadecimiento(ref mensj);
            GridView1.DataBind();
        }


        //private void ListarRegistro()
        //{
        //    try
        //    {
        //        using (SqlConnection conexi = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionConfigu"].ToString()))
        //        using (SqlDataAdapter da = new SqlDataAdapter("verpadecimientos", conexi))
        //        {
        //            DataTable tbRegistro = new DataTable();
        //            da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //            da.Fill(tbRegistro);
        //            GridDatosRegistro.DataSource = tbRegistro;
        //            GridDatosRegistro.DataBind();
        //            Session["verpadecimiento"] = tbRegistro;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }


        //}

        //protected void GridDatosRegistro_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}