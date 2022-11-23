using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividades
{
    public partial class Revision : Form
    {
        public Revision()
        {
            InitializeComponent();
        }

        CControl ctrl = new CControl();
        private void Revision_Load(object sender, EventArgs e)
        {
            ctrl.Mostrar(dgvTabla, 0);

        }
        internal static int idAct = 0;
        ActividadNueva ac = new ActividadNueva();
        Imagen img = new Imagen();
        LectorOficio ofc = new LectorOficio();
        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = dgvTabla.CurrentCell.ColumnIndex;
            switch (colum)
            {
                case 6:
                    ofc.Oficio(dgvTabla.Rows[e.RowIndex].Cells[6].Value.ToString());
                    ofc.ShowDialog();
                    break;
                case 9:
                    img.Img(dgvTabla.Rows[e.RowIndex].Cells[9].Value.ToString());
                    img.ShowDialog();
                    break;
                case 11:
                    if (MessageBox.Show("¿Desea aceptar el oficio?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    ctrl.Actualizar(dgvTabla.Rows[e.RowIndex].Cells[0].Value.ToString());
                    ctrl.Mostrar(dgvTabla, 0);
                    break;
                default:
                    if (MessageBox.Show("¿Desea modificar los datos?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.No)
                    {
                        return;
                    }
                    idAct = int.Parse(dgvTabla.Rows[e.RowIndex].Cells[0].Value.ToString());
                    ac.ShowDialog();
                    ctrl.Mostrar(dgvTabla, 0);
                    break;       
            }
            idAct = 0;
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

    }
}
