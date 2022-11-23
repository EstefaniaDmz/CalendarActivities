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
    public partial class LectorOficio : Form
    {
        public LectorOficio()
        {
            InitializeComponent();
        }
        public void Oficio(string pdf)
        {
            axAcroPDF1.src = pdf;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
