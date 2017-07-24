namespace WindowsFormsApplication1
{
    partial class AddPredmeti
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKodPred = new System.Windows.Forms.TextBox();
            this.txtImePred = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHorPred = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDisPred = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPred = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClearPred = new System.Windows.Forms.Button();
            this.btnAddPred = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код:";
            // 
            // txtKodPred
            // 
            this.txtKodPred.Location = new System.Drawing.Point(149, 8);
            this.txtKodPred.Name = "txtKodPred";
            this.txtKodPred.Size = new System.Drawing.Size(100, 20);
            this.txtKodPred.TabIndex = 2;
            // 
            // txtImePred
            // 
            this.txtImePred.Location = new System.Drawing.Point(149, 34);
            this.txtImePred.Name = "txtImePred";
            this.txtImePred.Size = new System.Drawing.Size(100, 20);
            this.txtImePred.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Име:";
            // 
            // txtHorPred
            // 
            this.txtHorPred.Location = new System.Drawing.Point(149, 60);
            this.txtHorPred.Name = "txtHorPred";
            this.txtHorPred.Size = new System.Drawing.Size(100, 20);
            this.txtHorPred.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Хорариум:";
            // 
            // txtDisPred
            // 
            this.txtDisPred.Location = new System.Drawing.Point(149, 86);
            this.txtDisPred.Name = "txtDisPred";
            this.txtDisPred.Size = new System.Drawing.Size(100, 20);
            this.txtDisPred.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дисциплина:";
            // 
            // txtIdPred
            // 
            this.txtIdPred.Location = new System.Drawing.Point(149, 112);
            this.txtIdPred.Name = "txtIdPred";
            this.txtIdPred.Size = new System.Drawing.Size(100, 20);
            this.txtIdPred.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Преподавател:";
            // 
            // btnClearPred
            // 
            this.btnClearPred.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearPred.Location = new System.Drawing.Point(118, 144);
            this.btnClearPred.Name = "btnClearPred";
            this.btnClearPred.Size = new System.Drawing.Size(100, 50);
            this.btnClearPred.TabIndex = 17;
            this.btnClearPred.Text = "Изчисти";
            this.btnClearPred.UseVisualStyleBackColor = true;
            this.btnClearPred.Click += new System.EventHandler(this.btnClearPred_Click);
            // 
            // btnAddPred
            // 
            this.btnAddPred.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPred.Location = new System.Drawing.Point(12, 144);
            this.btnAddPred.Name = "btnAddPred";
            this.btnAddPred.Size = new System.Drawing.Size(100, 50);
            this.btnAddPred.TabIndex = 16;
            this.btnAddPred.Text = "Добави";
            this.btnAddPred.UseVisualStyleBackColor = true;
            this.btnAddPred.Click += new System.EventHandler(this.btnAddPred_Click);
            // 
            // AddPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 207);
            this.Controls.Add(this.btnClearPred);
            this.Controls.Add(this.btnAddPred);
            this.Controls.Add(this.txtIdPred);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDisPred);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHorPred);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImePred);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKodPred);
            this.Controls.Add(this.label1);
            this.Name = "AddPredmeti";
            this.Text = "Добавяне на предмети";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKodPred;
        private System.Windows.Forms.TextBox txtImePred;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHorPred;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDisPred;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdPred;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClearPred;
        private System.Windows.Forms.Button btnAddPred;
    }
}