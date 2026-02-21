namespace Minimart
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }
        int employeeID = 0;
        string employeeName = string.Empty;
        string position = string.Empty;

        private void mnuMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void mnuMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void mnuFB_Click(object sender, EventArgs e)
        {
            frmCategory fB = new frmCategory();
            fB.MdiParent = this;
            fB.Show();
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











        private void จดการขอมลสนคาmnuCRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuProducts_Click(object sender, EventArgs e)
        {
            // เช็คว่ามี form ชื่อ frmProducts เปิดอยู่หรือยัง
            Form f = Application.OpenForms["frmProducts"];
            if (f == null)
            {
                frmProducts fP = new frmProducts();
                fP.MdiParent = this;
                fP.Show();
            }
            else
            {
                f.Activate(); // ถ้าเปิดอยู่แล้วให้เด้งขึ้นมาข้างหน้า
            }
        }

        private void mnuEmployees_Click(object sender, EventArgs e)
        {
            frmEmployees fE = new frmEmployees();
            fE.MdiParent = this;
            fE.Show();
        }

        private void mnuCategory_Click(object sender, EventArgs e)
        {
            frmCategory FC = new frmCategory();
            FC.MdiParent = this;
            FC.Show();
        }

        private void nmufrmProduct_by_Category_Click(object sender, EventArgs e)
        {
            frmProduct_by_Category fPC = new frmProduct_by_Category();
            fPC.MdiParent = this;
            fPC.Show();
        }

        private void nmufrmEmployees_sales_Click(object sender, EventArgs e)
        {
            frmEmployees_sales fES = new frmEmployees_sales();
            fES.MdiParent = this;
            fES.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //ShowMenuManager();
            //ShowMenuSale();
            ShowMenuStart();
        }

        private void SetMenuVisible(params ToolStripMenuItem[] menus)
        {
            foreach (ToolStripMenuItem m in menus)
                m.Visible = false;

            foreach (var m in menus)
            {
                m.Visible = true;
            }
        }

        private void ShowMenuStart()
        {
            SetMenuVisible(mnuLogin);
        }

        private void ShowMenuSale()
        {
            SetMenuVisible(mnuReport, nmufrmProduct_by_Category, nmufrmEmployees_sales, mnuLogin);
        }

        private void ShowMenuManager()
        {
            // ผู้จัดการเห็นครบทุกอย่าง
            SetMenuVisible(mnuCRUD, mnuReport, mnuLogout);
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            frmLogin fL = new frmLogin();
            if (fL.ShowDialog() == DialogResult.OK)
            {
                // รับค่าจากหน้า Login
                employeeID = fL.EmployeeID;
                employeeName = fL.EmployeeName;
                position = fL.Position;

                // ลบส่วนที่ Hardcode (ID = 1, สมชาย) ออก!

                if (position == "Sale Manager")
                {
                    ShowMenuManager();
                }
                else
                {
                    ShowMenuSale();
                }
                this.Text = "ผู้ใช้งาน: " + employeeName;
            }
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            employeeID = 0;
            employeeName = string.Empty;
            position = string.Empty;
            this.Text = "Minimart System (Please Login)";

            // ปิดหน้าต่างลูกทั้งหมดที่ค้างอยู่
            mnuCloseAllF_Click(null, null);

            // กลับไปแสดงเฉพาะเมนู Login
            ShowMenuStart();
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {
            ShowMenuStart();
        }

        private void mnuPOS_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่ามีหน้าจอนี้เปิดอยู่แล้วหรือไม่ เพื่อป้องกันการเปิดซ้ำซ้อน
            foreach (Form child in this.MdiChildren)
            {
                if (child is frmPOS)
                {
                    child.Activate();
                    return;
                }
            }

            // สร้าง Instance ใหม่ของ frmPOS
            frmPOS f = new frmPOS();
            f.MdiParent = this; // กำหนดให้ MDIForm นี้เป็นแม่

            // ส่งค่าข้อมูลพนักงานที่ Login อยู่ไปยังหน้า POS
            f.empID = this.employeeID;
            f.empName = this.employeeName;
            f.position = this.position;

            f.Show();
        }
    }
}

