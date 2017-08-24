using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace photostudio
{
    public partial class master : Form
    {
        private int childFormNumber = 0;

        public master()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void studioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studio fm = new Studio();
            fm.MdiParent = this;
            fm.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer cs = new Customer();
            cs.MdiParent = this;
            cs.Show();
        }

        private void photToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Photo_size ps = new Photo_size();
            ps.MdiParent = this;
            ps.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password cp = new Change_Password();
            cp.MdiParent = this;
            cp.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Income im = new Income();
            im.MdiParent = this;
            im.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Expense exn = new Expense();
            exn.MdiParent = this;
            exn.Show();
        }
        
        private void searchByNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_name cname = new Customer_name();
            cname.Show();
        }

        private void searchByStatusToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cust_bystatus_report cstatus = new cust_bystatus_report();
            cstatus.Show();
        }

        private void totalIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            branch_totalincome bincome = new branch_totalincome();
            bincome.Show();
        }

        private void searchByRangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Expense_report expreport = new Expense_report();
            expreport.Show();
        }

        private void balancedSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Balanced_sheet balsheet = new Balanced_sheet();
            balsheet.Show();
        }
    }
}
