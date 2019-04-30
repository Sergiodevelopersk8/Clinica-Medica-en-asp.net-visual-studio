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
    public partial class Recetafechaweb : System.Web.UI.Page
    {

        LogicNegoc logica = new LogicNegoc();
        ManejaSQL modelo2 = new ManejaSQL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarpacientesCombo();
                cargarreceta();
            }
            
            Calendar1.Visible = false;
        }

        List<int> IdGrupos = new List<int>();
        List<string> grupos = new List<string>();

     
        public void CargarpacientesCombo()
        {
            string mensj = "";
            IdGrupos = logica.devuelvepaciente(ref grupos, ref mensj);
            DropDownList1.Items.Clear();
            foreach (string a in grupos)
            {
                DropDownList1.Items.Add(a.ToString());
            }
        }
        public void cargarreceta()
        {
            string mensj = "";
            GridView1.DataSource = logica.tablarecetas(ref mensj);
            GridView1.DataBind();
        }

        //public void CargarpacientesCombo()
        //{
        //    string mensj = "";
        //    IdGrupos = logica.devuelvepacientdos(ref grupos,/*ref gruposdos,ref grupostres,*/ ref mensj);
        //    DropDownList1.Items.Clear();
        //    foreach (string a in grupos )
        //    {
        //        DropDownList1.Items.Add(a.ToString());

        //    }

        //    foreach (string b in gruposdos)
        //    {
        //        DropDownList1.Items.Add(b.ToString());
        //    }
        //    foreach (string c in grupostres)
        //    {
        //        DropDownList1.Items.Add(c.ToString());
        //    }
        //}


        public void mensaje(string mensaje)
        {
            Response.Write("<script type='text/javascript'>" + " alert('" + mensaje + "');</script>");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string mengrup = "";
            int grupitos;

            IdGrupos = logica.devuelvepaciente(ref grupos, ref mengrup);
            grupitos = IdGrupos[DropDownList1.SelectedIndex];

            SqlConnection cn2 = modelo2.AbrirConexion();
            string mensj = ""; string aviso = "se inserto";
            string fecha = "";
            fecha = Calendar1.TodaysDate.ToShortDateString();
            try
            {
                logica.insertarfechrecet(cn2, grupitos, fecha,Txtnombre.Text, ref mensj);
                mensaje(aviso);
            }
            catch { }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}