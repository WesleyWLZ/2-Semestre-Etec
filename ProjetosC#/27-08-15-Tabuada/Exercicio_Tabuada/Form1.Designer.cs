namespace Exercicio_Tabuada
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtMultiplicar = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.ltbLista = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Black;
            this.lblNumero.ForeColor = System.Drawing.Color.White;
            this.lblNumero.Location = new System.Drawing.Point(35, 59);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(94, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Digite um Número:";
            this.lblNumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMultiplicar
            // 
            this.txtMultiplicar.BackColor = System.Drawing.Color.Black;
            this.txtMultiplicar.ForeColor = System.Drawing.Color.White;
            this.txtMultiplicar.Location = new System.Drawing.Point(135, 56);
            this.txtMultiplicar.Name = "txtMultiplicar";
            this.txtMultiplicar.Size = new System.Drawing.Size(71, 20);
            this.txtMultiplicar.TabIndex = 1;
            this.txtMultiplicar.TextChanged += new System.EventHandler(this.txtMultiplicar_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCalcular.Location = new System.Drawing.Point(54, 94);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Multiplicar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // ltbLista
            // 
            this.ltbLista.BackColor = System.Drawing.Color.Black;
            this.ltbLista.ForeColor = System.Drawing.Color.White;
            this.ltbLista.FormattingEnabled = true;
            this.ltbLista.Location = new System.Drawing.Point(66, 123);
            this.ltbLista.Name = "ltbLista";
            this.ltbLista.Size = new System.Drawing.Size(140, 147);
            this.ltbLista.TabIndex = 3;
            this.ltbLista.SelectedIndexChanged += new System.EventHandler(this.ltbLista_SelectedIndexChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLimpar.Location = new System.Drawing.Point(136, 94);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Exercicio_Tabuada.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(284, 294);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.ltbLista);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMultiplicar);
            this.Controls.Add(this.lblNumero);
            this.Name = "Form1";
            this.Text = "Tabuada 1.0.5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtMultiplicar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox ltbLista;
        private System.Windows.Forms.Button btnLimpar;
    }
}

