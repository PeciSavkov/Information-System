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
    public partial class ViewSpecialnosti : Form
    {
        public SqlCeConnection cn = new SqlCeConnection(@"DataSource = E:\test\Informacionna_Sistema\WindowsFormsApplication1\bin\Debug\BazaDanni.sdf");

        public ViewSpecialnosti()
        {
            InitializeComponent();
        }

        private void ViewSpecialnosti_Load(object sender, EventArgs e)
        {
            cn.Open();
            this.discipliniTableAdapter.Fill(this.database1DataSet.Disciplini);
            cn.Close();
        }
    }
}
