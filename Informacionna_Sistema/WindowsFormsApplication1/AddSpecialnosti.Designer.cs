namespace WindowsFormsApplication1
{
    partial class AddSpecialnosti
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
            this.txtDisPred = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDisIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDisKod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearDis = new System.Windows.Forms.Button();
            this.btnAddDis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisPred
            // 
            this.txtDisPred.Location = new System.Drawing.Point(103, 60);
            this.txtDisPred.Name = "txtDisPred";
            this.txtDisPred.Size = new System.Drawing.Size(130, 20);
            this.txtDisPred.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Предмет:";
            // 
            // txtDisIme
            // 
            this.txtDisIme.Location = new System.Drawing.Point(103, 34);
            this.txtDisIme.Name = "txtDisIme";
            this.txtDisIme.Size = new System.Drawing.Size(130, 20);
            this.txtDisIme.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Име:";
            // 
            // txtDisKod
            // 
            this.txtDisKod.Location = new System.Drawing.Point(103, 8);
            this.txtDisKod.Name = "txtDisKod";
            this.txtDisKod.Size = new System.Drawing.Size(130, 20);
            this.txtDisKod.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Код:";
            // 
            // btnClearDis
            // 
            this.btnClearDis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearDis.Location = new System.Drawing.Point(122, 86);
            this.btnClearDis.Name = "btnClearDis";
            this.btnClearDis.Size = new System.Drawing.Size(100, 50);
            this.btnClearDis.TabIndex = 19;
            this.btnClearDis.Text = "Изчисти";
            this.btnClearDis.UseVisualStyleBackColor = true;
            this.btnClearDis.Click += new System.EventHandler(this.btnClearDis_Click);
            // 
            // btnAddDis
            // 
            this.btnAddDis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddDis.Location = new System.Drawing.Point(16, 86);
            this.btnAddDis.Name = "btnAddDis";
            this.btnAddDis.Size = new System.Drawing.Size(100, 50);
            this.btnAddDis.TabIndex = 18;
            this.btnAddDis.Text = "Добави";
            this.btnAddDis.UseVisualStyleBackColor = true;
            this.btnAddDis.Click += new System.EventHandler(this.btnAddDis_Click);
            // 
            // AddSpecialnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 149);
            this.Controls.Add(this.btnClearDis);
            this.Controls.Add(this.btnAddDis);
            this.Controls.Add(this.txtDisPred);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDisIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDisKod);
            this.Controls.Add(this.label1);
            this.Name = "AddSpecialnosti";
            this.Text = "Добавяне на специалности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisPred;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDisIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDisKod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearDis;
        private System.Windows.Forms.Button btnAddDis;

    }
}