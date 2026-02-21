using static System.Net.Mime.MediaTypeNames;

namespace Minimart
{
    partial class MDIForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuF = new ToolStripMenuItem();
            mnuMax = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuMin = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            mnuNomalF = new ToolStripMenuItem();
            mnuCloseF = new ToolStripMenuItem();
            mnuCloseAllF = new ToolStripMenuItem();
            mnuCRUD = new ToolStripMenuItem();
            mnuProducts = new ToolStripMenuItem();
            mnuEmployees = new ToolStripMenuItem();
            mnuCategory = new ToolStripMenuItem();
            mnuReport = new ToolStripMenuItem();
            nmufrmProduct_by_Category = new ToolStripMenuItem();
            nmufrmEmployees_sales = new ToolStripMenuItem();
            mnuPOS = new ToolStripMenuItem();
            mnuLogout = new ToolStripMenuItem();
            mnuLogin = new ToolStripMenuItem();
            mnuArrangeF = new ToolStripMenuItem();
            mnuVertical = new ToolStripMenuItem();
            mnuHorizontal = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuF, mnuCRUD, mnuReport, mnuPOS, mnuLogout, mnuLogin, mnuArrangeF });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1525, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mnuF
            // 
            mnuF.BackColor = Color.Blue;
            mnuF.DropDownItems.AddRange(new ToolStripItem[] { mnuMax, toolStripMenuItem1, mnuMin, toolStripMenuItem2, mnuExit, toolStripMenuItem3, mnuNomalF, mnuCloseF, mnuCloseAllF });
            mnuF.Name = "mnuF";
            mnuF.Size = new Size(55, 24);
            mnuF.Text = "ฟอร์ม";
            // 
            // mnuMax
            // 
            mnuMax.Name = "mnuMax";
            mnuMax.Size = new Size(251, 26);
            mnuMax.Text = "ขยาย (Maximized)";
            mnuMax.Click += mnuMax_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(248, 6);
            // 
            // mnuMin
            // 
            mnuMin.Name = "mnuMin";
            mnuMin.Size = new Size(251, 26);
            mnuMin.Text = "ย่อ  (Minimized)";
            mnuMin.Click += mnuMin_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(248, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(251, 26);
            mnuExit.Text = "ปิดโปรแกรม (exit)";
            mnuExit.Click += mnuExit_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(248, 6);
            // 
            // mnuNomalF
            // 
            mnuNomalF.Name = "mnuNomalF";
            mnuNomalF.Size = new Size(251, 26);
            mnuNomalF.Text = "ปกติ(Nomal)";
            mnuNomalF.Click += mnuNomalF_Click;
            // 
            // mnuCloseF
            // 
            mnuCloseF.Name = "mnuCloseF";
            mnuCloseF.Size = new Size(251, 26);
            mnuCloseF.Text = "ปิดฟอร์ม(Close)";
            mnuCloseF.Click += mnuCloseF_Click;
            // 
            // mnuCloseAllF
            // 
            mnuCloseAllF.Name = "mnuCloseAllF";
            mnuCloseAllF.Size = new Size(251, 26);
            mnuCloseAllF.Text = "ปิดฟอร์มทั้งหมด(Close All)";
            mnuCloseAllF.Click += mnuCloseAllF_Click;
            // 
            // mnuCRUD
            // 
            mnuCRUD.DropDownItems.AddRange(new ToolStripItem[] { mnuProducts, mnuEmployees, mnuCategory });
            mnuCRUD.Name = "mnuCRUD";
            mnuCRUD.Size = new Size(206, 24);
            mnuCRUD.Text = "จัดการข้อมูลสินค้า(mnuCRUD)";
            mnuCRUD.Click += จดการขอมลสนคาmnuCRUDToolStripMenuItem_Click;
            // 
            // mnuProducts
            // 
            mnuProducts.Name = "mnuProducts";
            mnuProducts.Size = new Size(239, 26);
            mnuProducts.Text = "จัดการข้อมูลสินค้า";
            mnuProducts.Click += mnuProducts_Click;
            // 
            // mnuEmployees
            // 
            mnuEmployees.Name = "mnuEmployees";
            mnuEmployees.Size = new Size(239, 26);
            mnuEmployees.Text = "จัดการข้อมูลพนักงาน";
            mnuEmployees.Click += mnuEmployees_Click;
            // 
            // mnuCategory
            // 
            mnuCategory.Name = "mnuCategory";
            mnuCategory.Size = new Size(239, 26);
            mnuCategory.Text = "จัดการข้อมูลประเภทสิ้นค้า";
            mnuCategory.Click += mnuCategory_Click;
            // 
            // mnuReport
            // 
            mnuReport.DropDownItems.AddRange(new ToolStripItem[] { nmufrmProduct_by_Category, nmufrmEmployees_sales });
            mnuReport.Name = "mnuReport";
            mnuReport.Size = new Size(170, 24);
            mnuReport.Text = "แสดงข้อมูล(mnuReport)";
            // 
            // nmufrmProduct_by_Category
            // 
            nmufrmProduct_by_Category.Name = "nmufrmProduct_by_Category";
            nmufrmProduct_by_Category.Size = new Size(248, 26);
            nmufrmProduct_by_Category.Text = "ข้อมูลสินค้าตามประเภท";
            nmufrmProduct_by_Category.Click += nmufrmProduct_by_Category_Click;
            // 
            // nmufrmEmployees_sales
            // 
            nmufrmEmployees_sales.Name = "nmufrmEmployees_sales";
            nmufrmEmployees_sales.Size = new Size(248, 26);
            nmufrmEmployees_sales.Text = "ขอมูลยอดขายตามพนักงาน";
            nmufrmEmployees_sales.Click += nmufrmEmployees_sales_Click;
            // 
            // mnuPOS
            // 
            mnuPOS.Name = "mnuPOS";
            mnuPOS.Size = new Size(170, 24);
            mnuPOS.Text = "จำหน่ายสินค้า(mnuPOS)";
            // 
            // mnuLogout
            // 
            mnuLogout.Name = "mnuLogout";
            mnuLogout.Size = new Size(187, 24);
            mnuLogout.Text = "ออกจากระบบ(mnuLogout)";
            mnuLogout.Click += mnuLogout_Click;
            // 
            // mnuLogin
            // 
            mnuLogin.Name = "mnuLogin";
            mnuLogin.Size = new Size(156, 24);
            mnuLogin.Text = "เข้าสู่ระบบ(mnuLogin)";
            mnuLogin.Click += mnuLogin_Click;
            // 
            // mnuArrangeF
            // 
            mnuArrangeF.BackColor = Color.Blue;
            mnuArrangeF.DropDownItems.AddRange(new ToolStripItem[] { mnuVertical, mnuHorizontal });
            mnuArrangeF.Name = "mnuArrangeF";
            mnuArrangeF.Size = new Size(96, 24);
            mnuArrangeF.Text = "จัดเรียงฟอร์ม";
            // 
            // mnuVertical
            // 
            mnuVertical.Name = "mnuVertical";
            mnuVertical.Size = new Size(141, 26);
            mnuVertical.Text = "แนวตั้ง";
            mnuVertical.Click += mnuVertical_Click;
            // 
            // mnuHorizontal
            // 
            mnuHorizontal.Name = "mnuHorizontal";
            mnuHorizontal.Size = new Size(141, 26);
            mnuHorizontal.Text = "แนวนอน";
            mnuHorizontal.Click += mnuHorizontal_Click;
            // 
            // MDIForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1525, 608);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MDIForm";
            Text = "ระบบงานร้านค้าขนาดเล็ก";
            Load += MDIForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuF;
        private ToolStripMenuItem mnuMax;
        private ToolStripMenuItem mnuMin;
        private ToolStripMenuItem mnuExit;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem mnuArrangeF;
        private ToolStripMenuItem mnuVertical;
        private ToolStripMenuItem mnuHorizontal;
        private ToolStripMenuItem mnuNomalF;
        private ToolStripMenuItem mnuCloseF;
        private ToolStripMenuItem mnuCloseAllF;
        private ToolStripMenuItem mnuCRUD;
        private ToolStripMenuItem mnuProducts;
        private ToolStripMenuItem mnuEmployees;
        private ToolStripMenuItem mnuCategory;
        private ToolStripMenuItem mnuReport;
        private ToolStripMenuItem nmufrmProduct_by_Category;
        private ToolStripMenuItem nmufrmEmployees_sales;
        private ToolStripMenuItem mnuPOS;
        private ToolStripMenuItem mnuLogout;
        private ToolStripMenuItem mnuLogin;
    }
}
