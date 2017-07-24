namespace WindowsFormsApplication1
{
    partial class SearchTeachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchTeachers));
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.idTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApplication1.Database1DataSet();
            this.btnSearchTch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.teachersTableAdapter = new WindowsFormsApplication1.Database1DataSetTableAdapters.TeachersTableAdapter();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchSurnameToolStrip = new System.Windows.Forms.ToolStrip();
            this.surnameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.surnameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchSurnameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchNameSurnameToolStrip = new System.Windows.Forms.ToolStrip();
            this.nameToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.nameToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.surnameToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.surnameToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.searchNameSurnameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchNameToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nameToolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.nameToolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.searchNameToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.searchNameToolStrip.SuspendLayout();
            this.searchSurnameToolStrip.SuspendLayout();
            this.searchNameSurnameToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.searchNameToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.AllowUserToDeleteRows = false;
            this.dgvTeachers.AutoGenerateColumns = false;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTeacherDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.officeDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.dgvTeachers.DataSource = this.teachersBindingSource;
            this.dgvTeachers.Location = new System.Drawing.Point(12, 143);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.ReadOnly = true;
            this.dgvTeachers.Size = new System.Drawing.Size(645, 263);
            this.dgvTeachers.TabIndex = 0;
            this.dgvTeachers.Visible = false;
            // 
            // idTeacherDataGridViewTextBoxColumn
            // 
            this.idTeacherDataGridViewTextBoxColumn.DataPropertyName = "Id_Teacher";
            this.idTeacherDataGridViewTextBoxColumn.HeaderText = "Id_Teacher";
            this.idTeacherDataGridViewTextBoxColumn.Name = "idTeacherDataGridViewTextBoxColumn";
            this.idTeacherDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTeacherDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "Middlename";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "Middlename";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            this.middlenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // officeDataGridViewTextBoxColumn
            // 
            this.officeDataGridViewTextBoxColumn.DataPropertyName = "Office";
            this.officeDataGridViewTextBoxColumn.HeaderText = "Office";
            this.officeDataGridViewTextBoxColumn.Name = "officeDataGridViewTextBoxColumn";
            this.officeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearchTch
            // 
            this.btnSearchTch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchTch.Location = new System.Drawing.Point(16, 62);
            this.btnSearchTch.Name = "btnSearchTch";
            this.btnSearchTch.Size = new System.Drawing.Size(150, 50);
            this.btnSearchTch.TabIndex = 1;
            this.btnSearchTch.Text = "Търси";
            this.btnSearchTch.UseVisualStyleBackColor = true;
            this.btnSearchTch.Click += new System.EventHandler(this.btnSearchTch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Име:";
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(106, 36);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(146, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия:";
            // 
            // searchNameToolStrip
            // 
            this.searchNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripLabel,
            this.nameToolStripTextBox,
            this.searchNameToolStripButton});
            this.searchNameToolStrip.Location = new System.Drawing.Point(0, 0);
            this.searchNameToolStrip.Name = "searchNameToolStrip";
            this.searchNameToolStrip.Size = new System.Drawing.Size(677, 25);
            this.searchNameToolStrip.TabIndex = 6;
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
            // searchSurnameToolStrip
            // 
            this.searchSurnameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.surnameToolStripLabel,
            this.surnameToolStripTextBox,
            this.searchSurnameToolStripButton});
            this.searchSurnameToolStrip.Location = new System.Drawing.Point(0, 0);
            this.searchSurnameToolStrip.Name = "searchSurnameToolStrip";
            this.searchSurnameToolStrip.Size = new System.Drawing.Size(677, 25);
            this.searchSurnameToolStrip.TabIndex = 7;
            this.searchSurnameToolStrip.Text = "searchSurnameToolStrip";
            this.searchSurnameToolStrip.Visible = false;
            // 
            // surnameToolStripLabel
            // 
            this.surnameToolStripLabel.Name = "surnameToolStripLabel";
            this.surnameToolStripLabel.Size = new System.Drawing.Size(57, 22);
            this.surnameToolStripLabel.Text = "Surname:";
            // 
            // surnameToolStripTextBox
            // 
            this.surnameToolStripTextBox.Name = "surnameToolStripTextBox";
            this.surnameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // searchSurnameToolStripButton
            // 
            this.searchSurnameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchSurnameToolStripButton.Name = "searchSurnameToolStripButton";
            this.searchSurnameToolStripButton.Size = new System.Drawing.Size(93, 22);
            this.searchSurnameToolStripButton.Text = "SearchSurname";
            this.searchSurnameToolStripButton.Click += new System.EventHandler(this.searchSurnameToolStripButton_Click);
            // 
            // searchNameSurnameToolStrip
            // 
            this.searchNameSurnameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripLabel1,
            this.nameToolStripTextBox1,
            this.surnameToolStripLabel1,
            this.surnameToolStripTextBox1,
            this.searchNameSurnameToolStripButton});
            this.searchNameSurnameToolStrip.Location = new System.Drawing.Point(0, 0);
            this.searchNameSurnameToolStrip.Name = "searchNameSurnameToolStrip";
            this.searchNameSurnameToolStrip.Size = new System.Drawing.Size(677, 25);
            this.searchNameSurnameToolStrip.TabIndex = 8;
            this.searchNameSurnameToolStrip.Text = "searchNameSurnameToolStrip";
            this.searchNameSurnameToolStrip.Visible = false;
            // 
            // nameToolStripLabel1
            // 
            this.nameToolStripLabel1.Name = "nameToolStripLabel1";
            this.nameToolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.nameToolStripLabel1.Text = "Name:";
            // 
            // nameToolStripTextBox1
            // 
            this.nameToolStripTextBox1.Name = "nameToolStripTextBox1";
            this.nameToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // surnameToolStripLabel1
            // 
            this.surnameToolStripLabel1.Name = "surnameToolStripLabel1";
            this.surnameToolStripLabel1.Size = new System.Drawing.Size(57, 22);
            this.surnameToolStripLabel1.Text = "Surname:";
            // 
            // surnameToolStripTextBox1
            // 
            this.surnameToolStripTextBox1.Name = "surnameToolStripTextBox1";
            this.surnameToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // searchNameSurnameToolStripButton
            // 
            this.searchNameSurnameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchNameSurnameToolStripButton.Name = "searchNameSurnameToolStripButton";
            this.searchNameSurnameToolStripButton.Size = new System.Drawing.Size(125, 22);
            this.searchNameSurnameToolStripButton.Text = "SearchNameSurname";
            this.searchNameSurnameToolStripButton.Click += new System.EventHandler(this.searchNameSurnameToolStripButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(172, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // searchNameToolStrip1
            // 
            this.searchNameToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripLabel2,
            this.nameToolStripTextBox2,
            this.searchNameToolStripButton1});
            this.searchNameToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.searchNameToolStrip1.Name = "searchNameToolStrip1";
            this.searchNameToolStrip1.Size = new System.Drawing.Size(677, 25);
            this.searchNameToolStrip1.TabIndex = 12;
            this.searchNameToolStrip1.Text = "searchNameToolStrip1";
            this.searchNameToolStrip1.Visible = false;
            // 
            // nameToolStripLabel2
            // 
            this.nameToolStripLabel2.Name = "nameToolStripLabel2";
            this.nameToolStripLabel2.Size = new System.Drawing.Size(42, 22);
            this.nameToolStripLabel2.Text = "Name:";
            // 
            // nameToolStripTextBox2
            // 
            this.nameToolStripTextBox2.Name = "nameToolStripTextBox2";
            this.nameToolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            // 
            // searchNameToolStripButton1
            // 
            this.searchNameToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchNameToolStripButton1.Name = "searchNameToolStripButton1";
            this.searchNameToolStripButton1.Size = new System.Drawing.Size(78, 19);
            this.searchNameToolStripButton1.Text = "SearchName";
            this.searchNameToolStripButton1.Click += new System.EventHandler(this.searchNameToolStripButton1_Click);
            // 
            // SearchTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 426);
            this.Controls.Add(this.searchNameToolStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.searchNameToolStrip);
            this.Controls.Add(this.searchSurnameToolStrip);
            this.Controls.Add(this.searchNameSurnameToolStrip);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchTch);
            this.Controls.Add(this.dgvTeachers);
            this.Name = "SearchTeachers";
            this.Text = "Търсене на учители";
            this.Load += new System.EventHandler(this.SearchTeachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.searchNameToolStrip.ResumeLayout(false);
            this.searchNameToolStrip.PerformLayout();
            this.searchSurnameToolStrip.ResumeLayout(false);
            this.searchSurnameToolStrip.PerformLayout();
            this.searchNameSurnameToolStrip.ResumeLayout(false);
            this.searchNameSurnameToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.searchNameToolStrip1.ResumeLayout(false);
            this.searchNameToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Button btnSearchTch;
        private System.Windows.Forms.Label label1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private Database1DataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip searchNameToolStrip;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchNameToolStripButton;
        private System.Windows.Forms.ToolStrip searchSurnameToolStrip;
        private System.Windows.Forms.ToolStripLabel surnameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox surnameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchSurnameToolStripButton;
        private System.Windows.Forms.ToolStrip searchNameSurnameToolStrip;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox nameToolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel surnameToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox surnameToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton searchNameSurnameToolStripButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStrip searchNameToolStrip1;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox nameToolStripTextBox2;
        private System.Windows.Forms.ToolStripButton searchNameToolStripButton1;
    }
}