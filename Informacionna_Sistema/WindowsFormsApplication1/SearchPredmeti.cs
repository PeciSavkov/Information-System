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
    public partial class SearchPredmeti : Form
    {
        public SqlCeConnection cn = new SqlCeConnection(@"DataSource = E:\test\Informacionna_Sistema\WindowsFormsApplication1\bin\Debug\BazaDanni.sdf");

        public SearchPredmeti()
        {
            InitializeComponent();
        }

        private void SearchPredmeti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Predmeti' table. You can move, or remove it, as needed.
            this.predmetiTableAdapter.Fill(this.database1DataSet.Predmeti);

        }

        private void searchNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.predmetiTableAdapter.SearchName(this.database1DataSet.Predmeti, nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void btnSearchPred_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Въведи данни за търсене!");
                dgvPredmeti.Hide();
                return;
            }

            try
            {
                cn.Open();
                this.predmetiTableAdapter.SearchName(this.database1DataSet.Predmeti, txtName.Text);
                if (dgvPredmeti.Rows.Count == 0)
                {
                    dgvPredmeti.Hide();
                    MessageBox.Show("Няма намерени резултати!");
                    return;
                }
                dgvPredmeti.Show();
                cn.Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                cn.Close();
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
