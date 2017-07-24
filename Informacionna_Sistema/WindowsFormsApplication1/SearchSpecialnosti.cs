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
    public partial class SearchSpecialnosti : Form
    {
        public SqlCeConnection cn = new SqlCeConnection(@"DataSource = E:\test\Informacionna_Sistema\WindowsFormsApplication1\bin\Debug\BazaDanni.sdf");

        public SearchSpecialnosti()
        {
            InitializeComponent();
        }

        private void SearchSpecialnosti_Load(object sender, EventArgs e)
        {
            cn.Open();
            this.discipliniTableAdapter.Fill(this.database1DataSet.Disciplini);
            cn.Close();
        }

        private void searchDisNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.discipliniTableAdapter.SearchDisName(this.database1DataSet.Disciplini, nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void btnSearchDis_Click(object sender, EventArgs e)
        {
            if (txtNameDis.Text == "")
            {
                MessageBox.Show("Въведи данни за търсене!");
                dgvDis.Hide();
                return;
            }

            try
            {
                cn.Open();
                this.discipliniTableAdapter.SearchDisName(this.database1DataSet.Disciplini, txtNameDis.Text);
                dgvDis.Show();
                if (dgvDis.Rows.Count == 0)
                {
                    dgvDis.Hide();
                    MessageBox.Show("Няма намерени резултати!");
                    return;
                }
                cn.Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
