using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Actividades
{
    public partial class ActividadNueva : Form
    {
        CControl ctrl = new CControl();
        public ActividadNueva()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea limpiar el formulario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (Revision.idAct != 0)
            {
                Upd();
            }
            else { Limpiar(); }
            
        }

        private void ActividadNueva_Load(object sender, EventArgs e)
        {
            if (Revision.idAct != 0) { Upd(); }
            else { Insr(); }
            toTip.IsBalloon = true;
            toTip.SetToolTip(pctRespon, "Agregar imágen del encargado");
            toTip.SetToolTip(btnClear, "Limpiar formulario");
            toTip.SetToolTip(btnDo, "Agregar actividad nueva");
            toTip.SetToolTip(txtTimeAct, "Introducir en formato de 24 horas (hh:mm)");
            toTip.SetToolTip(txtFechAct, "Introducir una fecha valida (dd-mm-aaaa)");
            
        }
        private void Insr()
        {
            Limpiar();
            cmbRespon.SelectedIndex = (CControl.idUsuario - 1);
            if (CControl.idUsuario == 4)
            {
                cmbAcade.Visible = true;
                lblAcademia.Visible = true;
            }
            else
            {
                cmbAcade.Visible = false;
                lblAcademia.Visible = false;
            }
        }
        private void Limpiar()
        {
            txtCant.Clear();
            txtFechAct.Text = "mm-dd-aaaa";
            txtLugar.Clear();
            txtNomAct.Clear();
            txtNomEnc.Clear();
            txtOficio.Clear();
            txtTimeAct.Text = "hh:mm";
            pctRespon.Image = Properties.Resources._1814111_image_photograph_picture_icon;
            cmbAcade.SelectedIndex = -1;
            cmbRespon.SelectedIndex = (CControl.idUsuario-1);
            txtNomAct.Focus();
            img = "";
            ofc = "";
        }
        string img;
        string ofc;
        private void pctRespon_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            pctRespon.Image = Image.FromFile(ofd.FileName);
            img = ofd.FileName;
        }

        private void cmbRespon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRespon.SelectedIndex == 3)
            {
                cmbAcade.Visible = true;
                cmbAcade.SelectedIndex = -1;
                lblAcademia.Visible = true;
            }
            else
            {
                cmbAcade.Visible = false;
                lblAcademia.Visible = false;
            }
        }

        private void btnDelImg_Click(object sender, EventArgs e)
        {
            pctRespon.Image = Properties.Resources._1814111_image_photograph_picture_icon;
            img = "";
        }

        private void btnExamDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files|*.pdf";
            if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            txtOficio.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
            ofc = ofd.FileName;
        }

        private void btnDelDoc_Click(object sender, EventArgs e)
        {
            txtOficio.Clear();
            ofc = "";
        }

        private void txtFechAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '-' || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                toTip.Show("Solo se permiten números y guiones", txtFechAct, 3000);
                e.Handled = true;
                toTip.SetToolTip(txtFechAct, "Introducir una fecha valida (mm-dd-aaaa) o (aaaa-mm-dd)");
            }
            
        }

        private void txtTimeAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ':' || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                toTip.Show("Solo se permiten números y dos puntos", txtTimeAct, 3000);
                e.Handled = true;
                toTip.SetToolTip(txtTimeAct, "Introducir en formato de 24 horas (hh:mm)");
            }
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                toTip.Show("Solo se permiten números positivos", txtCant, 3000);
                e.Handled = true;
            }
        }
        
        private void Upd()
        {
            string datos = ctrl.Modi(Revision.idAct);
            string[] v = datos.Split('|');
            txtNomAct.Text = v[1];
            string[] f = v[2].Split(' ');
            string[] fc = f[0].Split('/');
            string date = fc[1] + "-" + fc[0] + "-" + fc[2];
            txtFechAct.Text = date;
            txtTimeAct.Text = v[3];
            txtLugar.Text = v[4];
            txtCant.Text = v[5];
            txtOficio.Text = v[6];
            txtNomEnc.Text = v[7];
            cmbRespon.SelectedIndex = int.Parse(v[10]) - 1;
            if (v[10] == "4")
            {
                cmbAcade.Text = v[8] ;
            }
            pctRespon.Image = Image.FromFile(v[9]);
            ofc = v[6];
            img = v[9];
        }
        private void btnDo_Click(object sender, EventArgs e)
        {
            string aca = "N/A";
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        toTip.Show("Favor de no dejar vacío el campo", textBox, 3000);
                        textBox.Focus();
                        return;
                    }
                }
            }
            if (img == "")
            {
                toTip.Show("Favor de agregar imagen", pctRespon, 3000);
                pctRespon.Focus();
                return;
            }
            if( cmbAcade.Visible == true && cmbAcade.SelectedIndex == -1)
            {
                toTip.Show("Favor de seleccionar especialidad", cmbAcade, 3000);
                cmbAcade.Focus();
                return;
            }
            if (cmbAcade.SelectedIndex != -1 && cmbAcade.Visible == true)
            {
                aca = cmbAcade.Text;
            }
            if (Revision.idAct == 0) 
            { 
                ctrl.InsertarActividad(txtNomAct.Text, txtFechAct.Text, txtTimeAct.Text, txtLugar.Text, txtCant.Text, (Convert.ToInt32(cmbRespon.SelectedIndex) + 1), ofc, txtNomEnc.Text, aca, img); 
            }
            else
            {
                ctrl.Actualizar(txtNomAct.Text, txtFechAct.Text, txtTimeAct.Text, txtLugar.Text, txtCant.Text, (Convert.ToInt32(cmbRespon.SelectedIndex) + 1), ofc, txtNomEnc.Text, aca, img, Revision.idAct);
            }
            
            
            this.Close();
        }

        private void txtFechAct_Click(object sender, EventArgs e)
        {
            if (txtFechAct.Text == "mm-dd-aaaa")
            {
                txtFechAct.Text = "";
            }
        }

        private void txtTimeAct_Click(object sender, EventArgs e)
        {
            if(txtTimeAct.Text == "hh:mm")
            {
                txtTimeAct.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
