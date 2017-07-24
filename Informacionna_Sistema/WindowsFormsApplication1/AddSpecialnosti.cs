using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace WindowsFormsApplication1
{
    public partial class AddSpecialnosti : Form
    {
        public SqlCeConnection cn = new SqlCeConnection(@"DataSource = E:\test\Informacionna_Sistema\WindowsFormsApplication1\bin\Debug\BazaDanni.sdf");

        public AddSpecialnosti()
        {
            InitializeComponent();
        }

        private void btnAddDis_Click(object sender, EventArgs e)
        {
            if (txtDisKod.Text == "" || txtDisIme.Text == "")
            {
                MessageBox.Show("Полетета Id и име не могат бъдат празни!");
                return;
            }
            try
            {
                cn.Open();
                SqlCeCommand addCmd = new SqlCeCommand("INSERT INTO Disciplini (Kod, Ime, KodPredmet) VALUES (@Kod, @Ime, @KodPredmet)", cn);
                addCmd.Parameters.AddWithValue("@Kod", txtDisKod.Text);
                addCmd.Parameters.AddWithValue("@Ime", txtDisIme.Text);
                addCmd.Parameters.AddWithValue("@KodPredmet", txtDisPred.Text);
                addCmd.ExecuteNonQuery();
                MessageBox.Show("Дисциплината е добавена!");
                addCmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }

        private void btnClearDis_Click(object sender, EventArgs e)
        {
            txtDisKod.Text = "";
            txtDisIme.Text = "";
            txtDisPred.Text = "";
        }
    }
}
