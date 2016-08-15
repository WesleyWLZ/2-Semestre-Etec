namespace Projeto_03Dez
{
    partial class CadastroProduto
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastroProduto = new System.Windows.Forms.Button();
            this.txtPrecoCadastro = new System.Windows.Forms.TextBox();
            this.txtQuantidadeCadastro = new System.Windows.Forms.TextBox();
            this.txtNomeCAdastro = new System.Windows.Forms.TextBox();
            this.GridCadastroProduto = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridCadastroProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Preço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quantidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome:";
            // 
            // btnCadastroProduto
            // 
            this.btnCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroProduto.Location = new System.Drawing.Point(114, 155);
            this.btnCadastroProduto.Name = "btnCadastroProduto";
            this.btnCadastroProduto.Size = new System.Drawing.Size(99, 38);
            this.btnCadastroProduto.TabIndex = 20;
            this.btnCadastroProduto.Text = "Cadastrar";
            this.btnCadastroProduto.UseVisualStyleBackColor = true;
            this.btnCadastroProduto.Click += new System.EventHandler(this.btnCadastroProduto_Click);
            // 
            // txtPrecoCadastro
            // 
            this.txtPrecoCadastro.Location = new System.Drawing.Point(113, 129);
            this.txtPrecoCadastro.Name = "txtPrecoCadastro";
            this.txtPrecoCadastro.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoCadastro.TabIndex = 19;
            // 
            // txtQuantidadeCadastro
            // 
            this.txtQuantidadeCadastro.Location = new System.Drawing.Point(114, 103);
            this.txtQuantidadeCadastro.Name = "txtQuantidadeCadastro";
            this.txtQuantidadeCadastro.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeCadastro.TabIndex = 18;
            // 
            // txtNomeCAdastro
            // 
            this.txtNomeCAdastro.Location = new System.Drawing.Point(114, 75);
            this.txtNomeCAdastro.Name = "txtNomeCAdastro";
            this.txtNomeCAdastro.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCAdastro.TabIndex = 17;
            // 
            // GridCadastroProduto
            // 
            this.GridCadastroProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCadastroProduto.Location = new System.Drawing.Point(234, 12);
            this.GridCadastroProduto.Name = "GridCadastroProduto";
            this.GridCadastroProduto.Size = new System.Drawing.Size(339, 320);
            this.GridCadastroProduto.TabIndex = 16;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(114, 49);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "ID:";
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 343);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastroProduto);
            this.Controls.Add(this.txtPrecoCadastro);
            this.Controls.Add(this.txtQuantidadeCadastro);
            this.Controls.Add(this.txtNomeCAdastro);
            this.Controls.Add(this.GridCadastroProduto);
            this.Name = "CadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroProduto";
            ((System.ComponentModel.ISupportInitialize)(this.GridCadastroProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastroProduto;
        private System.Windows.Forms.TextBox txtPrecoCadastro;
        private System.Windows.Forms.TextBox txtQuantidadeCadastro;
        private System.Windows.Forms.TextBox txtNomeCAdastro;
        private System.Windows.Forms.DataGridView GridCadastroProduto;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
    }
}