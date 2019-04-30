using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ModeloSql;
using Model;



namespace ModeloSql
{
    public class LogicNegoc
    {
        //Mane capa1 = new ManejaSQL();
        ManejaSQL capa1 = new ManejaSQL();


        public LogicNegoc()
        {
            //capa1.CadCone = @"Data Source=SERGIOMERINOSK8\SERGIOSKATERSQL;Initial Catalog =logprueba;Integrated Security=True";
        }
        SqlCommand carrito;
        string mensj = "";
        //ManejaSQL msql = new ManejaSQL();

      

        public void InsertarAlumnoPaciente(SqlConnection carretera, string nombre, string apellidop, string apellidom, string direccion, string telefonos, ref string mensj)
        {
            //LlenarArreglo(carretera);
            //int grupo = idforeign[grupos];
            // String query = "INSERT INTO Alumno(nombre,apellidoP,apellidoM,Matricula,IdGrupo)values(@nombre,@paterno,@materno,@matricula,"+ grupos+")";
            // String query = "INSERT INTO Alumno(nombre,apellidoP,apellidoM,Matricula)values(@nombre,@paterno,@materno,@matricula )";
            String query = "INSERT INTO Paciente(NombrePa,apellidoP,apellidoM,direccion,telefono)values(@nombre,@paterno,@materno,@direccio,@telefonoss)";
            if (carretera != null)
            {
                try
                {
                    SqlParameter uno = new SqlParameter("nombre", SqlDbType.VarChar, 50);
                    uno.Direction = ParameterDirection.Input;
                    uno.Value = nombre;

                    SqlParameter dos = new SqlParameter("paterno", SqlDbType.VarChar, 50);
                    dos.Direction = ParameterDirection.Input;
                    dos.Value = apellidop;

                    SqlParameter tres = new SqlParameter("materno", SqlDbType.VarChar, 50);
                    tres.Direction = ParameterDirection.Input;
                    tres.Value = apellidom;

                    SqlParameter cuatro = new SqlParameter("direccio", SqlDbType.VarChar, 50);
                    cuatro.Direction = ParameterDirection.Input;
                    cuatro.Value = direccion;

                    SqlParameter cinco = new SqlParameter("telefonoss", SqlDbType.VarChar, 50);
                    cinco.Direction = ParameterDirection.Input;
                    cinco.Value = telefonos;


                    carrito = new SqlCommand();
                    carrito.Parameters.Add(uno);
                    carrito.Parameters.Add(dos);
                    carrito.Parameters.Add(tres);
                    carrito.Parameters.Add(cuatro);
                    carrito.Parameters.Add(cinco);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    //int n = carrito.ExecuteNonQuery();
                    //return n > 0;
                    mensj = "Modificacion correcta";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;

                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }

        public void Insertarpente(SqlConnection carretera, string nombre, string clave, ref string mensj)
        {
            String query = "INSERT INTO Paciente(NombrePa ,contrasena)values(@nombreus,@clavusu)";

            if (carretera != null)
            {
                try
                {
                    SqlParameter uno = new SqlParameter("nombreus", SqlDbType.VarChar, 50);
                    uno.Direction = ParameterDirection.Input;
                    uno.Value = nombre;

                    SqlParameter dos = new SqlParameter("clavusu", SqlDbType.VarChar, 50);
                    dos.Direction = ParameterDirection.Input;
                    dos.Value = clave;



                    carrito = new SqlCommand();
                    carrito.Parameters.Add(uno);
                    carrito.Parameters.Add(dos);


                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Modificacion correcta";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }



        public void Insertarsangre(SqlConnection carretera, string nsangre,ref string mensj)
        {
            String query = "INSERT INTO TipoSangre(Sangre)values(@sangree)";

            if (carretera != null)
            {
                try
                {
                    SqlParameter uno = new SqlParameter("sangree", SqlDbType.VarChar, 50);
                    uno.Direction = ParameterDirection.Input;
                    uno.Value = nsangre;

                   


                    carrito = new SqlCommand();
                    carrito.Parameters.Add(uno);
                   



                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Modificacion correcta";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }




     



        ////////////////////////insertar con prodecimiento///////////////////

        public bool InsertarAsistencia(int horario, string fecha, int asistencias)
        {
            ManejaSQL cn = new ManejaSQL();
            try
            {
                string query = "insert into Asistencias_Laboratorios values(@horario,@fecha,@asistencias)";

                SqlParameter uno = new SqlParameter("horario", SqlDbType.Int);
                uno.Direction = ParameterDirection.Input;
                uno.Value = horario;

                SqlParameter dos = new SqlParameter("fecha", SqlDbType.VarChar, 50);
                dos.Direction = ParameterDirection.Input;
                dos.Value = fecha;

                SqlParameter tres = new SqlParameter("asistencias", SqlDbType.Int);
                tres.Direction = ParameterDirection.Input;
                tres.Value = asistencias;

                SqlCommand cmd = new SqlCommand(query, cn.AbrirConexion());

                cmd.Parameters.Add(uno);
                cmd.Parameters.Add(dos);
                cmd.Parameters.Add(tres);

                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        ///////////////////////////////////////////


        public void Insertarpadecimiento(SqlConnection carretera, string npadecimiento, ref string mensj)
        {
            String query = "INSERT INTO Padecimientos (padecimiento)values(@padecimient)";

            if (carretera != null)
            {
                try
                {
                    SqlParameter uno = new SqlParameter("padecimient", SqlDbType.VarChar, 50);
                    uno.Direction = ParameterDirection.Input;
                    uno.Value = npadecimiento;




                    carrito = new SqlCommand();
                    carrito.Parameters.Add(uno);




                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Modificacion correcta";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }


        public void Insertarvicios(SqlConnection carretera, string nvicios, ref string mensj)
        {
            String query = "INSERT INTO Vicios (vicio) values (@vicioss)";

            if (carretera != null)
            {
                try
                {
                    SqlParameter uno = new SqlParameter("vicioss", SqlDbType.VarChar, 50);
                    uno.Direction = ParameterDirection.Input;
                    uno.Value = nvicios;




                    carrito = new SqlCommand();
                    carrito.Parameters.Add(uno);




                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Modificacion correcta";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }


        public void Insertaralergias(SqlConnection carretera, string alergiass, ref string mensj)
        {
            String query = "INSERT INTO Alergias  (alergias) values (@alerg)";

            if (carretera != null)
            {
                try
                {
                    SqlParameter uno = new SqlParameter("alerg", SqlDbType.VarChar, 50);
                    uno.Direction = ParameterDirection.Input;
                    uno.Value = alergiass;




                    carrito = new SqlCommand();
                    carrito.Parameters.Add(uno);




                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Modificacion correcta";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }

        public void Insertaranalisiscli(SqlConnection carretera, string aanalisiss, ref string mensj)
        {
            String query = "INSERT INTO AnalisisClinico  (tipodeanalisis) values (@analiss)";

            if (carretera != null)
            {
                try
                {
                    SqlParameter uno = new SqlParameter("analiss", SqlDbType.VarChar, 50);
                    uno.Direction = ParameterDirection.Input;
                    uno.Value = aanalisiss;




                    carrito = new SqlCommand();
                    carrito.Parameters.Add(uno);




                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Modificacion correcta";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }



        public void ingresarcuatrimestre(SqlConnection carretera,  int pacien, string fechaini, ref string mensj)
        {
            //SqlConnection carretera = null;
            //carretera = capa1.AbrirConexion(ref mensj);
            if (carretera != null)
            {
                try
                {
                    String SqlString = "insert into cuatrimestre(Periodo,fecha_inicio,fecha_fin)" +
                        "values(@perio,@fechai,@fechaf)";
                    using (carrito = new SqlCommand(SqlString, carretera))
                    {
                        carrito.CommandType = CommandType.Text;
                       // carrito.Parameters.AddWithValue("@perio", period);
                        //carrito.Parameters.AddWithValue("@yearm", yearddd);
                        carrito.Parameters.AddWithValue("@fechai", fechaini);
                       // carrito.Parameters.AddWithValue("@fechaf", fechafin);


                        carrito.Connection = carretera;
                        carrito.ExecuteNonQuery();
                        mensj = "Modificacion carrecta";
                    }
                }
                catch (Exception e)
                {
                    mensj = e.Message;
                }
                carretera.Close();

            }

        }


        //public void InsertarAsignacionexpediente(SqlConnection carretera, int idGrup, int idLabo, int idDia, int idMate, int idProfe, int idHor, ref string mensj)
        //{
        //    DevuelveGrupos2(carretera);
        //    int misGrupos = hola[idGrup];

        //    DevuelveLabo(carretera);
        //    int misAulas = labora[idLabo];

        //    DevuelveDias(carretera);
        //    int misDias = diass[idDia];

        //    DevuelveMaterias(carretera);
        //    int misMates = materiass[idMate];

        //    DevuelveProfes(carretera);
        //    int misProfes = profess[idProfe];

        //    DevuelveHorarios(carretera);
        //    int misHoras = horass[idHor];

        //    String query = "insert into AsignaHorario (IdGrupo,IdLaboratorio,IdDia,IdMateria,IdProfesor,IdHorario)values(@grupo,@aula,@dia,@mate,@profe,@horari)";
        //    hola.Clear();
        //    labora.Clear();
        //    diass.Clear();
        //    materiass.Clear();
        //    profess.Clear();
        //    horass.Clear();

        //    if (carretera != null)
        //    {
        //        try
        //        {
        //            SqlParameter grup = new SqlParameter("grupo", SqlDbType.Int, 50);
        //            grup.Direction = ParameterDirection.Input;
        //            grup.Value = misGrupos;

        //            SqlParameter au = new SqlParameter("aula", SqlDbType.Int, 50);
        //            au.Direction = ParameterDirection.Input;
        //            au.Value = misAulas;

        //            SqlParameter diaa = new SqlParameter("dia", SqlDbType.Int, 50);
        //            diaa.Direction = ParameterDirection.Input;
        //            diaa.Value = misDias;

        //            SqlParameter mater = new SqlParameter("mate", SqlDbType.Int, 50);
        //            mater.Direction = ParameterDirection.Input;
        //            mater.Value = misMates;

        //            SqlParameter prof = new SqlParameter("profe", SqlDbType.Int, 50);
        //            prof.Direction = ParameterDirection.Input;
        //            prof.Value = misProfes;

        //            SqlParameter hor = new SqlParameter("horari", SqlDbType.Int, 50);
        //            hor.Direction = ParameterDirection.Input;
        //            hor.Value = misHoras;

        //            carrito = new SqlCommand();
        //            carrito.Parameters.Add(grup);
        //            carrito.Parameters.Add(au);
        //            carrito.Parameters.Add(diaa);
        //            carrito.Parameters.Add(mater);
        //            carrito.Parameters.Add(prof);
        //            carrito.Parameters.Add(hor);

        //            carrito.Connection = carretera;
        //            carrito.CommandText = query;
        //            carrito.ExecuteNonQuery();
        //            mensj = "Horario asignado";
        //        }
        //        catch (Exception h)
        //        {
        //            mensj = "Error " + h.Message;
        //        }
        //        carretera.Close();
        //    }
        //    else
        //    {
        //        mensj = "No hay conexion abierta";
        //    }
        //}


        public void ingfechaconsul(SqlConnection carretera,  int pacien,string fechaini,  ref string mensj)
        {
            //SqlConnection carretera = null;
            //carretera = capa1.AbrirConexion(ref mensj);
            if (carretera != null)
            {
                try
                {
                    String SqlString = "insert into  FechaConsulta values(@pacie,@fecha)";
                    using (carrito = new SqlCommand(SqlString, carretera))
                    {
                        carrito.CommandType = CommandType.Text;
                        
                        carrito.Parameters.AddWithValue("@pacie", pacien);
                        carrito.Parameters.AddWithValue("@fechai", fechaini);
                       


                        carrito.Connection = carretera;
                        carrito.ExecuteNonQuery();
                        mensj = "Modificacion carrecta";
                    }
                }
                catch (Exception e)
                {
                    mensj = e.Message;
                }
                carretera.Close();

            }

        }


        public void insertarfechrecet(SqlConnection carretera, int pacien, string fechaini,  string receta ,ref string mensj)
        {
           // String query = "INSERT INTO TipoSangre(Sangre)values(@sangree)";

            if (carretera != null)
            {
                try
                {
                    String SqlString = "insert into  FechaConsultarece values(@pacie,@fecha,@receta)";
                    using (carrito = new SqlCommand(SqlString, carretera))
                    {
                        carrito.CommandType = CommandType.Text;

                        carrito.Parameters.AddWithValue("@pacie", pacien);
                        carrito.Parameters.AddWithValue("@fecha", fechaini);
                        carrito.Parameters.AddWithValue("@receta", receta);


                        carrito.Connection = carretera;
                        carrito.ExecuteNonQuery();
                        mensj = "Modificacion carrecta";
                    }
                }
                catch (Exception e)
                {
                    mensj = e.Message;
                }
                carretera.Close();

            }
        }


        /* public bool InsertarAsistencia(int horario, string fecha, int asistencias)
         {
             ManejaSQL cn = new ManejaSQL();
             try
             {
                 string query = "insert into Asistencias_Laboratorios values(@horario,@fecha,@asistencias)";

                 SqlParameter uno = new SqlParameter("horario", SqlDbType.Int);
                 uno.Direction = ParameterDirection.Input;
                 uno.Value = horario;

                 SqlParameter dos = new SqlParameter("fecha", SqlDbType.VarChar, 50);
                 dos.Direction = ParameterDirection.Input;
                 dos.Value = fecha;

                 SqlParameter tres = new SqlParameter("asistencias", SqlDbType.Int);
                 tres.Direction = ParameterDirection.Input;
                 tres.Value = asistencias;

                 SqlCommand cmd = new SqlCommand(query, cn.AbrirConexion());

                 cmd.Parameters.Add(uno);
                 cmd.Parameters.Add(dos);
                 cmd.Parameters.Add(tres);

                 int n = cmd.ExecuteNonQuery();
                 return n > 0;
             }
             catch (Exception)
             {
                 return false;
             }
         }*/

        public bool Insertarfechconsul(int pacie, string fecha)
        {
            ManejaSQL cn = new ManejaSQL();
            try
            {
                string query = "insert into FechaConsulta values(@pacientss,@fecha)";

                SqlParameter uno = new SqlParameter("pacientss", SqlDbType.Int);
                uno.Direction = ParameterDirection.Input;
                uno.Value = pacie;

                SqlParameter dos = new SqlParameter("fecha", SqlDbType.VarChar, 50);
                dos.Direction = ParameterDirection.Input;
                dos.Value = fecha;

                //SqlParameter tres = new SqlParameter("asistencias", SqlDbType.Int);
                //tres.Direction = ParameterDirection.Input;
                //tres.Value = asistencias;

                SqlCommand cmd = new SqlCommand(query, cn.AbrirConexion());

                cmd.Parameters.Add(uno);
                cmd.Parameters.Add(dos);
                //cmd.Parameters.Add(tres);

                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }


         public bool insertarexpediente(int pacie, int ttsangre, int padecimi, int vicioo, int aalergia, int aanalisis,int ffecha)
        {
            ManejaSQL cn = new ManejaSQL();
            try
            {
                string query = "insert into Expedienteclinico (idpaciente,idtipoSangre,idpadecimientos,idvicios,idalergias,idanalisis,idfechaconsulta) VALUES(" + pacie + ","+ ttsangre + ","+ padecimi + ","+ vicioo + ","+ aalergia + ","+ aanalisis +","+ ffecha+ ")";
                SqlCommand cmd = new SqlCommand(query, cn.AbrirConexion());
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        ////

        public void insertarexpedientedos(SqlConnection carretera, int paciente, int sangre, int padecimiento, int vicio, int alergia, int analisis)
        {



            string query = "insert into Expedienteclinicodos (idpaciente,idtipoSangre,idpadecimientos,idvicios,idalergias,idanalisis)values (@idpacientt, @idtdsangre,@idpadecimi,@idvicios,@idalergiass,@idanalisiss)";

            if (carretera != null)
            {
                try
                {
                    SqlParameter pacients = new SqlParameter("idpacientt", SqlDbType.Int);
                    pacients.Direction = ParameterDirection.Input;
                    pacients.Value = paciente;

                    SqlParameter sangersss = new SqlParameter("idtdsangre", SqlDbType.Int);
                    sangersss.Direction = ParameterDirection.Input;
                    sangersss.Value = sangre;

                    SqlParameter padecimientsss = new SqlParameter("idpadecimi", SqlDbType.Int);
                    padecimientsss.Direction = ParameterDirection.Input;
                    padecimientsss.Value = padecimiento;

                    SqlParameter viciotss = new SqlParameter("idvicios", SqlDbType.Int);
                    viciotss.Direction = ParameterDirection.Input;
                    viciotss.Value = vicio;

                    SqlParameter alergts = new SqlParameter("idalergiass", SqlDbType.Int);
                    alergts.Direction = ParameterDirection.Input;
                    alergts.Value = alergia;

                    SqlParameter analisits = new SqlParameter("idanalisiss", SqlDbType.Int);
                    analisits.Direction = ParameterDirection.Input;
                    analisits.Value = analisis;



                    carrito = new SqlCommand();
                    carrito.Parameters.Add(pacients);
                    carrito.Parameters.Add(sangersss);
                    carrito.Parameters.Add(padecimientsss);
                    carrito.Parameters.Add(viciotss);
                    carrito.Parameters.Add(alergts);
                    carrito.Parameters.Add(analisits);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "expediente agregado";

                }
                catch (Exception)
                {

                }
            }

        }

        /////////////////////////////////////////////Grids/////////////////////////////////////////////////////////////////////////////////////////////*

        public System.Data.DataTable ConsultarHorarios(ref string ms)
        {
            ManejaSQL cn = new ManejaSQL();
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = cn.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = cn.ConsultaDataSet(cnt3, "ConsultarHorario", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }





        public System.Data.DataTable GridparaAlumnos(ref string ms)
        {
            //ManejaSQL cn = new ManejaSQL();
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "ConsultarAlumnos", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }



        public System.Data.DataTable ConsultarLaboratorios(ref string ms)
        {
            ManejaSQL cn = new ManejaSQL();
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = cn.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = cn.ConsultaDataSet(cnt3, "select IdLaboratorio as 'Clave',NombreLab as 'Laboratorio',Edificio from Laboratorio_E", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }





        ///////////////////////////////////////////////////////////////////////otro tipo de consultas///////////////////////////////////////////////////////////////////////////////////////////////////

        public List<string> devulvegrups(ref string msj)
        {
            List<string> ids = new List<string>();
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;

            cnt2 = capa1.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = capa1.ConsultaDataReader(ref cnt2, "select Grupo from Grupo", ref msj);
                if (dr1 != null)
                {
                    ids.Clear();
                    while (dr1.Read())
                    {
                        ids.Add((string)dr1[0]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
            return ids;
        }


        public List<int> devuelvepaciente(ref List<string> paciente, ref string mnsj)
        {
            ManejaSQL cn = new ManejaSQL();
            List<int> ids = new List<int>();
            //  string query = "select * from Grupo";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = capa1.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = capa1.ConsultaDataReader(ref cnt2, "select * from Paciente", ref mensj);

                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        paciente.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }

            cnt2.Close();
            cnt2.Dispose();

            return ids;
        }


        public List<int> devuelvesangre(ref List<string> sangre, ref string mnsj)
        {
            ManejaSQL cn = new ManejaSQL();
            List<int> ids = new List<int>();
            //  string query = "select * from Grupo";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = capa1.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = capa1.ConsultaDataReader(ref cnt2, "select * from TipoSangre", ref mensj);

                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        sangre.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }

            cnt2.Close();
            cnt2.Dispose();

            return ids;
        }


        public List<int> devuelvepadecimientos(ref List<string> padecimient, ref string mnsj)
        {
            ManejaSQL cn = new ManejaSQL();
            List<int> ids = new List<int>();
            //  string query = "select * from Grupo";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = capa1.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = capa1.ConsultaDataReader(ref cnt2, "select * from Padecimientos", ref mensj);

                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        padecimient.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }

            cnt2.Close();
            cnt2.Dispose();

            return ids;
        }

        public List<int> devuelvevicios(ref List<string> vicios, ref string mnsj)
        {
            ManejaSQL cn = new ManejaSQL();
            List<int> ids = new List<int>();
            //  string query = "select * from Grupo";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = capa1.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = capa1.ConsultaDataReader(ref cnt2, "select * from Vicios", ref mensj);

                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        vicios.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }

            cnt2.Close();
            cnt2.Dispose();

            return ids;
        }


        public List<int> devuelvealergia(ref List<string> alergia, ref string mnsj)
        {
            ManejaSQL cn = new ManejaSQL();
            List<int> ids = new List<int>();
            //  string query = "select * from Grupo";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = capa1.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = capa1.ConsultaDataReader(ref cnt2, "select*from Alergias", ref mensj);

                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        alergia.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }

            cnt2.Close();
            cnt2.Dispose();

            return ids;
        }

        public List<int> devuelveanalisis(ref List<string> analisis, ref string mnsj)
        {
            ManejaSQL cn = new ManejaSQL();
            List<int> ids = new List<int>();
            //  string query = "select * from Grupo";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = capa1.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = capa1.ConsultaDataReader(ref cnt2, "select * from AnalisisClinico", ref mensj);

                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        analisis.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }

            cnt2.Close();
            cnt2.Dispose();

            return ids;
        }

        //public List<int> devuelvepacientdos(ref List<string> paciente,/* ref List<string> pacienteap, ref List<string> pacienteapm,*/ ref string mnsj)
        //{
        //    ManejaSQL cn = new ManejaSQL();
        //    List<int> ids = new List<int>();
        //    //  string query = "select * from Grupo";
        //    SqlConnection cnt2 = null;
        //    SqlDataReader dr1 = null;
        //    cnt2 = capa1.AbrirConexion();
        //    if (cnt2 != null)
        //    {
        //        dr1 = capa1.ConsultaDataReader(ref cnt2, "select * from Paciente", ref mensj);

        //        if (dr1 != null)
        //        {
        //            while (dr1.Read())
        //            {
        //                ids.Add((int)dr1[0]);
        //                paciente.Add((string)dr1[1,2,3]);
        //                //paciente.Add((string)dr1[2]);
        //                //paciente.Add((string)dr1[3]);
        //            }
        //        }
        //        cnt2.Close();
        //        cnt2.Dispose();
        //    }

        //    cnt2.Close();
        //    cnt2.Dispose();

        //    return ids;
        //}



        public List<int> devuelvelibres(ref List<string> edificio, ref string mnsj)
        {
            ManejaSQL cn = new ManejaSQL();
            List<int> ids = new List<int>();
            string query = "select * from Laboratorios_Edificios";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = cn.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = cn.ConsultaDataReader(ref cnt2, query, ref mnsj);
                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        edificio.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
            else if (cn != null)
            {
                dr1 = cn.ConsultaDataReader(ref cnt2, query, ref mnsj);
                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        edificio.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
            return ids;
        }


        public List<int> devuelveLaboratorios(ref List<string> grupos, ref string mnsj)
        {

            List<int> ids = new List<int>();
            //string query = "select*from Laboratorios_Edificios;";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = capa1.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = capa1.ConsultaDataReader(ref cnt2, "select*from Laboratorios_Edificios", ref mensj);
                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        grupos.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
            return ids;
        }



        public List<int> devuelveProfesores(ref List<string> nombres, ref string mnsj)
        {
            ManejaSQL cn = new ManejaSQL();
            List<int> ids = new List<int>();
            string query = "select*from Profesor;";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = cn.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = cn.ConsultaDataReader(ref cnt2, query, ref mnsj);
                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        nombres.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
            return ids;
        }


        public System.Data.DataTable todasalerg(ref string ms)
        {
            //ma cn = new Conectar();
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "veralergias ", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }


        public System.Data.DataTable tablapadecimiento(ref string ms)
        {
            //ma cn = new Conectar();
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "verpadecimientos ", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }


        public System.Data.DataTable tablarecetas(ref string ms)
        {
            //ma cn = new Conectar();
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "Recetas ", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }


        public System.Data.DataTable tablapacientes(ref string ms)
        {
            //ma cn = new Conectar();
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "pacienteparaexpediente ", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }

        public System.Data.DataTable tablasrecetas(ref string ms)
        {
            //ma cn = new Conectar();
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "Recetas ", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }


        public System.Data.DataTable setspacient(ref string ms)
        {
            //ma cn = new Conectar();
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "pacienteparaexpediente ", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }




        public System.Data.DataTable tablamostrarexpediente( int idpacien ,ref string ms)
        {
            //ma cn = new Conectar();
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "expedientesconvalor " + idpacien + "", ref ms);
             
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }


        public System.Data.DataTable tablamostrarexpedientedos( ref string ms)
        {
            //ma cn = new Conectar();
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "expedientesconvalordos ", ref ms);

                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }


        public System.Data.DataTable tablainerexpediente(string nombre, ref string ms)
        {
            //ma cn = new Conectar();
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "expedientesconvalor " + nombre + "", ref ms);

                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }



        public DataSet TodosOrder(ref string mnsj, int idSuplier)
        {
            SqlConnection cnt3 = null;
            DataSet caja = null;
            // DataTable salida = null;
            cnt3 = capa1.AbrirConexion();



            if (cnt3 != null)
            {
                caja = capa1.ConsultaDataSet(cnt3, "expedientesconvalor" + idSuplier + ";", ref mnsj);


            }
            return caja;
        }


        public System.Data.DataTable tablamexpornombre( string nombrpase,ref string ms)
        {
            //ma cn = new Conectar();
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "SELECT pacie.NombrePa, pacie.apellidoP, pacie.apellidoM, sang.Sangre, alerg.alergias, vici.vicio, clinica.tipodeanalisis"+
"FROM Expedienteclinicodos expedien JOIN Paciente pacie ON pacie.idpaciente = expedien.idpaciente JOIN TipoSangre sang ON sang.idtipoSangre = expedien.idtipoSangre JOIN Alergias alerg ON alerg.idalergias = expedien.idalergias JOIN Vicios vici ON vici.idvicios = expedien.idvicios JOIN AnalisisClinico clinica ON clinica.idanalisis = expedien.idanalisis where pacie.NombrePa ="+ nombrpase, ref ms);

                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }




		public System.Data.DataTable gridexpedient(string nombrpase, ref string ms)
		{
			//ma cn = new Conectar();
			SqlConnection cnt3 = null;
			System.Data.DataSet Caja = null;
			System.Data.DataTable Salida = null;
			cnt3 = capa1.AbrirConexion();
			if (cnt3 != null)
			{
				Caja = capa1.ConsultaDataSet(cnt3, "exxx " + nombrpase + "", ref ms);

				if (Caja != null)
				{
					Salida = Caja.Tables[0];
				}
			}
			return Salida;
		}


	}
}
