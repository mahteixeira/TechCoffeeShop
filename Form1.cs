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
    public partial class Form1 : Form
    {
        string produto;
        double valor;
        int quantidade = 0;
        double preco;
        double total;
        int pedido = 1;

        public Form1()
        {
            InitializeComponent();
            lblCliente.Text = "Mesa:" + VariavelGlobal.mesa;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seu pedido foi enviado e logo estará com você ;)", "Pedido Enviado!!");
            listPedidos.Items.Clear();
            produto = "";
            valor = 0;
            preco = 0;
            quantidade = 0;
            total = 0;
            lblvalor.Text = "R$";
            lblProduto.Text = "";
            lblinfo.Text = "";
            lblqnt.Text = "0";
            lblResultado.Text = "";
            pedido++;
            lblPedido.Text = "Pedido: " + pedido;
            groupBox1.Enabled = false;  

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnAmericano_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            produto = "AMERICANO";
            lblProduto.Text = produto;
            lblinfo.Text = " Doses de expresso com água \r\n quente ";
            lblqnt.Text = quantidade.ToString();
            valor = 7;
            lblvalor.Text = valor.ToString("C");
        }

        private void btnmais_Click(object sender, EventArgs e)
        {
            quantidade++;
            lblqnt.Text = quantidade.ToString();
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            quantidade--;
            lblqnt.Text = quantidade.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            lblvalor.Text = "R$";
            lblProduto.Text = "";
            lblinfo.Text = "";
            lblqnt.Text = "0";
            preco = valor * quantidade;
            listPedidos.Items.Add(produto + "  -  " + quantidade + "  -  " + preco.ToString("C"));
            total = total + preco;
            lblResultado.Text = total.ToString("C");
        }

        private void btnCafeLeite2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            produto = "CAFÉ COM LEITE";
            lblProduto.Text = produto;
            lblinfo.Text = " Café e leitekkkkkk ";
            lblqnt.Text = quantidade.ToString();
            valor = 5;
            lblvalor.Text = valor.ToString("C");
        }

        private void btnLatte2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            produto = "LATTE";
            lblProduto.Text = produto;
            lblinfo.Text = " Café expresso com uma quantidade \r\n generosa de leite ou sua espuma \r\n no topo do copo ";
            lblqnt.Text = quantidade.ToString();
            valor = 7;
            lblvalor.Text = valor.ToString("C");
        }

        private void btnMachiatto2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            produto = "MACHIATTO";
            lblProduto.Text = produto;
            lblinfo.Text = " Espresso servido com um pouco \r\n de leite. Aqui no Brasil, também é \r\n conhecido como “café com \r\n espuminha”. ";
            lblqnt.Text = quantidade.ToString();
            valor = 8;
            lblvalor.Text = valor.ToString("C");
        }

        private void btnCappuccino2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            produto = "CAPPUCCINO";
            lblProduto.Text = produto;
            lblinfo.Text = " Espresso + partes iguais de leite \r\n e creme de leite.";
            lblqnt.Text = quantidade.ToString();
            valor = 6;
            lblvalor.Text = valor.ToString("C");
        }

        private void btnBrownie2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            produto = "BROWNIE";
            lblProduto.Text = produto;
            lblinfo.Text = " Bolo de chocolate, achatado e \r\n servido em pequenas porções de \r\n formato quadrado ou retangular.";
            lblqnt.Text = quantidade.ToString();
            valor = 12;
            lblvalor.Text = valor.ToString("C");
        }

        private void btnCookie2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            produto = "COOKIE";
            lblProduto.Text = produto;
            lblinfo.Text = " Bolacha com gotas de chocolate";
            lblqnt.Text = quantidade.ToString();
            valor = 10;
            lblvalor.Text = valor.ToString("C");
        }

        private void btnDonut2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            produto = "DONUT";
            lblProduto.Text = produto;
            lblinfo.Text = " Pequeno bolo em forma de rosca, \r\n popular nos Estados Unidos";
            lblqnt.Text = quantidade.ToString();
            valor = 7;
            lblvalor.Text = valor.ToString("C");
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listPedidos.Items.Clear();
            produto = "";
            valor = 0;
            preco = 0;
            quantidade = 0;
            total = 0;
            lblvalor.Text = "R$";
            lblProduto.Text = "";
            lblinfo.Text = "";
            lblqnt.Text = "0";
            lblResultado.Text = "";
            groupBox1.Enabled=false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}

