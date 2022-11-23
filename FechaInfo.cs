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
    public partial class FechaInfo : Form
    {
        public FechaInfo()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pctResp.Image = null;
            txtInfo.Clear();
            this.Close();
        }

        public void Info(string texto, string foto)
        {
            pctResp.Image = Image.FromFile(foto);
            txtInfo.Text = texto;
            
        }
        private void FechaInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
