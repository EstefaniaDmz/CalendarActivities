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
    public partial class Imagen : Form
    {
        public Imagen()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            pctb.Image = null;
        }
        
        public void Img(string pic)
        {
            pctb.Image = Image.FromFile(pic);
        }

        private void Imagen_Load(object sender, EventArgs e)
        {
            
        }
    }
}
