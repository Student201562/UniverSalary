using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaUniversity
{
    public partial class fMain : Form
    {
        fAccrueSholarship accrueSholarship = new fAccrueSholarship();
        fAccrueSalary accrueSalary = new fAccrueSalary();
        fViewList viewList = new fViewList();
        fGetReport getReport = new fGetReport();
        public fMain()
        {
            InitializeComponent();
        }

        private void butAccrueScholarship_Click(object sender, EventArgs e)
        {
            this.accrueSholarship.ShowDialog();
        }

        private void butAccrueSalary_Click(object sender, EventArgs e)
        {
            this.accrueSalary.ShowDialog();
;        }

        private void butViewLists_Click(object sender, EventArgs e)
        {
            this.viewList.ShowDialog();
        }

        private void butGetRepot_Click(object sender, EventArgs e)
        {
            this.getReport.ShowDialog();
        }
        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
