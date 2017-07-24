namespace WindowsFormsApplication1
{
    partial class SearchPredmeti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPredmeti));
            this.dgvPredmeti = new System.Windows.Forms.DataGridView();
            this.kodPredmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horariumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDisciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApplication1.Database1DataSet();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchPred = new System.Windows.Forms.Button();
            this.searchNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.predmetiTableAdapter = new WindowsFormsApplication1.Database1DataSetTableAdapters.PredmetiTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.searchNameToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPredmeti
            // 
            this.dgvPredmeti.AllowUserToAddRows = false;
            this.dgvPredmeti.AllowUserToDeleteRows = false;
            this.dgvPredmeti.AutoGenerateColumns = false;
            this.dgvPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodPredmetDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.horariumDataGridViewTextBoxColumn,
            this.kodDisciplinaDataGridViewTextBoxColumn,
            this.idTchDataGridViewTextBoxColumn});
            this.dgvPredmeti.DataSource = this.predmetiBindingSource;
            this.dgvPredmeti.Location = new System.Drawing.Point(12, 98);
            this.dgvPredmeti.Name = "dgvPredmeti";
            this.dgvPredmeti.ReadOnly = true;
            this.dgvPredmeti.Size = new System.Drawing.Size(244, 150);
            this.dgvPredmeti.TabIndex = 0;
            this.dgvPredmeti.Visible = false;
            // 
            // kodPredmetDataGridViewTextBoxColumn
            // 
            this.kodPredmetDataGridViewTextBoxColumn.DataPropertyName = "KodPredmet";
            this.kodPredmetDataGridViewTextBoxColumn.HeaderText = "KodPredmet";
            this.kodPredmetDataGridViewTextBoxColumn.Name = "kodPredmetDataGridViewTextBoxColumn";
            this.kodPredmetDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodPredmetDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horariumDataGridViewTextBoxColumn
            // 
            this.horariumDataGridViewTextBoxColumn.DataPropertyName = "Horarium";
            this.horariumDataGridViewTextBoxColumn.HeaderText = "Horarium";
            this.horariumDataGridViewTextBoxColumn.Name = "horariumDataGridViewTextBoxColumn";
            this.horariumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodDisciplinaDataGridViewTextBoxColumn
            // 
            this.kodDisciplinaDataGridViewTextBoxColumn.DataPropertyName = "KodDisciplina";
            this.kodDisciplinaDataGridViewTextBoxColumn.HeaderText = "KodDisciplina";
            this.kodDisciplinaDataGridViewTextBoxColumn.Name = "kodDisciplinaDataGridViewTextBoxColumn";
            this.kodDisciplinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodDisciplinaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idTchDataGridViewTextBoxColumn
            // 
            this.idTchDataGridViewTextBoxColumn.DataPropertyName = "IdTch";
            this.idTchDataGridViewTextBoxColumn.HeaderText = "IdTch";
            this.idTchDataGridViewTextBoxColumn.Name = "idTchDataGridViewTextBoxColumn";
            this.idTchDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTchDataGridViewTextBoxColumn.Visible = false;
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(65, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Име:";
            // 
            // btnSearchPred
            // 
            this.btnSearchPred.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchPred.Location = new System.Drawing.Point(16, 42);
            this.btnSearchPred.Name = "btnSearchPred";
            this.btnSearchPred.Size = new System.Drawing.Size(150, 50);
            this.btnSearchPred.TabIndex = 6;
            this.btnSearchPred.Text = "Търси";
            this.btnSearchPred.UseVisualStyleBackColor = true;
            this.btnSearchPred.Click += new System.EventHandler(this.btnSearchPred_Click);
            // 
            // searchNameToolStrip
            // 
            this.searchNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripLabel,
            this.nameToolStripTextBox,
            this.searchNameToolStripButton});
            this.searchNameToolStrip.Location = new System.Drawing.Point(0, 0);
            this.searchNameToolStrip.Name = "searchNameToolStrip";
            this.searchNameToolStrip.Size = new System.Drawing.Size(276, 25);
            this.searchNameToolStrip.TabIndex = 9;
            this.searchNameToolStrip.Text = "searchNameToolStrip";
            this.searchNameToolStrip.Visible = false;
            // 
            // nameToolStripLabel
            // 
            this.nameToolStripLabel.Name = "nameToolStripLabel";
            this.nameToolStripLabel.Size = new System.Drawing.Size(42, 22);
            this.nameToolStripLabel.Text = "Name:";
            // 
            // nameToolStripTextBox
            // 
            this.nameToolStripTextBox.Name = "nameToolStripTextBox";
            this.nameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // searchNameToolStripButton
            // 
            this.searchNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchNameToolStripButton.Name = "searchNameToolStripButton";
            this.searchNameToolStripButton.Size = new System.Drawing.Size(78, 22);
            this.searchNameToolStripButton.Text = "SearchName";
            this.searchNameToolStripButton.Click += new System.EventHandler(this.searchNameToolStripButton_Click);
            // 
            // predmetiTableAdapter
            // 
            this.predmetiTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // SearchPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 268);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchNameToolStrip);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchPred);
            this.Controls.Add(this.dgvPredmeti);
            this.Name = "SearchPredmeti";
            this.Text = "Търсене на предмети";
            this.Load += new System.EventHandler(this.SearchPredmeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.searchNameToolStrip.ResumeLayout(false);
            this.searchNameToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPredmeti;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchPred;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource predmetiBindingSource;
        private Database1DataSetTableAdapters.PredmetiTableAdapter predmetiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodPredmetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horariumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDisciplinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTchDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip searchNameToolStrip;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchNameToolStripButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}