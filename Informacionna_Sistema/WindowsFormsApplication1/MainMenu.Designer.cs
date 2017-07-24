namespace WindowsFormsApplication1
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnTch = new System.Windows.Forms.Button();
            this.btnPred = new System.Windows.Forms.Button();
            this.btnSpec = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddTch = new System.Windows.Forms.Button();
            this.btnSearchTch = new System.Windows.Forms.Button();
            this.btnViewTch = new System.Windows.Forms.Button();
            this.btnAddPred = new System.Windows.Forms.Button();
            this.btnSearchPred = new System.Windows.Forms.Button();
            this.btnViewPred = new System.Windows.Forms.Button();
            this.btnAddSpec = new System.Windows.Forms.Button();
            this.btnSearchSpec = new System.Windows.Forms.Button();
            this.btnViewSpec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTch
            // 
            this.btnTch.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTch.Location = new System.Drawing.Point(6, 19);
            this.btnTch.Name = "btnTch";
            this.btnTch.Size = new System.Drawing.Size(153, 50);
            this.btnTch.TabIndex = 0;
            this.btnTch.Text = "Преподаватели";
            this.btnTch.UseVisualStyleBackColor = true;
            this.btnTch.Click += new System.EventHandler(this.btnTch_Click);
            // 
            // btnPred
            // 
            this.btnPred.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPred.Location = new System.Drawing.Point(165, 19);
            this.btnPred.Name = "btnPred";
            this.btnPred.Size = new System.Drawing.Size(153, 50);
            this.btnPred.TabIndex = 1;
            this.btnPred.Text = "Предмети";
            this.btnPred.UseVisualStyleBackColor = true;
            this.btnPred.Click += new System.EventHandler(this.btnPred_Click);
            // 
            // btnSpec
            // 
            this.btnSpec.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSpec.Location = new System.Drawing.Point(321, 19);
            this.btnSpec.Name = "btnSpec";
            this.btnSpec.Size = new System.Drawing.Size(153, 50);
            this.btnSpec.TabIndex = 2;
            this.btnSpec.Text = "Специалности";
            this.btnSpec.UseVisualStyleBackColor = true;
            this.btnSpec.Click += new System.EventHandler(this.btnSpec_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTch);
            this.groupBox1.Controls.Add(this.btnSpec);
            this.groupBox1.Controls.Add(this.btnPred);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 83);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Моля изберете";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(177, 101);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 50);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Изход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddTch
            // 
            this.btnAddTch.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTch.Location = new System.Drawing.Point(18, 170);
            this.btnAddTch.Name = "btnAddTch";
            this.btnAddTch.Size = new System.Drawing.Size(153, 50);
            this.btnAddTch.TabIndex = 3;
            this.btnAddTch.Text = "Добави";
            this.btnAddTch.UseVisualStyleBackColor = true;
            this.btnAddTch.Visible = false;
            this.btnAddTch.Click += new System.EventHandler(this.btnAddTch_Click);
            // 
            // btnSearchTch
            // 
            this.btnSearchTch.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchTch.Location = new System.Drawing.Point(333, 170);
            this.btnSearchTch.Name = "btnSearchTch";
            this.btnSearchTch.Size = new System.Drawing.Size(153, 50);
            this.btnSearchTch.TabIndex = 5;
            this.btnSearchTch.Text = "Търси";
            this.btnSearchTch.UseVisualStyleBackColor = true;
            this.btnSearchTch.Visible = false;
            this.btnSearchTch.Click += new System.EventHandler(this.btnSearchTch_Click);
            // 
            // btnViewTch
            // 
            this.btnViewTch.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewTch.Location = new System.Drawing.Point(177, 170);
            this.btnViewTch.Name = "btnViewTch";
            this.btnViewTch.Size = new System.Drawing.Size(153, 50);
            this.btnViewTch.TabIndex = 4;
            this.btnViewTch.Text = "Преглед";
            this.btnViewTch.UseVisualStyleBackColor = true;
            this.btnViewTch.Visible = false;
            this.btnViewTch.Click += new System.EventHandler(this.btnViewTch_Click);
            // 
            // btnAddPred
            // 
            this.btnAddPred.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPred.Location = new System.Drawing.Point(18, 170);
            this.btnAddPred.Name = "btnAddPred";
            this.btnAddPred.Size = new System.Drawing.Size(153, 50);
            this.btnAddPred.TabIndex = 6;
            this.btnAddPred.Text = "Добави";
            this.btnAddPred.UseVisualStyleBackColor = true;
            this.btnAddPred.Visible = false;
            this.btnAddPred.Click += new System.EventHandler(this.btnAddPred_Click);
            // 
            // btnSearchPred
            // 
            this.btnSearchPred.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchPred.Location = new System.Drawing.Point(333, 170);
            this.btnSearchPred.Name = "btnSearchPred";
            this.btnSearchPred.Size = new System.Drawing.Size(153, 50);
            this.btnSearchPred.TabIndex = 8;
            this.btnSearchPred.Text = "Търси";
            this.btnSearchPred.UseVisualStyleBackColor = true;
            this.btnSearchPred.Visible = false;
            this.btnSearchPred.Click += new System.EventHandler(this.btnSearchPred_Click);
            // 
            // btnViewPred
            // 
            this.btnViewPred.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewPred.Location = new System.Drawing.Point(177, 170);
            this.btnViewPred.Name = "btnViewPred";
            this.btnViewPred.Size = new System.Drawing.Size(153, 50);
            this.btnViewPred.TabIndex = 7;
            this.btnViewPred.Text = "Преглед";
            this.btnViewPred.UseVisualStyleBackColor = true;
            this.btnViewPred.Visible = false;
            this.btnViewPred.Click += new System.EventHandler(this.btnViewPred_Click);
            // 
            // btnAddSpec
            // 
            this.btnAddSpec.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSpec.Location = new System.Drawing.Point(18, 170);
            this.btnAddSpec.Name = "btnAddSpec";
            this.btnAddSpec.Size = new System.Drawing.Size(153, 50);
            this.btnAddSpec.TabIndex = 9;
            this.btnAddSpec.Text = "Добави";
            this.btnAddSpec.UseVisualStyleBackColor = true;
            this.btnAddSpec.Visible = false;
            this.btnAddSpec.Click += new System.EventHandler(this.btnAddSpec_Click);
            // 
            // btnSearchSpec
            // 
            this.btnSearchSpec.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchSpec.Location = new System.Drawing.Point(333, 170);
            this.btnSearchSpec.Name = "btnSearchSpec";
            this.btnSearchSpec.Size = new System.Drawing.Size(153, 50);
            this.btnSearchSpec.TabIndex = 11;
            this.btnSearchSpec.Text = "Търси";
            this.btnSearchSpec.UseVisualStyleBackColor = true;
            this.btnSearchSpec.Visible = false;
            this.btnSearchSpec.Click += new System.EventHandler(this.btnSearchSpec_Click);
            // 
            // btnViewSpec
            // 
            this.btnViewSpec.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewSpec.Location = new System.Drawing.Point(177, 170);
            this.btnViewSpec.Name = "btnViewSpec";
            this.btnViewSpec.Size = new System.Drawing.Size(153, 50);
            this.btnViewSpec.TabIndex = 10;
            this.btnViewSpec.Text = "Преглед";
            this.btnViewSpec.UseVisualStyleBackColor = true;
            this.btnViewSpec.Visible = false;
            this.btnViewSpec.Click += new System.EventHandler(this.btnViewSpec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 160);
            this.Controls.Add(this.btnAddSpec);
            this.Controls.Add(this.btnSearchSpec);
            this.Controls.Add(this.btnViewSpec);
            this.Controls.Add(this.btnAddPred);
            this.Controls.Add(this.btnSearchPred);
            this.Controls.Add(this.btnViewPred);
            this.Controls.Add(this.btnAddTch);
            this.Controls.Add(this.btnSearchTch);
            this.Controls.Add(this.btnViewTch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenu";
            this.Text = "Главно меню";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTch;
        private System.Windows.Forms.Button btnPred;
        private System.Windows.Forms.Button btnSpec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddTch;
        private System.Windows.Forms.Button btnSearchTch;
        private System.Windows.Forms.Button btnViewTch;
        private System.Windows.Forms.Button btnAddPred;
        private System.Windows.Forms.Button btnSearchPred;
        private System.Windows.Forms.Button btnViewPred;
        private System.Windows.Forms.Button btnAddSpec;
        private System.Windows.Forms.Button btnSearchSpec;
        private System.Windows.Forms.Button btnViewSpec;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

