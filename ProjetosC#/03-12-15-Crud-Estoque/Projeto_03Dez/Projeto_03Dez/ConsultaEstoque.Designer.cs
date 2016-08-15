namespace Projeto_03Dez
{
    partial class ConsultaEstoque
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultaBaixa = new System.Windows.Forms.Button();
            this.txtIDProduto = new System.Windows.Forms.TextBox();
            this.txtIDFuncionario = new System.Windows.Forms.TextBox();
            this.GridConsultaEstoque = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultaEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "ID Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID Funcionário:";
            // 
            // btnConsultaBaixa
            // 
            this.btnConsultaBaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaBaixa.Location = new System.Drawing.Point(101, 127);
            this.btnConsultaBaixa.Name = "btnConsultaBaixa";
            this.btnConsultaBaixa.Size = new System.Drawing.Size(99, 38);
            this.btnConsultaBaixa.TabIndex = 28;
            this.btnConsultaBaixa.Text = "Consultar";
            this.btnConsultaBaixa.UseVisualStyleBackColor = true;
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.Location = new System.Drawing.Point(101, 75);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(100, 20);
            this.txtIDProduto.TabIndex = 26;
            // 
            // txtIDFuncionario
            // 
            this.txtIDFuncionario.Location = new System.Drawing.Point(101, 49);
            this.txtIDFuncionario.Name = "txtIDFuncionario";
            this.txtIDFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtIDFuncionario.TabIndex = 25;
            // 
            // GridConsultaEstoque
            // 
            this.GridConsultaEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridConsultaEstoque.Location = new System.Drawing.Point(229, 12);
            this.GridConsultaEstoque.Name = "GridConsultaEstoque";
            this.GridConsultaEstoque.Size = new System.Drawing.Size(339, 320);
            this.GridConsultaEstoque.TabIndex = 24;
            // 
            // ConsultaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 347);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultaBaixa);
            this.Controls.Add(this.txtIDProduto);
            this.Controls.Add(this.txtIDFuncionario);
            this.Controls.Add(this.GridConsultaEstoque);
            this.Name = "ConsultaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultaEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultaBaixa;
        private System.Windows.Forms.TextBox txtIDProduto;
        private System.Windows.Forms.TextBox txtIDFuncionario;
        private System.Windows.Forms.DataGridView GridConsultaEstoque;
    }
}