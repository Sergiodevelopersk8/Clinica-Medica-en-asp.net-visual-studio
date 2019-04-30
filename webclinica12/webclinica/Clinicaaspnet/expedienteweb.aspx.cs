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
    public partial class expedienteweb : System.Web.UI.Page
    {


        LogicNegoc logica = new LogicNegoc();
        ManejaSQL modelo2 = new ManejaSQL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CargarpacientCombo();
                CargarsangreCombo();
                CargarpadecimientoCombo();
                CargarviciosCombo();

                CargaralergiasCombo();
                CargaranalisisCombo();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn2 = modelo2.AbrirConexion();
            string mensj = ""; string aviso = "se inserto";
            string mengrup = "";
            int grupitos;
            string sangr = "";
            int sangresita;
            string padecimien = "";
            int padecimientito;
            string viciomen = "";
            int viciesitos;
            string alergiamens = "";
            int alergitas;
            string analisismen = "";
            int analisitos;

            IdGrupos = logica.devuelvepaciente(ref grupos, ref mengrup);
            grupitos = IdGrupos[DropDownList1.SelectedIndex];
            //string mengrup = "";
            //int grupitos;

            IdDias = logica.devuelvesangre(ref dias, ref sangr);
            sangresita = IdDias[DropDownList2.SelectedIndex];


            Idpadecimi = logica.devuelvepadecimientos(ref padecimient, ref padecimien);
            padecimientito = Idpadecimi[DropDownList3.SelectedIndex];
            //string mengrup = "";
            //int grupitos;

            idvicios = logica.devuelvevicios(ref vicioss, ref viciomen);
            viciesitos = idvicios[DropDownList4.SelectedIndex];
            //string mengrup = "";
            //int grupitos;

            idalergias = logica.devuelvealergia(ref alergias, ref alergiamens);
            alergitas = idalergias[DropDownList5.SelectedIndex];
            //string mengrup = "";
            //int grupitos;

            idanalisis = logica.devuelveanalisis(ref analisiss, ref analisismen);
            analisitos = idanalisis[DropDownList6.SelectedIndex];
            try
            {
               logica.insertarexpedientedos(cn2, grupitos, sangresita, padecimientito, viciesitos, alergitas, analisitos);
                mensaje(aviso);
            }
            catch { }
        }

        List<int> Diasli = new List<int>();
        List<string> Diasstr = new List<string>();
        List<int> idObraDetalle = null;
        List<string> Nomobra = new List<string>();
        List<int> IdGrupos = new List<int>();
        List<string> grupos = new List<string>();
        List<string> agregarhora = new List<string>();
        List<int> IdHorario = new List<int>();
        List<string> horarios = new List<string>();



        //void actuzalizar()
        //{
        //    string j = "";
        //    List<string> matriculaalumno = null;

        //    matriculaalumno = logica.categorias(ref j);
        //    Listascuatric.Items.Clear();
        //    //Listascuatric.Items.Add("Matriculas");
        //    foreach (string a in matriculaalumno)
        //    {
        //        Listascuatric.Items.Add(a);
        //    }
        //    //idObraDetalle = logica.devulveIdalumno(ref Nomobra, ref j);
        //    //Listascuatric.Items.Clear();
        //    //foreach (string a in Nomobra)
        //    //{
        //    //    Listascuatric.Items.Add(a);
        //    //}
        //    //Session["idObraDetalle"] = idObraDetalle;
        //}





        public void CargarpacientCombo()
        {
            string mensj = "";
            IdGrupos = logica.devuelvepaciente(ref grupos, ref mensj);
            DropDownList1.Items.Clear();
            foreach (string a in grupos)
            {
                DropDownList1.Items.Add(a.ToString());
            }
        }
        List<int> IdDias = new List<int>();
        List<string> dias = new List<string>();
        public void CargarsangreCombo()
        {
            string mensaje = "";
            IdDias = logica.devuelvesangre(ref dias, ref mensaje);
            DropDownList2.Items.Clear();

            foreach (string a in dias)
            {
                DropDownList2.Items.Add(a.ToString());
            }

            //Calendar1.Visible = false;
        }


        List<int> Idpadecimi = new List<int>();
        List<string> padecimient = new List<string>();

        public void CargarpadecimientoCombo()
        {
            string mensaje = "";
            Idpadecimi = logica.devuelvepadecimientos(ref padecimient, ref mensaje);
            DropDownList3.Items.Clear();

            foreach (string a in padecimient)
            {
                DropDownList3.Items.Add(a.ToString());
            }

            //Calendar1.Visible = false;
        }


        List<int> idvicios = new List<int>();
        List<string> vicioss = new List<string>();

        public void CargarviciosCombo()
        {
            string mensaje = "";
            idvicios = logica.devuelvevicios(ref vicioss, ref mensaje);
            DropDownList4.Items.Clear();

            foreach (string a in vicioss)
            {
                DropDownList4.Items.Add(a.ToString());
            }

            //Calendar1.Visible = false;
        }


        List<int> idalergias = new List<int>();
        List<string> alergias = new List<string>();

        public void CargaralergiasCombo()
        {
            string mensaje = "";
            idalergias = logica.devuelvealergia(ref alergias, ref mensaje);
            DropDownList5.Items.Clear();

            foreach (string a in alergias)
            {
                DropDownList5.Items.Add(a.ToString());
            }

            //Calendar1.Visible = false;
        }


        List<int> idanalisis = new List<int>();
        List<string> analisiss = new List<string>();

        public void CargaranalisisCombo()
        {
            string mensaje = "";
            idanalisis = logica.devuelveanalisis(ref analisiss, ref mensaje);
            DropDownList6.Items.Clear();

            foreach (string a in analisiss)
            {
                DropDownList6.Items.Add(a.ToString());
            }

            //Calendar1.Visible = false;
        }


        //public void Cargardiascom()
        //{
        //    Diasli = logica.Diascombo(ref Diasstr, ref mensj);
        //    diasdrop.Items.Clear();
        //    foreach (string a in grupos)
        //    {
        //        diasdrop.Items.Add(a.ToString());
        //    }
        //}

        public void CargarAlumnos()
        {
            //GridView1.DataSource = logica.GridparaAlumnos(ref mensj);
            //GridView1.DataBind();

            //GridView4.DataSource = logica.GridparaAlumnos(ref mensj);
            //GridView4.DataBind();

            //GridView4.DataSource = logica.Alumnosperio(ref mensj);
            //GridView4.DataBind();


        }


        public void mensaje(string mensaje)
        {
            Response.Write("<script type='text/javascript'>" + " alert('" + mensaje + "');</script>");

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mensajes = "";
            try {
                int idProf = int.Parse(GridView1.SelectedRow.Cells[1].Text.ToString());
                GridView2.DataSource = logica.tablamostrarexpediente(idProf, ref mensajes);
                GridView2.DataBind();

                //int idProduct = 0;

                //GridViewRow fila = GridView1.SelectedRow;
                //idProduct = int.Parse(fila.Cells[1].Text);

                //string m = "";
                //GridView2.DataSource = logica.TodosOrder(ref m, idProduct);
                //GridView2.DataBind();
            }
            catch (Exception excs) {
                mensaje("errorde  "+excs);
            }
            }

        protected void Button3_Click(object sender, EventArgs e)
        {
             CargarPacientes();
        }
        public void CargarPacientes()
        {
            string mensaje = "";
            //GridView1.DataSource = logica.tablapacientes(ref mensaje);
            //GridView1.DataBind();
            GridView2.DataSource = logica.tablamostrarexpedientedos( ref mensaje);
            GridView2.DataBind();
        }
    }
}