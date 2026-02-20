
namespace Minimart
{
    partial class frmPOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtEmployeeID = new TextBox();
            label2 = new Label();
            txtEmployeeName = new TextBox();
            lblNetPrice = new Label();
            groupBox1 = new GroupBox();
            lsvProduct = new ListView();
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            label4 = new Label();
            txtTotal = new TextBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            label7 = new Label();
            label5 = new Label();
            btnAdd = new Button();
            btnClear = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            label8 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 10;
            label1.Text = "รหัสพนักงาน";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(113, 22);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(87, 27);
            txtEmployeeID.TabIndex = 9;
            txtEmployeeID.KeyDown += txtEmployeeID_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 25);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 8;
            label2.Text = "ชื่อ-สกุล";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.BackColor = Color.FromArgb(224, 224, 224);
            txtEmployeeName.Location = new Point(269, 25);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.ReadOnly = true;
            txtEmployeeName.Size = new Size(207, 27);
            txtEmployeeName.TabIndex = 7;
            // 
            // lblNetPrice
            // 
            lblNetPrice.BackColor = Color.Gray;
            lblNetPrice.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetPrice.ForeColor = Color.White;
            lblNetPrice.Location = new Point(742, 9);
            lblNetPrice.Name = "lblNetPrice";
            lblNetPrice.Size = new Size(218, 86);
            lblNetPrice.TabIndex = 6;
            lblNetPrice.Text = "0.00";
            lblNetPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 128);
            groupBox1.Controls.Add(lsvProduct);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(23, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(713, 453);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "รายการสั่งซื้อ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lsvProduct
            // 
            lsvProduct.Location = new Point(17, 94);
            lsvProduct.Name = "lsvProduct";
            lsvProduct.Size = new Size(679, 335);
            lsvProduct.TabIndex = 11;
            lsvProduct.UseCompatibleStateImageBehavior = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(482, 38);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 10;
            label10.Text = "จำนวน";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(347, 39);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 9;
            label9.Text = "ราคาขาย";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(196, 39);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 8;
            label6.Text = "ชื่อสินค้า";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 39);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 7;
            label4.Text = "รหัสสินค้า";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.FromArgb(224, 224, 224);
            txtTotal.Location = new Point(571, 61);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(111, 27);
            txtTotal.TabIndex = 0;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(470, 61);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(74, 27);
            txtQuantity.TabIndex = 1;
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            txtQuantity.KeyDown += txtQuantity_KeyDown;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = Color.FromArgb(224, 224, 224);
            txtUnitPrice.Location = new Point(334, 62);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(109, 27);
            txtUnitPrice.TabIndex = 2;
            txtUnitPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.FromArgb(224, 224, 224);
            txtProductName.Location = new Point(144, 62);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(165, 27);
            txtProductName.TabIndex = 3;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(17, 61);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(112, 27);
            txtProductID.TabIndex = 4;
            txtProductID.KeyDown += txtProductID_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(591, 38);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 5;
            label7.Text = "รวมเป็นเงิน";
            // 
            // label5
            // 
            label5.Location = new Point(197, 72);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(224, 224, 224);
            btnAdd.Location = new Point(742, 137);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(108, 49);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "เพิ่มรายการ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(224, 224, 224);
            btnClear.Location = new Point(742, 230);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(108, 49);
            btnClear.TabIndex = 2;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(224, 224, 224);
            btnSave.Enabled = false;
            btnSave.Location = new Point(742, 343);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 49);
            btnSave.TabIndex = 1;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(224, 224, 224);
            btnCancel.Location = new Point(742, 436);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 69);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "ยกเลิกรายการสั่งซื้อ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label8
            // 
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(665, 32);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 6;
            label3.Text = "รวมเป็นเงิน";
            // 
            // frmPOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(972, 563);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(lblNetPrice);
            Controls.Add(label5);
            Controls.Add(txtEmployeeName);
            Controls.Add(label2);
            Controls.Add(txtEmployeeID);
            Controls.Add(label1);
            Name = "frmPOS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPOS";
            Load += frmReceipt_Details_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmployeeID;
        private Label label2;
        private TextBox txtEmployeeName;
        private Label lblNetPrice;
        private GroupBox groupBox1;
        private Label label7;
        private Label label5;
        private TextBox txtTotal;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private TextBox txtProductID;
        private Button btnAdd;
        private Button btnClear;
        private Button btnSave;
        private Button btnCancel;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label6;
        private Label label4;
        private Label label3;
        private ListView lsvProduct;
    }
}