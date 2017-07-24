using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTch_Click(object sender, EventArgs e)
        {
            this.Size = new Size(520, 270);
            btnAddSpec.Hide();
            btnAddTch.Show();
            btnAddPred.Hide();
            btnSearchPred.Hide();
            btnSearchTch.Show();
            btnSearchSpec.Hide();
            btnViewPred.Hide();
            btnViewTch.Show();
            btnViewSpec.Hide();
        }

        private void btnPred_Click(object sender, EventArgs e)
        {
            this.Size = new Size(520, 270);
            btnAddSpec.Hide();
            btnAddTch.Hide();
            btnAddPred.Show();
            btnSearchPred.Show();
            btnSearchTch.Hide();
            btnSearchSpec.Hide();
            btnViewPred.Show();
            btnViewTch.Hide();
            btnViewSpec.Hide();
        }

        private void btnSpec_Click(object sender, EventArgs e)
        {
            this.Size = new Size(520, 270);
            btnAddSpec.Show();
            btnAddTch.Hide();
            btnAddPred.Hide();
            btnSearchPred.Hide();
            btnSearchTch.Hide();
            btnSearchSpec.Show();
            btnViewPred.Hide();
            btnViewTch.Hide();
            btnViewSpec.Show();
        }

        private void btnAddTch_Click(object sender, EventArgs e)
        {
            AddTeachers popup = new AddTeachers();
            DialogResult dialogResult = popup.ShowDialog();
            popup.Dispose();
        }

        private void btnViewTch_Click(object sender, EventArgs e)
        {
            ViewTeachers popup = new ViewTeachers();
            DialogResult dialogResult = popup.ShowDialog();
            popup.Dispose();
        }

        private void btnSearchTch_Click(object sender, EventArgs e)
        {
            SearchTeachers popup = new SearchTeachers();
            DialogResult dialogResult = popup.ShowDialog();
            popup.Dispose();
        }

        private void btnAddPred_Click(object sender, EventArgs e)
        {
            AddPredmeti popup = new AddPredmeti();
            DialogResult dialogResult = popup.ShowDialog();
            popup.Dispose();
        }

        private void btnViewPred_Click(object sender, EventArgs e)
        {
            ViewPredmeti popup = new ViewPredmeti();
            DialogResult dialogResult = popup.ShowDialog();
            popup.Dispose();
        }

        private void btnSearchPred_Click(object sender, EventArgs e)
        {
            SearchPredmeti popup = new SearchPredmeti();
            DialogResult dialogResult = popup.ShowDialog();
            popup.Dispose();
        }

        private void btnAddSpec_Click(object sender, EventArgs e)
        {
            AddSpecialnosti popup = new AddSpecialnosti();
            DialogResult dialogResult = popup.ShowDialog();
            popup.Dispose();
        }

        private void btnViewSpec_Click(object sender, EventArgs e)
        {
            ViewSpecialnosti popup = new ViewSpecialnosti();
            DialogResult dialogResult = popup.ShowDialog();
            popup.Dispose();
        }

        private void btnSearchSpec_Click(object sender, EventArgs e)
        {
            SearchSpecialnosti popup = new SearchSpecialnosti();
            DialogResult dialogResult = popup.ShowDialog();
            popup.Dispose();
        }

    }
}
