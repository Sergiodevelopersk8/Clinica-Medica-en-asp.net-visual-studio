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
    public partial class Pacienteweb : System.Web.UI.Page
    {

        LogicNegoc logica = new LogicNegoc();
        ManejaSQL modelo2 = new ManejaSQL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn2 = modelo2.AbrirConexion();
            string mensj = "";
            string aviso = "se inserto";
            try {
                logica.InsertarAlumnoPaciente(cn2, Txtnombre.Text, Txtapellido1.Text, Txtapellido2.Text, Txtdireccion.Text, txtelefono.Text, ref mensj);
                mensaje(aviso);
            }
            catch { }
            }

        public void mensaje(string mensaje)
        {
            Response.Write("<script type='text/javascript'>" + " alert('" + mensaje + "');</script>");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn2 = modelo2.AbrirConexion();
            string mensj = "";
            string aviso = "se inserto";
            string aviso2 = "error";
            try
            {

                //if (Txtnombre.Text =="" && Txtapellido1.Text=="" && Txtapellido2.Text==""  && Txtdireccion.Text=="" && txtelefono.Text == "")
                //{
                //    mensaje(aviso2);
                //}

                if (Txtnombre.Text == "" || Txtapellido1.Text == "" || Txtapellido2.Text == "" || Txtdireccion.Text == "" || txtelefono.Text == "")
                {
                    mensaje(aviso2);
                }

                else
                {
                    logica.InsertarAlumnoPaciente(cn2, Txtnombre.Text, Txtapellido1.Text, Txtapellido2.Text, Txtdireccion.Text, txtelefono.Text, ref mensj);
                    mensaje(aviso);
                }
            }
            catch { }
        }
    }
    }
