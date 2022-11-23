using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using Pabo.Calendar;

namespace Actividades
{
    class CControl
    {
        internal static int idUsuario = 0;
        SqlConnection cnt = new SqlConnection("Server=.\\SQLEXPRESS; Database=Actividades; Trusted_Connection=True");
        public bool InicioSesion(TextBox txtUser, TextBox txtPass)
        {
            cnt.Open();
            string consulta = "SELECT idUsuario FROM Usuario WHERE correo='" + txtUser.Text + "'and clave=HASHBYTES('MD4', '" + txtPass.Text + "')";
            SqlCommand cmd = new SqlCommand(consulta, cnt);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                idUsuario = (int)cmd.ExecuteScalar();
                cnt.Close();
                return true;
            }
            else
            {
                dr.Close();
                cnt.Close();
                return false;
            }
            
        }

        public void InsertarActividad(string nomAct, string fch, string hr, string lgr, string cantP, int resp, string ofc, string nomEnc, string aca, string img)
        {
            cnt.Open();
            string campos = "nombreActividad, fecha, hora, lugar, cantidadParticipantes, oficio, nombreEncargado, academia, idUsuarioResponsable, fotoEncargado", 
                valores = nomAct + "', '" + fch + "', '" + hr + "', '" + lgr + "', '" + cantP + "', '" + ofc + "', '" + nomEnc + "', '" + aca + "', '" + resp + "', '" + img;
            if (idUsuario == 1)
            {
                campos += ", estatus";
                valores += "', '1";
            }
            string consulta = "INSERT INTO Actividad ("+ campos +") " +"VALUES('" + valores + "' );";
            SqlCommand cmd = new SqlCommand(consulta, cnt);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Los datos se han añadido exitosamente");
            cnt.Close();
        }

        public void Mostrar(DataGridView caja, int cond)
        {
            cnt.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter("select * from Actividad WHERE estatus=" + cond.ToString() + ";", cnt); ;

            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();

            adaptador.Fill(ds);
            tabla = ds.Tables[0];
            caja.DataSource = tabla;
            cnt.Close();
        }

        public void Actualizar(string nomAct, string fch, string hr, string lgr, string cantP, int resp, string ofc, string nomEnc, string aca, string img, int id)
        {
            cnt.Open();
            string consulta = "UPDATE Actividad SET nombreActividad='" + nomAct + "', fecha='" + fch + "', hora='" + hr + "', lugar='" + lgr + "', cantidadParticipantes=" + cantP + ", oficio='" + ofc + "', nombreEncargado='" + nomEnc + "', academia='" + aca + "', fotoEncargado='" + img + "', idUsuarioResponsable=" + resp + " WHERE idActividad=" + id;
            SqlCommand cmd = new SqlCommand(consulta, cnt);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Los datos se han actualizado exitosamente");
            cnt.Close();
        }

        public void Actualizar(string aceptado)
        {
            cnt.Open();
            string consulta = "UPDATE Actividad SET estatus=1 WHERE idActividad=" + aceptado;
            SqlCommand cmd = new SqlCommand(consulta, cnt);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Oficio aceptado exitosamente");
            cnt.Close();
        }

        public string Modi(int id)
        {
            cnt.Open();
            string consulta = "SELECT * FROM Actividad WHERE idActividad="+id.ToString();
            SqlCommand cmd = new SqlCommand(consulta, cnt);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string datos = "";
            for (int i = 0; i<10; i++)
            {
                datos += dr[i].ToString() + '|';
            }
            datos += dr[10].ToString();
            dr.Close();
            cnt.Close();
            return datos;
        }
        
        public void FechasColor(Pabo.Calendar.MonthCalendar mnt)
        {
            cnt.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter("select fecha, idUsuarioResponsable from Actividad where estatus=1;", cnt);

            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();

            adaptador.Fill(ds);
            tabla = ds.Tables[0];
            DateItem[] dtm = new DateItem[tabla.Rows.Count];
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dtm[i] = new DateItem();
                DataRow filas = tabla.Rows[i];
                string[] f = filas["fecha"].ToString().Split(' ');
                string[] fc = f[0].Split('/');
                int año = int.Parse(fc[2]), mes = int.Parse(fc[1]), dia = int.Parse(fc[0]);
                dtm[i].Date = new DateTime(año, mes, dia);
                switch (filas["idUsuarioResponsable"].ToString())
                {
                    case "1":
                        dtm[i].BackColor1 = Color.Blue;
                        break;
                    case "2":
                        dtm[i].BackColor1 = Color.DarkGreen;
                        break;
                    case "3":
                        dtm[i].BackColor1 = Color.Purple;
                        break;
                    case "4":
                        dtm[i].BackColor1 = Color.OrangeRed;
                        break;
                }
            }
            mnt.AddDateInfo(dtm);
            cnt.Close();
        }

        FechaInfo fchin = new FechaInfo();
        public void Informacion(int dia, int mes, int año)
        {
            cnt.Open();
            string f = mes +"-" + dia + "-" + año;
            string consulta = "SELECT * FROM Actividad WHERE fecha='" + f + "';";
            SqlCommand cmd = new SqlCommand(consulta, cnt);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                string[] fech = dr[2].ToString().Split(' ');
                string datos = "La actividad " + dr[1] + " se llevará acabo el día " + fech[0] + " a las " + dr[3] + " en " +
                    dr[4] + ". " + "\n" + "El encargado de dicha actividad es " + dr[7] + " y se espera la participación de apróximadamente " +
                    dr[5] + " personas.", foto = dr[9].ToString();
                fchin.Info(datos, foto);
                fchin.ShowDialog();
            }else
            {
                MessageBox.Show("¡No hay nada en esta fecha!");
            }
            dr.Close();
            cnt.Close();
        }
    }
}