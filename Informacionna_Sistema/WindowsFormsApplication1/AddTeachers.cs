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
    public partial class AddTeachers : Form
    {
        public AddTeachers()
        {
            InitializeComponent();
        }

        public SqlCeConnection cn = new SqlCeConnection(@"DataSource = E:\test\Informacionna_Sistema\WindowsFormsApplication1\bin\Debug\BazaDanni.sdf");

        private void btnAddTch_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || txtSurname.Text == "")
            {
                MessageBox.Show("Полетета за Id, име и фамилия не могат бъдат празни!");
                return;
            }

            try
            {
                cn.Open();
                SqlCeCommand addCmd = new SqlCeCommand("INSERT INTO Teachers (Id_Teacher, Title, Name, Middlename, Surname, Office, Number) VALUES (@Id_Teacher, @Title, @Name, @Middlename, @Surname, @Office, @Number)", cn);
                addCmd.Parameters.AddWithValue("@Id_Teacher", txtId.Text);
                addCmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                addCmd.Parameters.AddWithValue("@Name", txtName.Text);
                addCmd.Parameters.AddWithValue("@Middlename", txtMiddlename.Text);
                addCmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                addCmd.Parameters.AddWithValue("@Office", txtOffice.Text);
                addCmd.Parameters.AddWithValue("@Number", txtNumber.Text);
                addCmd.ExecuteNonQuery();
                MessageBox.Show("Преподавателя е добавен!");
                addCmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnClearTch_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtTitle.Text = "";
            txtName.Text = "" ;
            txtMiddlename.Text= "";
            txtSurname.Text = "";
            txtOffice.Text = "";
            txtNumber.Text = "";
        }
    }
}
