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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IniciarSesion inicia = new IniciarSesion();
        CControl ctrl = new CControl();
        private void Form1_Load(object sender, EventArgs e)
        {
            inicia.ShowDialog();
            ctrl.FechasColor(mntClnd);
        }
       
        ActividadNueva actNew = new ActividadNueva();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (actNew.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

        }
        
        Revision rv = new Revision();
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (CControl.idUsuario == 1)
            {
                rv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usted no tiene permiso de ver esto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la sesión?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No)
            {
                return;
            }
            CControl.idUsuario = 0;
            inicia.ShowDialog();
        }
        

        private void mntClnd_DayClick(object sender, Pabo.Calendar.DayClickEventArgs e)
        {
            string[] date = e.Date.ToString().Split('/');
            int d = int.Parse(date[0]), m = int.Parse(date[1]), a = int.Parse(date[2]);
            ctrl.Informacion(d, m, a);
        }
    }
}
