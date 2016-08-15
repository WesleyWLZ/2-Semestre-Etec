namespace Projeto_03Dez
{
    partial class ConsultaProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultaProduto = new System.Windows.Forms.Button();
            this.txtIDProduto = new System.Windows.Forms.TextBox();
            this.GridConsultaProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID Produto:";
            // 
            // btnConsultaProduto
            // 
            this.btnConsultaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaProduto.Location = new System.Drawing.Point(104, 59);
            this.btnConsultaProduto.Name = "btnConsultaProduto";
            this.btnConsultaProduto.Size = new System.Drawing.Size(99, 38);
            this.btnConsultaProduto.TabIndex = 38;
            this.btnConsultaProduto.Text = "Consultar";
            this.btnConsultaProduto.UseVisualStyleBackColor = true;
            this.btnConsultaProduto.Click += new System.EventHandler(this.btnConsultaProduto_Click);
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.Location = new System.Drawing.Point(104, 33);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(100, 20);
            this.txtIDProduto.TabIndex = 37;
            // 
            // GridConsultaProdutos
            // 
            this.GridConsultaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridConsultaProdutos.Location = new System.Drawing.Point(247, 12);
            this.GridConsultaProdutos.Name = "GridConsultaProdutos";
            this.GridConsultaProdutos.Size = new System.Drawing.Size(339, 320);
            this.GridConsultaProdutos.TabIndex = 36;
            // 
            // ConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultaProduto);
            this.Controls.Add(this.txtIDProduto);
            this.Controls.Add(this.GridConsultaProdutos);
            this.Name = "ConsultaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaProduto";
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultaProduto;
        private System.Windows.Forms.TextBox txtIDProduto;
        private System.Windows.Forms.DataGridView GridConsultaProdutos;
    }
}