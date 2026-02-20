
namespace Minimart
{
    partial class frmEditProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        //#region Windows Form Designer generated code

        ///// <summary>
        ///// Required method for Designer support - do not modify
        ///// the contents of this method with the code editor.
        ///// </summary>
        //private void InitializeComponent()
        //{
        //    this.components = new System.ComponentModel.Container();
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(800, 450);
        //    this.Text = "frmEditProducts";
        //}

        //#endregion
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            radDiscontinued = new RadioButton();
            radContinued = new RadioButton();
            groupBox1 = new GroupBox();
            cboCategory = new ComboBox();
            txtProductName = new TextBox();
            label8 = new Label();
            label3 = new Label();
            txtUnitsInStock = new TextBox();
            label9 = new Label();
            label2 = new Label();
            txtUnitPrice = new TextBox();
            label1 = new Label();
            txtProductID = new TextBox();
            btnClear = new Button();
            btnSave = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radDiscontinued);
            groupBox2.Controls.Add(radContinued);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox2.Location = new Point(248, 330);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(340, 135);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "สถานะของสินค้า";
            // 
            // radDiscontinued
            // 
            radDiscontinued.AutoSize = true;
            radDiscontinued.Location = new Point(34, 87);
            radDiscontinued.Margin = new Padding(4, 5, 4, 5);
            radDiscontinued.Name = "radDiscontinued";
            radDiscontinued.Size = new Size(117, 29);
            radDiscontinued.TabIndex = 22;
            radDiscontinued.TabStop = true;
            radDiscontinued.Text = "เลิกจำหน่าย";
            radDiscontinued.UseVisualStyleBackColor = true;
            // 
            // radContinued
            // 
            radContinued.AutoSize = true;
            radContinued.Location = new Point(34, 40);
            radContinued.Margin = new Padding(4, 5, 4, 5);
            radContinued.Name = "radContinued";
            radContinued.Size = new Size(125, 29);
            radContinued.TabIndex = 21;
            radContinued.TabStop = true;
            radContinued.Text = "จำหน่ายปกติ";
            radContinued.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboCategory);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtUnitsInStock);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox1.Location = new Point(39, 14);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(549, 306);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "จัดการข้อมูลสินค้า";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(147, 235);
            cboCategory.Margin = new Padding(4, 5, 4, 5);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(260, 33);
            cboCategory.TabIndex = 17;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(147, 88);
            txtProductName.Margin = new Padding(4, 5, 4, 5);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(260, 30);
            txtProductName.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 197);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(63, 25);
            label8.TabIndex = 15;
            label8.Text = "จำนวน";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 148);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 14;
            label3.Text = "ราคา";
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(147, 186);
            txtUnitsInStock.Margin = new Padding(4, 5, 4, 5);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(116, 30);
            txtUnitsInStock.TabIndex = 3;
            txtUnitsInStock.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1, 247);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(109, 25);
            label9.TabIndex = 3;
            label9.Text = "ประเภทสินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 3;
            label2.Text = "ชื่อสินค้า";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(147, 137);
            txtUnitPrice.Margin = new Padding(4, 5, 4, 5);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(116, 30);
            txtUnitPrice.TabIndex = 2;
            txtUnitPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 1;
            label1.Text = "รหัสสินค้า";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(147, 38);
            txtProductID.Margin = new Padding(4, 5, 4, 5);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(185, 30);
            txtProductID.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(320, 498);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 34);
            btnClear.TabIndex = 37;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(186, 498);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 34);
            btnSave.TabIndex = 37;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmEditProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(602, 570);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmEditProducts";
            Text = "แบบฟอร์มข้อมูลสินค้า";
            Load += frmEditProducts_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private RadioButton radDiscontinued;
        private RadioButton radContinued;
        private GroupBox groupBox1;
        private ComboBox cboCategory;
        private TextBox txtProductName;
        private Label label8;
        private Label label3;
        private TextBox txtUnitsInStock;
        private Label label9;
        private Label label2;
        private TextBox txtUnitPrice;
        private Label label1;
        private TextBox txtProductID;
        private Button btnClear;
        private Button btnSave;

    }
}