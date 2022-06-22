namespace _211078
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.listPedidos = new System.Windows.Forms.ListBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAmericano = new System.Windows.Forms.Button();
            this.btnCafeLeite2 = new System.Windows.Forms.Button();
            this.btnCappuccino2 = new System.Windows.Forms.Button();
            this.btnMachiatto2 = new System.Windows.Forms.Button();
            this.btnLatte2 = new System.Windows.Forms.Button();
            this.btnBrownie2 = new System.Windows.Forms.Button();
            this.btnCookie2 = new System.Windows.Forms.Button();
            this.btnDonut2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnmais = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.lblqnt = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1332, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = "ᴛᴇᴄʜ ᴄᴏғғᴇᴇ sʜᴏᴘ ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\r" +
    "\n\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listPedidos
            // 
            this.listPedidos.BackColor = System.Drawing.Color.White;
            this.listPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPedidos.FormattingEnabled = true;
            this.listPedidos.ItemHeight = 24;
            this.listPedidos.Location = new System.Drawing.Point(878, 132);
            this.listPedidos.Name = "listPedidos";
            this.listPedidos.Size = new System.Drawing.Size(374, 530);
            this.listPedidos.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Black;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Linen;
            this.btnEnviar.Location = new System.Drawing.Point(1100, 749);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(106, 44);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar Pedido";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Black;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Linen;
            this.btnLimpar.Location = new System.Drawing.Point(937, 749);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 44);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar Produtos";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(859, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "✎﹏﹏﹏ᴘᴇᴅɪᴅᴏs ";
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1209, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(57, 36);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 55);
            this.label3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 55);
            this.label4.TabIndex = 12;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(12, 776);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(99, 24);
            this.lblPedido.TabIndex = 13;
            this.lblPedido.Text = "Pedido: 1";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(12, 749);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(83, 24);
            this.lblCliente.TabIndex = 14;
            this.lblCliente.Text = "Mesa: 3";
            this.lblCliente.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(874, 684);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(117, 24);
            this.lblValorTotal.TabIndex = 15;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultado.Location = new System.Drawing.Point(997, 688);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 34);
            this.lblResultado.TabIndex = 16;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 680);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnAmericano
            // 
            this.btnAmericano.BackColor = System.Drawing.Color.Bisque;
            this.btnAmericano.FlatAppearance.BorderSize = 0;
            this.btnAmericano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmericano.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmericano.Location = new System.Drawing.Point(401, 260);
            this.btnAmericano.Name = "btnAmericano";
            this.btnAmericano.Size = new System.Drawing.Size(36, 36);
            this.btnAmericano.TabIndex = 18;
            this.btnAmericano.Text = "+";
            this.btnAmericano.UseVisualStyleBackColor = false;
            this.btnAmericano.Click += new System.EventHandler(this.btnAmericano_Click);
            // 
            // btnCafeLeite2
            // 
            this.btnCafeLeite2.BackColor = System.Drawing.Color.Bisque;
            this.btnCafeLeite2.FlatAppearance.BorderSize = 0;
            this.btnCafeLeite2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCafeLeite2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCafeLeite2.Location = new System.Drawing.Point(402, 312);
            this.btnCafeLeite2.Name = "btnCafeLeite2";
            this.btnCafeLeite2.Size = new System.Drawing.Size(36, 36);
            this.btnCafeLeite2.TabIndex = 19;
            this.btnCafeLeite2.Text = "+";
            this.btnCafeLeite2.UseVisualStyleBackColor = false;
            this.btnCafeLeite2.Click += new System.EventHandler(this.btnCafeLeite2_Click);
            // 
            // btnCappuccino2
            // 
            this.btnCappuccino2.BackColor = System.Drawing.Color.Bisque;
            this.btnCappuccino2.FlatAppearance.BorderSize = 0;
            this.btnCappuccino2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCappuccino2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCappuccino2.Location = new System.Drawing.Point(402, 462);
            this.btnCappuccino2.Name = "btnCappuccino2";
            this.btnCappuccino2.Size = new System.Drawing.Size(36, 36);
            this.btnCappuccino2.TabIndex = 20;
            this.btnCappuccino2.Text = "+";
            this.btnCappuccino2.UseVisualStyleBackColor = false;
            this.btnCappuccino2.Click += new System.EventHandler(this.btnCappuccino2_Click);
            // 
            // btnMachiatto2
            // 
            this.btnMachiatto2.BackColor = System.Drawing.Color.Bisque;
            this.btnMachiatto2.FlatAppearance.BorderSize = 0;
            this.btnMachiatto2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMachiatto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachiatto2.Location = new System.Drawing.Point(402, 412);
            this.btnMachiatto2.Name = "btnMachiatto2";
            this.btnMachiatto2.Size = new System.Drawing.Size(36, 36);
            this.btnMachiatto2.TabIndex = 21;
            this.btnMachiatto2.Text = "+";
            this.btnMachiatto2.UseVisualStyleBackColor = false;
            this.btnMachiatto2.Click += new System.EventHandler(this.btnMachiatto2_Click);
            // 
            // btnLatte2
            // 
            this.btnLatte2.BackColor = System.Drawing.Color.Bisque;
            this.btnLatte2.FlatAppearance.BorderSize = 0;
            this.btnLatte2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLatte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLatte2.Location = new System.Drawing.Point(402, 364);
            this.btnLatte2.Name = "btnLatte2";
            this.btnLatte2.Size = new System.Drawing.Size(36, 36);
            this.btnLatte2.TabIndex = 22;
            this.btnLatte2.Text = "+";
            this.btnLatte2.UseVisualStyleBackColor = false;
            this.btnLatte2.Click += new System.EventHandler(this.btnLatte2_Click);
            // 
            // btnBrownie2
            // 
            this.btnBrownie2.BackColor = System.Drawing.Color.Bisque;
            this.btnBrownie2.FlatAppearance.BorderSize = 0;
            this.btnBrownie2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrownie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrownie2.Location = new System.Drawing.Point(402, 554);
            this.btnBrownie2.Name = "btnBrownie2";
            this.btnBrownie2.Size = new System.Drawing.Size(36, 36);
            this.btnBrownie2.TabIndex = 25;
            this.btnBrownie2.Text = "+";
            this.btnBrownie2.UseVisualStyleBackColor = false;
            this.btnBrownie2.Click += new System.EventHandler(this.btnBrownie2_Click);
            // 
            // btnCookie2
            // 
            this.btnCookie2.BackColor = System.Drawing.Color.Bisque;
            this.btnCookie2.FlatAppearance.BorderSize = 0;
            this.btnCookie2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCookie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCookie2.Location = new System.Drawing.Point(402, 602);
            this.btnCookie2.Name = "btnCookie2";
            this.btnCookie2.Size = new System.Drawing.Size(36, 36);
            this.btnCookie2.TabIndex = 24;
            this.btnCookie2.Text = "+";
            this.btnCookie2.UseVisualStyleBackColor = false;
            this.btnCookie2.Click += new System.EventHandler(this.btnCookie2_Click);
            // 
            // btnDonut2
            // 
            this.btnDonut2.BackColor = System.Drawing.Color.Bisque;
            this.btnDonut2.FlatAppearance.BorderSize = 0;
            this.btnDonut2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonut2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonut2.Location = new System.Drawing.Point(402, 652);
            this.btnDonut2.Name = "btnDonut2";
            this.btnDonut2.Size = new System.Drawing.Size(36, 36);
            this.btnDonut2.TabIndex = 23;
            this.btnDonut2.Text = "+";
            this.btnDonut2.UseVisualStyleBackColor = false;
            this.btnDonut2.Click += new System.EventHandler(this.btnDonut2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.btnmais);
            this.groupBox1.Controls.Add(this.btnmenos);
            this.groupBox1.Controls.Add(this.lblqnt);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.lblinfo);
            this.groupBox1.Controls.Add(this.lblProduto);
            this.groupBox1.Controls.Add(this.lblvalor);
            this.groupBox1.Enabled = false;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(514, 132);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(297, 529);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(4, 266);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(111, 34);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "VALOR:";
            // 
            // btnmais
            // 
            this.btnmais.BackColor = System.Drawing.Color.Bisque;
            this.btnmais.FlatAppearance.BorderSize = 0;
            this.btnmais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmais.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmais.Location = new System.Drawing.Point(196, 417);
            this.btnmais.Name = "btnmais";
            this.btnmais.Size = new System.Drawing.Size(38, 31);
            this.btnmais.TabIndex = 5;
            this.btnmais.Text = "+";
            this.btnmais.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmais.UseVisualStyleBackColor = false;
            this.btnmais.Click += new System.EventHandler(this.btnmais_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.BackColor = System.Drawing.Color.Bisque;
            this.btnmenos.FlatAppearance.BorderSize = 0;
            this.btnmenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenos.Location = new System.Drawing.Point(73, 414);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(38, 31);
            this.btnmenos.TabIndex = 4;
            this.btnmenos.Text = "-";
            this.btnmenos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmenos.UseVisualStyleBackColor = false;
            this.btnmenos.Click += new System.EventHandler(this.btnmenos_Click);
            // 
            // lblqnt
            // 
            this.lblqnt.AutoSize = true;
            this.lblqnt.BackColor = System.Drawing.Color.Bisque;
            this.lblqnt.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqnt.Location = new System.Drawing.Point(132, 418);
            this.lblqnt.Name = "lblqnt";
            this.lblqnt.Size = new System.Drawing.Size(34, 37);
            this.lblqnt.TabIndex = 3;
            this.lblqnt.Text = "0";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Black;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Linen;
            this.btnadd.Location = new System.Drawing.Point(70, 468);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(170, 37);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Adicionar Produto";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(-7, 87);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(0, 21);
            this.lblinfo.TabIndex = 1;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(0, 51);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(0, 37);
            this.lblProduto.TabIndex = 0;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Microsoft Tai Le", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.Location = new System.Drawing.Point(102, 263);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(77, 55);
            this.lblvalor.TabIndex = 7;
            this.lblvalor.Text = "R$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1263, 820);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrownie2);
            this.Controls.Add(this.btnCookie2);
            this.Controls.Add(this.btnDonut2);
            this.Controls.Add(this.btnLatte2);
            this.Controls.Add(this.btnMachiatto2);
            this.Controls.Add(this.btnCappuccino2);
            this.Controls.Add(this.btnCafeLeite2);
            this.Controls.Add(this.btnAmericano);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.listPedidos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listPedidos;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAmericano;
        private System.Windows.Forms.Button btnCafeLeite2;
        private System.Windows.Forms.Button btnCappuccino2;
        private System.Windows.Forms.Button btnMachiatto2;
        private System.Windows.Forms.Button btnLatte2;
        private System.Windows.Forms.Button btnBrownie2;
        private System.Windows.Forms.Button btnCookie2;
        private System.Windows.Forms.Button btnDonut2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btnmais;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Label lblqnt;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblvalor;
    }
}

