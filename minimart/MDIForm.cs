namespace Minimart
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void mnuMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void mnuMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mnuFA_Click(object sender, EventArgs e)
        {
            Form1 fA = new Form1();
            fA.MdiParent = this;
            fA.Show();
        }

        private void mnuFB_Click(object sender, EventArgs e)
        {
            frmCategory fB = new frmCategory();
            fB.MdiParent = this;
            fB.Show();
        }

        private void mnuFC_Click(object sender, EventArgs e)
        {
            frmEditCategory fC = new frmEditCategory();
            fC.MdiParent = this;
            fC.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuNomalF_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void mnuCloseF_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {

                this.MdiChildren[0].Close();
            }
        }

        private void mnuCloseAllF_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void เปดToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts fP = new frmProducts();
            fP.MdiParent = this;
            fP.Show();
        }

        private void เปดฟอรมfrmPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPOS fPOS = new frmPOS();
            fPOS.MdiParent = this;
            fPOS.Show();
        }
    }
}
