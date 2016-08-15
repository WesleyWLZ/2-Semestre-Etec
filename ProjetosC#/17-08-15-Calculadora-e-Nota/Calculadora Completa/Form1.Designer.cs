namespace WindowsFormsApplication3
{
    partial class frmCalc
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
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.lblVal2 = new System.Windows.Forms.Label();
            this.lblVal1 = new System.Windows.Forms.Label();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.txtResul = new System.Windows.Forms.TextBox();
            this.lblResul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVal2
            // 
            this.txtVal2.Location = new System.Drawing.Point(87, 70);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(168, 20);
            this.txtVal2.TabIndex = 0;
            // 
            // txtVal1
            // 
            this.txtVal1.Location = new System.Drawing.Point(87, 26);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(168, 20);
            this.txtVal1.TabIndex = 1;
            this.txtVal1.TextChanged += new System.EventHandler(this.txtval1_TextChanged);
            // 
            // lblVal2
            // 
            this.lblVal2.AutoSize = true;
            this.lblVal2.Location = new System.Drawing.Point(34, 73);
            this.lblVal2.Name = "lblVal2";
            this.lblVal2.Size = new System.Drawing.Size(28, 13);
            this.lblVal2.TabIndex = 2;
            this.lblVal2.Text = "Val2";
            // 
            // lblVal1
            // 
            this.lblVal1.AutoSize = true;
            this.lblVal1.Location = new System.Drawing.Point(34, 26);
            this.lblVal1.Name = "lblVal1";
            this.lblVal1.Size = new System.Drawing.Size(28, 13);
            this.lblVal1.TabIndex = 3;
            this.lblVal1.Text = "Val1";
            this.lblVal1.Click += new System.EventHandler(this.lblval1_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnMult.Location = new System.Drawing.Point(210, 105);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(34, 23);
            this.btnMult.TabIndex = 4;
            this.btnMult.Text = "X";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimp.Location = new System.Drawing.Point(87, 153);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(168, 23);
            this.btnLimp.TabIndex = 5;
            this.btnLimp.Text = "Limpar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnDiv.Location = new System.Drawing.Point(168, 105);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(36, 23);
            this.btnDiv.TabIndex = 6;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSub.Location = new System.Drawing.Point(128, 105);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(34, 23);
            this.btnSub.TabIndex = 7;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSoma.Location = new System.Drawing.Point(87, 105);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(35, 23);
            this.btnSoma.TabIndex = 8;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // txtResul
            // 
            this.txtResul.Location = new System.Drawing.Point(87, 197);
            this.txtResul.Name = "txtResul";
            this.txtResul.Size = new System.Drawing.Size(168, 20);
            this.txtResul.TabIndex = 9;
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Location = new System.Drawing.Point(26, 200);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(55, 13);
            this.lblResul.TabIndex = 10;
            this.lblResul.Text = "Resultado";
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 248);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.txtResul);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.lblVal1);
            this.Controls.Add(this.lblVal2);
            this.Controls.Add(this.txtVal1);
            this.Controls.Add(this.txtVal2);
            this.Name = "frmCalc";
            this.Text = "Calc Fuck Blaster 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.Label lblVal2;
        private System.Windows.Forms.Label lblVal1;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.TextBox txtResul;
        private System.Windows.Forms.Label lblResul;
    }
}

