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
    public partial class SearchTeachers : Form
    {
        public SqlCeConnection cn = new SqlCeConnection(@"DataSource = E:\test\Informacionna_Sistema\WindowsFormsApplication1\bin\Debug\BazaDanni.sdf");

        public SearchTeachers()
        {
            InitializeComponent();
        }

        private void SearchTeachers_Load(object sender, EventArgs e)
        {
            cn.Open();
            this.teachersTableAdapter.Fill(this.database1DataSet.Teachers);
            cn.Close();
        }

        private void searchNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.teachersTableAdapter.SearchName(this.database1DataSet.Teachers, nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchSurnameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.teachersTableAdapter.SearchSurname(this.database1DataSet.Teachers, surnameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchNameSurnameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.teachersTableAdapter.SearchNameSurname(this.database1DataSet.Teachers, nameToolStripTextBox1.Text, surnameToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnSearchTch_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtSurname.Text == "")
            {
                MessageBox.Show("Въведи данни за търсене!");
                return;
            }

            if (txtSurname.Text == "")
            {
                try
                {
                    cn.Open();
                    this.teachersTableAdapter.SearchName(this.database1DataSet.Teachers, txtName.Text);
                    dgvTeachers.Show();
                    if (dgvTeachers.Rows.Count == 0)
                    {
                        dgvTeachers.Hide();
                        MessageBox.Show("Няма намерени резултати!");
                        return;
                    }
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
            else if (txtName.Text == "")
            {
                try
                {
                    cn.Open();
                    this.teachersTableAdapter.SearchSurname(this.database1DataSet.Teachers, txtSurname.Text);
                    dgvTeachers.Show();
                    if (dgvTeachers.Rows.Count == 0)
                    {
                        dgvTeachers.Hide();
                        MessageBox.Show("Няма намерени резултати!");
                        return;
                    }
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
            else
            {
                try
                {
                    cn.Open();
                    this.teachersTableAdapter.SearchNameSurname(this.database1DataSet.Teachers, txtName.Text, txtSurname.Text);
                    dgvTeachers.Show();
                    if (dgvTeachers.Rows.Count == 0)
                    {
                        dgvTeachers.Hide();
                        MessageBox.Show("Няма намерени резултати!");
                        return;
                    }
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

        private void searchNameToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.teachersTableAdapter.SearchName(this.database1DataSet.Teachers, nameToolStripTextBox2.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
