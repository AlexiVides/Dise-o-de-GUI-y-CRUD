using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTienda
{
    public partial class MenuStrip : Form
    {
        public MenuStrip()
        {
            InitializeComponent();
        }

        private void activosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void desactivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDesactivos formDesactivos = new FormDesactivos();  
            formDesactivos.Show();
        }
    }
}
