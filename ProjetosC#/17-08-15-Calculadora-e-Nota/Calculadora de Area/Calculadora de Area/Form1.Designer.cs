namespace Calculadora_de_Area
{
    partial class frmCalcFormas
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
            this.btnRet = new System.Windows.Forms.Button();
            this.btnTri = new System.Windows.Forms.Button();
            this.btnQuad = new System.Windows.Forms.Button();
            this.btnCirc = new System.Windows.Forms.Button();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this.txtResul = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblResul = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRet
            // 
            this.btnRet.Location = new System.Drawing.Point(152, 138);
            this.btnRet.Name = "btnRet";
            this.btnRet.Size = new System.Drawing.Size(64, 23);
            this.btnRet.TabIndex = 0;
            this.btnRet.Text = "Retângulo";
            this.btnRet.UseVisualStyleBackColor = true;
            this.btnRet.Click += new System.EventHandler(this.btnRet_Click);
            // 
            // btnTri
            // 
            this.btnTri.Location = new System.Drawing.Point(12, 138);
            this.btnTri.Name = "btnTri";
            this.btnTri.Size = new System.Drawing.Size(64, 23);
            this.btnTri.TabIndex = 1;
            this.btnTri.Text = "Triângulo";
            this.btnTri.UseVisualStyleBackColor = true;
            this.btnTri.Click += new System.EventHandler(this.btnTri_Click);
            // 
            // btnQuad
            // 
            this.btnQuad.Location = new System.Drawing.Point(222, 138);
            this.btnQuad.Name = "btnQuad";
            this.btnQuad.Size = new System.Drawing.Size(64, 23);
            this.btnQuad.TabIndex = 2;
            this.btnQuad.Text = "Quadrado";
            this.btnQuad.UseVisualStyleBackColor = true;
            this.btnQuad.Click += new System.EventHandler(this.btnQuad_Click);
            // 
            // btnCirc
            // 
            this.btnCirc.Location = new System.Drawing.Point(82, 138);
            this.btnCirc.Name = "btnCirc";
            this.btnCirc.Size = new System.Drawing.Size(64, 23);
            this.btnCirc.TabIndex = 3;
            this.btnCirc.Text = "Círculo";
            this.btnCirc.UseVisualStyleBackColor = true;
            this.btnCirc.Click += new System.EventHandler(this.btnCirc_Click);
            // 
            // txtAlt
            // 
            this.txtAlt.Location = new System.Drawing.Point(106, 69);
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.Size = new System.Drawing.Size(134, 20);
            this.txtAlt.TabIndex = 4;
            // 
            // txtResul
            // 
            this.txtResul.Location = new System.Drawing.Point(106, 99);
            this.txtResul.Name = "txtResul";
            this.txtResul.Size = new System.Drawing.Size(134, 20);
            this.txtResul.TabIndex = 5;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(106, 39);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(134, 20);
            this.txtBase.TabIndex = 6;
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Location = new System.Drawing.Point(45, 102);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(55, 13);
            this.lblResul.TabIndex = 7;
            this.lblResul.Text = "Resultado";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(63, 72);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 8;
            this.lblAltura.Text = "Altura";
            this.lblAltura.Click += new System.EventHandler(this.lblAltura_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(66, 42);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 9;
            this.lblBase.Text = "Base";
            // 
            // frmCalcFormas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 195);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtResul);
            this.Controls.Add(this.txtAlt);
            this.Controls.Add(this.btnCirc);
            this.Controls.Add(this.btnQuad);
            this.Controls.Add(this.btnTri);
            this.Controls.Add(this.btnRet);
            this.Name = "frmCalcFormas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Calc Areas";
            this.Load += new System.EventHandler(this.frmCalcFormas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRet;
        private System.Windows.Forms.Button btnTri;
        private System.Windows.Forms.Button btnQuad;
        private System.Windows.Forms.Button btnCirc;
        private System.Windows.Forms.TextBox txtAlt;
        private System.Windows.Forms.TextBox txtResul;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
    }
}

