namespace Projeto_03Dez
{
    partial class ConsultaFuncionario
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
            this.btnConsultaFuncionario = new System.Windows.Forms.Button();
            this.txtIDFuncionario = new System.Windows.Forms.TextBox();
            this.GridConsultaFuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultaFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID Funcionário:";
            // 
            // btnConsultaFuncionario
            // 
            this.btnConsultaFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaFuncionario.Location = new System.Drawing.Point(97, 75);
            this.btnConsultaFuncionario.Name = "btnConsultaFuncionario";
            this.btnConsultaFuncionario.Size = new System.Drawing.Size(99, 38);
            this.btnConsultaFuncionario.TabIndex = 34;
            this.btnConsultaFuncionario.Text = "Consultar";
            this.btnConsultaFuncionario.UseVisualStyleBackColor = true;
            // 
            // txtIDFuncionario
            // 
            this.txtIDFuncionario.Location = new System.Drawing.Point(97, 49);
            this.txtIDFuncionario.Name = "txtIDFuncionario";
            this.txtIDFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtIDFuncionario.TabIndex = 32;
            // 
            // GridConsultaFuncionario
            // 
            this.GridConsultaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridConsultaFuncionario.Location = new System.Drawing.Point(246, 12);
            this.GridConsultaFuncionario.Name = "GridConsultaFuncionario";
            this.GridConsultaFuncionario.Size = new System.Drawing.Size(339, 320);
            this.GridConsultaFuncionario.TabIndex = 31;
            // 
            // ConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultaFuncionario);
            this.Controls.Add(this.txtIDFuncionario);
            this.Controls.Add(this.GridConsultaFuncionario);
            this.Name = "ConsultaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultaFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultaFuncionario;
        private System.Windows.Forms.TextBox txtIDFuncionario;
        private System.Windows.Forms.DataGridView GridConsultaFuncionario;
    }
}