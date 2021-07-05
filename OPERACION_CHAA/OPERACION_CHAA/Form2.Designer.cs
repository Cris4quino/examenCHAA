namespace OPERACION_CHAA
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btDeposito = new System.Windows.Forms.Button();
            this.btRetiro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCuenta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUENTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUENTA: ";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(110, 34);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(233, 20);
            this.txtCuenta.TabIndex = 1;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(110, 67);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(233, 20);
            this.txtMonto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MONTO";
            // 
            // btDeposito
            // 
            this.btDeposito.Location = new System.Drawing.Point(139, 168);
            this.btDeposito.Name = "btDeposito";
            this.btDeposito.Size = new System.Drawing.Size(75, 23);
            this.btDeposito.TabIndex = 1;
            this.btDeposito.Text = "DEPOSITO";
            this.btDeposito.UseVisualStyleBackColor = true;
            this.btDeposito.Click += new System.EventHandler(this.btDeposito_Click);
            // 
            // btRetiro
            // 
            this.btRetiro.Location = new System.Drawing.Point(265, 168);
            this.btRetiro.Name = "btRetiro";
            this.btRetiro.Size = new System.Drawing.Size(75, 23);
            this.btRetiro.TabIndex = 2;
            this.btRetiro.Text = "RETIRO";
            this.btRetiro.UseVisualStyleBackColor = true;
            this.btRetiro.Click += new System.EventHandler(this.btRetiro_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 215);
            this.Controls.Add(this.btRetiro);
            this.Controls.Add(this.btDeposito);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDeposito;
        private System.Windows.Forms.Button btRetiro;
    }
}