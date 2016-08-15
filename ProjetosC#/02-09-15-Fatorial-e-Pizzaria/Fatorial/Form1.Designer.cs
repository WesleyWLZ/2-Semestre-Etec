namespace Fatorial2
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
            this.btnFatorial = new System.Windows.Forms.Button();
            this.lblFatorial = new System.Windows.Forms.Label();
            this.txtFatorial = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFatorial
            // 
            this.btnFatorial.Location = new System.Drawing.Point(139, 29);
            this.btnFatorial.Name = "btnFatorial";
            this.btnFatorial.Size = new System.Drawing.Size(85, 23);
            this.btnFatorial.TabIndex = 0;
            this.btnFatorial.Text = "=";
            this.btnFatorial.UseVisualStyleBackColor = true;
            this.btnFatorial.Click += new System.EventHandler(this.btnFatorial_Click);
            // 
            // lblFatorial
            // 
            this.lblFatorial.AutoSize = true;
            this.lblFatorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatorial.Location = new System.Drawing.Point(111, 24);
            this.lblFatorial.Name = "lblFatorial";
            this.lblFatorial.Size = new System.Drawing.Size(22, 31);
            this.lblFatorial.TabIndex = 1;
            this.lblFatorial.Tag = "";
            this.lblFatorial.Text = "!";
            this.lblFatorial.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFatorial
            // 
            this.txtFatorial.Location = new System.Drawing.Point(26, 32);
            this.txtFatorial.Name = "txtFatorial";
            this.txtFatorial.Size = new System.Drawing.Size(79, 20);
            this.txtFatorial.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(97, 89);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtFatorial);
            this.Controls.Add(this.lblFatorial);
            this.Controls.Add(this.btnFatorial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFatorial;
        private System.Windows.Forms.Label lblFatorial;
        private System.Windows.Forms.TextBox txtFatorial;
        private System.Windows.Forms.Label lblResultado;
    }
}

