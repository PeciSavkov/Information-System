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
    public partial class AddPredmeti : Form
    {
        public AddPredmeti()
        {
            InitializeComponent();
        }

        public SqlCeConnection cn = new SqlCeConnection(@"DataSource = E:\test\Informacionna_Sistema\WindowsFormsApplication1\bin\Debug\BazaDanni.sdf");

        private void btnAddPred_Click(object sender, EventArgs e)
        {
            if (txtIdPred.Text == "" || txtImePred.Text == "" )
            {
                MessageBox.Show("Полетета за Id, име и фамилия не могат бъдат празни!");
                return;
            }
            try
            {
                cn.Open();
                SqlCeCommand addCmd = new SqlCeCommand("INSERT INTO Predmeti (KodPredmet, Ime, Horarium, KodDisciplina, IdTch) VALUES (@KodPredmet, @Ime, @Horarium, @KodDisciplina, @IdTch)", cn);
                addCmd.Parameters.AddWithValue("@KodPredmet", txtKodPred.Text);
                addCmd.Parameters.AddWithValue("@Ime", txtImePred.Text);
                addCmd.Parameters.AddWithValue("@Horarium", txtHorPred.Text);
                addCmd.Parameters.AddWithValue("@KodDisciplin", txtDisPred.Text);
                addCmd.Parameters.AddWithValue("@IdTch", txtIdPred.Text);
                addCmd.ExecuteNonQuery();
                MessageBox.Show("Предметът е добавен!");
                addCmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }

        private void btnClearPred_Click(object sender, EventArgs e)
        {
            txtKodPred.Text = "";
            txtImePred.Text = "";
            txtHorPred.Text = "";
            txtDisPred.Text = "";
            txtIdPred.Text = "";
        }
    }
}
