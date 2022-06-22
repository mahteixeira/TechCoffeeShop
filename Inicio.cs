using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211078
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            VariavelGlobal.mesa = "01";
            Form1 j2 = new Form1();
            j2.Show();
            this.Hide();
        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {
            VariavelGlobal.mesa = "02";
            Form1 j2 = new Form1();
            j2.Show();
            this.Hide();
        }

        private void btnMesa3_Click(object sender, EventArgs e)
        {
            VariavelGlobal.mesa = "03";
            Form1 j2 = new Form1();
            j2.Show();
            this.Hide();
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            VariavelGlobal.mesa = "04";
            Form1 j2 = new Form1();
            j2.Show();
            this.Hide();
        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
            VariavelGlobal.mesa = "05";
            Form1 j2 = new Form1();
            j2.Show();
            this.Hide();
        }

        private void btnMesa6_Click(object sender, EventArgs e)
        {
            VariavelGlobal.mesa = "06";
            Form1 j2 = new Form1();
            j2.Show();
            this.Hide();
        }
    }
}
