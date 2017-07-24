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
    public partial class ViewTeachers : Form
    {
        public SqlCeConnection cn = new SqlCeConnection(@"DataSource = E:\test\Informacionna_Sistema\WindowsFormsApplication1\bin\Debug\BazaDanni.sdf");

        public ViewTeachers()
        {
            InitializeComponent();
        }

        private void ViewTeachers_Load(object sender, EventArgs e)
        {
            cn.Open();
            this.teachersTableAdapter.Fill(this.database1DataSet.Teachers);
            cn.Close();
        }
    }
}
