namespace WindowsFormsApplication1
{
    partial class SearchSpecialnosti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchSpecialnosti));
            this.txtNameDis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchDis = new System.Windows.Forms.Button();
            this.dgvDis = new System.Windows.Forms.DataGridView();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodPredmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discipliniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApplication1.Database1DataSet();
            this.searchDisNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchDisNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.discipliniTableAdapter = new WindowsFormsApplication1.Database1DataSetTableAdapters.DiscipliniTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discipliniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.searchDisNameToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameDis
            // 
            this.txtNameDis.Location = new System.Drawing.Point(65, 10);
            this.txtNameDis.Name = "txtNameDis";
            this.txtNameDis.Size = new System.Drawing.Size(180, 20);
            this.txtNameDis.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Име:";
            // 
            // btnSearchDis
            // 
            this.btnSearchDis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchDis.Location = new System.Drawing.Point(16, 42);
            this.btnSearchDis.Name = "btnSearchDis";
            this.btnSearchDis.Size = new System.Drawing.Size(150, 50);
            this.btnSearchDis.TabIndex = 9;
            this.btnSearchDis.Text = "Търси";
            this.btnSearchDis.UseVisualStyleBackColor = true;
            this.btnSearchDis.Click += new System.EventHandler(this.btnSearchDis_Click);
            // 
            // dgvDis
            // 
            this.dgvDis.AllowUserToAddRows = false;
            this.dgvDis.AllowUserToDeleteRows = false;
            this.dgvDis.AutoGenerateColumns = false;
            this.dgvDis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.kodPredmetDataGridViewTextBoxColumn});
            this.dgvDis.DataSource = this.discipliniBindingSource;
            this.dgvDis.Location = new System.Drawing.Point(12, 100);
            this.dgvDis.Name = "dgvDis";
            this.dgvDis.ReadOnly = true;
            this.dgvDis.Size = new System.Drawing.Size(244, 150);
            this.dgvDis.TabIndex = 12;
            this.dgvDis.UseWaitCursor = true;
            this.dgvDis.Visible = false;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodPredmetDataGridViewTextBoxColumn
            // 
            this.kodPredmetDataGridViewTextBoxColumn.DataPropertyName = "KodPredmet";
            this.kodPredmetDataGridViewTextBoxColumn.HeaderText = "KodPredmet";
            this.kodPredmetDataGridViewTextBoxColumn.Name = "kodPredmetDataGridViewTextBoxColumn";
            this.kodPredmetDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodPredmetDataGridViewTextBoxColumn.Visible = false;
            // 
            // discipliniBindingSource
            // 
            this.discipliniBindingSource.DataMember = "Disciplini";
            this.discipliniBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchDisNameToolStrip
            // 
            this.searchDisNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripLabel,
            this.nameToolStripTextBox,
            this.searchDisNameToolStripButton});
            this.searchDisNameToolStrip.Location = new System.Drawing.Point(0, 0);
            this.searchDisNameToolStrip.Name = "searchDisNameToolStrip";
            this.searchDisNameToolStrip.Size = new System.Drawing.Size(276, 25);
            this.searchDisNameToolStrip.TabIndex = 13;
            this.searchDisNameToolStrip.Text = "searchDisNameToolStrip";
            this.searchDisNameToolStrip.Visible = false;
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
            // searchDisNameToolStripButton
            // 
            this.searchDisNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchDisNameToolStripButton.Name = "searchDisNameToolStripButton";
            this.searchDisNameToolStripButton.Size = new System.Drawing.Size(94, 22);
            this.searchDisNameToolStripButton.Text = "SearchDisName";
            this.searchDisNameToolStripButton.Click += new System.EventHandler(this.searchDisNameToolStripButton_Click);
            // 
            // discipliniTableAdapter
            // 
            this.discipliniTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // SearchSpecialnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 270);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchDisNameToolStrip);
            this.Controls.Add(this.dgvDis);
            this.Controls.Add(this.txtNameDis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchDis);
            this.Name = "SearchSpecialnosti";
            this.Text = "Търсене на специалности";
            this.Load += new System.EventHandler(this.SearchSpecialnosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discipliniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.searchDisNameToolStrip.ResumeLayout(false);
            this.searchDisNameToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameDis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchDis;
        private System.Windows.Forms.DataGridView dgvDis;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource discipliniBindingSource;
        private Database1DataSetTableAdapters.DiscipliniTableAdapter discipliniTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodPredmetDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip searchDisNameToolStrip;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchDisNameToolStripButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}