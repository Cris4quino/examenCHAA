namespace OPERACION_CHAA
{
    partial class solucion4
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
            this.components = new System.ComponentModel.Container();
            this.dtTodo = new System.Windows.Forms.DataGridView();
            this.bD_TRANSACCIONES_CHAADataSet = new OPERACION_CHAA.BD_TRANSACCIONES_CHAADataSet();
            this.cUENTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUENTATableAdapter = new OPERACION_CHAA.BD_TRANSACCIONES_CHAADataSetTableAdapters.CUENTATableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nROCUENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONEDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_TRANSACCIONES_CHAADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUENTABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTodo
            // 
            this.dtTodo.AutoGenerateColumns = false;
            this.dtTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nROCUENTADataGridViewTextBoxColumn,
            this.tIPODataGridViewTextBoxColumn,
            this.mONEDADataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.sALDODataGridViewTextBoxColumn,
            this.fECHACREACIONDataGridViewTextBoxColumn,
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn});
            this.dtTodo.DataSource = this.cUENTABindingSource;
            this.dtTodo.Location = new System.Drawing.Point(21, 45);
            this.dtTodo.Name = "dtTodo";
            this.dtTodo.Size = new System.Drawing.Size(638, 108);
            this.dtTodo.TabIndex = 0;
            this.dtTodo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bD_TRANSACCIONES_CHAADataSet
            // 
            this.bD_TRANSACCIONES_CHAADataSet.DataSetName = "BD_TRANSACCIONES_CHAADataSet";
            this.bD_TRANSACCIONES_CHAADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUENTABindingSource
            // 
            this.cUENTABindingSource.DataMember = "CUENTA";
            this.cUENTABindingSource.DataSource = this.bD_TRANSACCIONES_CHAADataSet;
            // 
            // cUENTATableAdapter
            // 
            this.cUENTATableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nROCUENTADataGridViewTextBoxColumn
            // 
            this.nROCUENTADataGridViewTextBoxColumn.DataPropertyName = "NRO_CUENTA";
            this.nROCUENTADataGridViewTextBoxColumn.HeaderText = "NRO_CUENTA";
            this.nROCUENTADataGridViewTextBoxColumn.Name = "nROCUENTADataGridViewTextBoxColumn";
            // 
            // tIPODataGridViewTextBoxColumn
            // 
            this.tIPODataGridViewTextBoxColumn.DataPropertyName = "TIPO";
            this.tIPODataGridViewTextBoxColumn.HeaderText = "TIPO";
            this.tIPODataGridViewTextBoxColumn.Name = "tIPODataGridViewTextBoxColumn";
            // 
            // mONEDADataGridViewTextBoxColumn
            // 
            this.mONEDADataGridViewTextBoxColumn.DataPropertyName = "MONEDA";
            this.mONEDADataGridViewTextBoxColumn.HeaderText = "MONEDA";
            this.mONEDADataGridViewTextBoxColumn.Name = "mONEDADataGridViewTextBoxColumn";
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // sALDODataGridViewTextBoxColumn
            // 
            this.sALDODataGridViewTextBoxColumn.DataPropertyName = "SALDO";
            this.sALDODataGridViewTextBoxColumn.HeaderText = "SALDO";
            this.sALDODataGridViewTextBoxColumn.Name = "sALDODataGridViewTextBoxColumn";
            // 
            // fECHACREACIONDataGridViewTextBoxColumn
            // 
            this.fECHACREACIONDataGridViewTextBoxColumn.DataPropertyName = "FECHA_CREACION";
            this.fECHACREACIONDataGridViewTextBoxColumn.HeaderText = "FECHA_CREACION";
            this.fECHACREACIONDataGridViewTextBoxColumn.Name = "fECHACREACIONDataGridViewTextBoxColumn";
            // 
            // fECHAMODIFICACIONDataGridViewTextBoxColumn
            // 
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn.DataPropertyName = "FECHA_MODIFICACION";
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn.HeaderText = "FECHA_MODIFICACION";
            this.fECHAMODIFICACIONDataGridViewTextBoxColumn.Name = "fECHAMODIFICACIONDataGridViewTextBoxColumn";
            // 
            // solucion4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 261);
            this.Controls.Add(this.dtTodo);
            this.Name = "solucion4";
            this.Text = "solucion4";
            this.Load += new System.EventHandler(this.solucion4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_TRANSACCIONES_CHAADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUENTABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtTodo;
        private BD_TRANSACCIONES_CHAADataSet bD_TRANSACCIONES_CHAADataSet;
        private System.Windows.Forms.BindingSource cUENTABindingSource;
        private BD_TRANSACCIONES_CHAADataSetTableAdapters.CUENTATableAdapter cUENTATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nROCUENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mONEDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAMODIFICACIONDataGridViewTextBoxColumn;
    }
}