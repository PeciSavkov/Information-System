namespace WindowsFormsApplication1
{
    partial class ViewPredmeti
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodPredmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horariumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDisciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApplication1.Database1DataSet();
            this.predmetiTableAdapter = new WindowsFormsApplication1.Database1DataSetTableAdapters.PredmetiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodPredmetDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.horariumDataGridViewTextBoxColumn,
            this.kodDisciplinaDataGridViewTextBoxColumn,
            this.idTchDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.predmetiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(533, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // kodPredmetDataGridViewTextBoxColumn
            // 
            this.kodPredmetDataGridViewTextBoxColumn.DataPropertyName = "KodPredmet";
            this.kodPredmetDataGridViewTextBoxColumn.HeaderText = "KodPredmet";
            this.kodPredmetDataGridViewTextBoxColumn.Name = "kodPredmetDataGridViewTextBoxColumn";
            this.kodPredmetDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodPredmetDataGridViewTextBoxColumn.Width = 70;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeDataGridViewTextBoxColumn.Width = 200;
            // 
            // horariumDataGridViewTextBoxColumn
            // 
            this.horariumDataGridViewTextBoxColumn.DataPropertyName = "Horarium";
            this.horariumDataGridViewTextBoxColumn.HeaderText = "Horarium";
            this.horariumDataGridViewTextBoxColumn.Name = "horariumDataGridViewTextBoxColumn";
            this.horariumDataGridViewTextBoxColumn.ReadOnly = true;
            this.horariumDataGridViewTextBoxColumn.Width = 70;
            // 
            // kodDisciplinaDataGridViewTextBoxColumn
            // 
            this.kodDisciplinaDataGridViewTextBoxColumn.DataPropertyName = "KodDisciplina";
            this.kodDisciplinaDataGridViewTextBoxColumn.HeaderText = "KodDisciplina";
            this.kodDisciplinaDataGridViewTextBoxColumn.Name = "kodDisciplinaDataGridViewTextBoxColumn";
            this.kodDisciplinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodDisciplinaDataGridViewTextBoxColumn.Width = 80;
            // 
            // idTchDataGridViewTextBoxColumn
            // 
            this.idTchDataGridViewTextBoxColumn.DataPropertyName = "IdTch";
            this.idTchDataGridViewTextBoxColumn.HeaderText = "IdTch";
            this.idTchDataGridViewTextBoxColumn.Name = "idTchDataGridViewTextBoxColumn";
            this.idTchDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTchDataGridViewTextBoxColumn.Width = 70;
            // 
            // predmetiBindingSource
            // 
            this.predmetiBindingSource.DataMember = "Predmeti";
            this.predmetiBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // predmetiTableAdapter
            // 
            this.predmetiTableAdapter.ClearBeforeFill = true;
            // 
            // ViewPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 203);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewPredmeti";
            this.Text = "Преглед на предмети";
            this.Load += new System.EventHandler(this.ViewPredmeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource predmetiBindingSource;
        private Database1DataSetTableAdapters.PredmetiTableAdapter predmetiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodPredmetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horariumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDisciplinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTchDataGridViewTextBoxColumn;
    }
}