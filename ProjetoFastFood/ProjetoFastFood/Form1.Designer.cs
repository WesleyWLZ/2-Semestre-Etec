namespace ProjetoFastFood
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTroco = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.llblTotal = new System.Windows.Forms.Label();
            this.ltbLista = new System.Windows.Forms.ListBox();
            this.btnCadastroClientes = new System.Windows.Forms.Button();
            this.btnSobremesas = new System.Windows.Forms.Button();
            this.btnBebidas = new System.Windows.Forms.Button();
            this.btnLanches = new System.Windows.Forms.Button();
            this.btnCombos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecebido = new System.Windows.Forms.TextBox();
            this.btnTroco = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.BackColor = System.Drawing.Color.White;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTroco.Location = new System.Drawing.Point(517, 442);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(73, 18);
            this.lblTroco.TabIndex = 72;
            this.lblTroco.Text = "TROCO:";
            // 
            // txtTroco
            // 
            this.txtTroco.Location = new System.Drawing.Point(596, 440);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(100, 20);
            this.txtTroco.TabIndex = 71;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(596, 285);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 68;
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPedido.Location = new System.Drawing.Point(550, 496);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(146, 53);
            this.btnFinalizarPedido.TabIndex = 67;
            this.btnFinalizarPedido.Text = "Finalizar Pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = false;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // llblTotal
            // 
            this.llblTotal.AutoSize = true;
            this.llblTotal.BackColor = System.Drawing.Color.White;
            this.llblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.llblTotal.Location = new System.Drawing.Point(522, 285);
            this.llblTotal.Name = "llblTotal";
            this.llblTotal.Size = new System.Drawing.Size(69, 20);
            this.llblTotal.TabIndex = 66;
            this.llblTotal.Text = "TOTAL:";
            // 
            // ltbLista
            // 
            this.ltbLista.BackColor = System.Drawing.SystemColors.Window;
            this.ltbLista.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ltbLista.FormattingEnabled = true;
            this.ltbLista.Location = new System.Drawing.Point(718, 233);
            this.ltbLista.Name = "ltbLista";
            this.ltbLista.Size = new System.Drawing.Size(193, 316);
            this.ltbLista.TabIndex = 65;
            this.ltbLista.SelectedIndexChanged += new System.EventHandler(this.ltbLista_SelectedIndexChanged);
            // 
            // btnCadastroClientes
            // 
            this.btnCadastroClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroClientes.Location = new System.Drawing.Point(18, 19);
            this.btnCadastroClientes.Name = "btnCadastroClientes";
            this.btnCadastroClientes.Size = new System.Drawing.Size(160, 87);
            this.btnCadastroClientes.TabIndex = 64;
            this.btnCadastroClientes.Text = "Cadastro Funcionário";
            this.btnCadastroClientes.UseVisualStyleBackColor = true;
            this.btnCadastroClientes.Click += new System.EventHandler(this.btnCadastroClientes_Click);
            // 
            // btnSobremesas
            // 
            this.btnSobremesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobremesas.Location = new System.Drawing.Point(682, 20);
            this.btnSobremesas.Name = "btnSobremesas";
            this.btnSobremesas.Size = new System.Drawing.Size(160, 87);
            this.btnSobremesas.TabIndex = 63;
            this.btnSobremesas.Text = "Acompanhamentos";
            this.btnSobremesas.UseVisualStyleBackColor = true;
            this.btnSobremesas.Click += new System.EventHandler(this.btnSobremesas_Click);
            // 
            // btnBebidas
            // 
            this.btnBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBebidas.Location = new System.Drawing.Point(516, 19);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(160, 87);
            this.btnBebidas.TabIndex = 61;
            this.btnBebidas.Text = "Bebidas";
            this.btnBebidas.UseVisualStyleBackColor = true;
            this.btnBebidas.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // btnLanches
            // 
            this.btnLanches.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanches.Location = new System.Drawing.Point(184, 19);
            this.btnLanches.Name = "btnLanches";
            this.btnLanches.Size = new System.Drawing.Size(160, 87);
            this.btnLanches.TabIndex = 60;
            this.btnLanches.Text = "Lanches";
            this.btnLanches.UseVisualStyleBackColor = true;
            this.btnLanches.Click += new System.EventHandler(this.btnLanches_Click);
            // 
            // btnCombos
            // 
            this.btnCombos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombos.Location = new System.Drawing.Point(350, 19);
            this.btnCombos.Name = "btnCombos";
            this.btnCombos.Size = new System.Drawing.Size(160, 87);
            this.btnCombos.TabIndex = 73;
            this.btnCombos.Text = "Combos";
            this.btnCombos.UseVisualStyleBackColor = true;
            this.btnCombos.Click += new System.EventHandler(this.btnCombos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.btnCadastroClientes);
            this.groupBox1.Controls.Add(this.btnCombos);
            this.groupBox1.Controls.Add(this.btnLanches);
            this.groupBox1.Controls.Add(this.btnBebidas);
            this.groupBox1.Controls.Add(this.btnSobremesas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 127);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(487, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 75;
            this.label1.Text = "RECEBIDO: ";
            // 
            // txtRecebido
            // 
            this.txtRecebido.Location = new System.Drawing.Point(596, 323);
            this.txtRecebido.Name = "txtRecebido";
            this.txtRecebido.Size = new System.Drawing.Size(100, 20);
            this.txtRecebido.TabIndex = 76;
            this.txtRecebido.TextChanged += new System.EventHandler(this.txtRecebido_TextChanged);
            // 
            // btnTroco
            // 
            this.btnTroco.BackColor = System.Drawing.Color.Transparent;
            this.btnTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroco.Location = new System.Drawing.Point(550, 358);
            this.btnTroco.Name = "btnTroco";
            this.btnTroco.Size = new System.Drawing.Size(146, 53);
            this.btnTroco.TabIndex = 77;
            this.btnTroco.Text = "Calcular Troco";
            this.btnTroco.UseVisualStyleBackColor = true;
            this.btnTroco.Click += new System.EventHandler(this.btnTroco_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 626);
            this.Controls.Add(this.btnTroco);
            this.Controls.Add(this.txtRecebido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.llblTotal);
            this.Controls.Add(this.ltbLista);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mister Lanches";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ltbLista_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.Label llblTotal;
        private System.Windows.Forms.ListBox ltbLista;
        private System.Windows.Forms.Button btnCadastroClientes;
        private System.Windows.Forms.Button btnSobremesas;
        private System.Windows.Forms.Button btnBebidas;
        private System.Windows.Forms.Button btnLanches;
        private System.Windows.Forms.Button btnCombos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecebido;
        private System.Windows.Forms.Button btnTroco;
    }
}

