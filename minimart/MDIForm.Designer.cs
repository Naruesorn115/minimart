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
            mnuFA = new ToolStripMenuItem();
            mnuFB = new ToolStripMenuItem();
            mnuFC = new ToolStripMenuItem();
            mnuP = new ToolStripMenuItem();
            mnuArrangeF = new ToolStripMenuItem();
            mnuVertical = new ToolStripMenuItem();
            mnuHorizontal = new ToolStripMenuItem();
            เปดฟอรมfrmPOSToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuF, mnuFA, mnuFB, mnuFC, mnuP, เปดฟอรมfrmPOSToolStripMenuItem, mnuArrangeF });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1220, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuF
            // 
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
            // mnuFA
            // 
            mnuFA.Name = "mnuFA";
            mnuFA.Size = new Size(119, 24);
            mnuFA.Text = "เปิดฟอร์มForm1";
            mnuFA.Click += mnuFA_Click;
            // 
            // mnuFB
            // 
            mnuFB.Name = "mnuFB";
            mnuFB.Size = new Size(160, 24);
            mnuFB.Text = "เปิดฟอร์มfrmCategory";
            mnuFB.Click += mnuFB_Click;
            // 
            // mnuFC
            // 
            mnuFC.Name = "mnuFC";
            mnuFC.Size = new Size(186, 24);
            mnuFC.Text = "เปิดฟอร์มfrmEditCategory";
            mnuFC.Click += mnuFC_Click;
            // 
            // mnuP
            // 
            mnuP.Name = "mnuP";
            mnuP.Size = new Size(157, 24);
            mnuP.Text = "เปิดฟอร์มfrmProducts";
            mnuP.Click += เปดToolStripMenuItem_Click;
            // 
            // mnuArrangeF
            // 
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
            // เปดฟอรมfrmPOSToolStripMenuItem
            // 
            เปดฟอรมfrmPOSToolStripMenuItem.Name = "เปดฟอรมfrmPOSToolStripMenuItem";
            เปดฟอรมfrmPOSToolStripMenuItem.Size = new Size(127, 24);
            เปดฟอรมfrmPOSToolStripMenuItem.Text = "เปิดฟอร์มfrmPOS";
            เปดฟอรมfrmPOSToolStripMenuItem.Click += เปดฟอรมfrmPOSToolStripMenuItem_Click;
            // 
            // MDIForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 608);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MDIForm";
            Text = "Form1";
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
        private ToolStripMenuItem mnuFA;
        private ToolStripMenuItem mnuFB;
        private ToolStripMenuItem mnuFC;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem mnuArrangeF;
        private ToolStripMenuItem mnuVertical;
        private ToolStripMenuItem mnuHorizontal;
        private ToolStripMenuItem mnuNomalF;
        private ToolStripMenuItem mnuCloseF;
        private ToolStripMenuItem mnuCloseAllF;
        private ToolStripMenuItem mnuP;
        private ToolStripMenuItem เปดฟอรมfrmPOSToolStripMenuItem;
    }
}
