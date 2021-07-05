namespace OPERACION_CHAA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroCuenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.rbCorriente = new System.Windows.Forms.RadioButton();
            this.rbAhorros = new System.Windows.Forms.RadioButton();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // txtNroCuenta
            // 
            this.txtNroCuenta.Location = new System.Drawing.Point(77, 21);
            this.txtNroCuenta.Name = "txtNroCuenta";
            this.txtNroCuenta.Size = new System.Drawing.Size(473, 20);
            this.txtNroCuenta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moneda: ";
            // 
            // cbMoneda
            // 
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Items.AddRange(new object[] {
            "BOLIVIANOS",
            "DOLARES"});
            this.cbMoneda.Location = new System.Drawing.Point(77, 73);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(121, 21);
            this.cbMoneda.TabIndex = 3;
            // 
            // rbCorriente
            // 
            this.rbCorriente.AutoSize = true;
            this.rbCorriente.Location = new System.Drawing.Point(24, 22);
            this.rbCorriente.Name = "rbCorriente";
            this.rbCorriente.Size = new System.Drawing.Size(104, 17);
            this.rbCorriente.TabIndex = 4;
            this.rbCorriente.TabStop = true;
            this.rbCorriente.Text = "Cuenta Corriente";
            this.rbCorriente.UseVisualStyleBackColor = true;
            // 
            // rbAhorros
            // 
            this.rbAhorros.AutoSize = true;
            this.rbAhorros.Location = new System.Drawing.Point(221, 19);
            this.rbAhorros.Name = "rbAhorros";
            this.rbAhorros.Size = new System.Drawing.Size(113, 17);
            this.rbAhorros.TabIndex = 5;
            this.rbAhorros.TabStop = true;
            this.rbAhorros.Text = "Cuenta de Ahorros";
            this.rbAhorros.UseVisualStyleBackColor = true;
            this.rbAhorros.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(210, 211);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 6;
            this.btAceptar.Text = "ACEPTAR";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(343, 211);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(77, 171);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(473, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAhorros);
            this.groupBox1.Controls.Add(this.rbCorriente);
            this.groupBox1.Location = new System.Drawing.Point(210, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 51);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO DE CUENTA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Abono/Retiro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.cbMoneda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNroCuenta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMoneda;
        private System.Windows.Forms.RadioButton rbCorriente;
        private System.Windows.Forms.RadioButton rbAhorros;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}

