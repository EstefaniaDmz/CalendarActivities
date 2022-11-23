using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Actividades
{
    public partial class IniciarSesion : Form
    {
        CControl ctrl = new CControl();
        public IniciarSesion()
        {
            InitializeComponent();
        }
        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            DateTime dd = DateTime.Now;
            lblFecha.Text = dd.ToString("dd-MM-yyyy");
            txtPass.Clear();
            txtUser.Clear();
        }
        int intentos = 0;
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool acceso;
            if (e.KeyChar == (char)(Keys.Enter))
            {
                if (intentos<5)
                {
                    acceso = ctrl.InicioSesion(txtUser, txtPass);
                    if (acceso == true)
                    {
                        MessageBox.Show("Bienvenido al sistema usuario " + CControl.idUsuario);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos, favor de verificar los datos");
                        txtUser.Clear();
                        txtPass.Clear();
                        txtUser.Focus();
                        intentos++;
                    }
                }
                else
                {
                    MessageBox.Show("Ha excedido el número de intentos, la aplicación se cerrará");
                    Application.OpenForms["Form1"].Close();
                }
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            txtUser.Text = txtUser.Text.ToLower();
        }
    }
}