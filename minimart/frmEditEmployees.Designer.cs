namespace Minimart
{
    partial class frmEditEmployees
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtEmployeeID = new TextBox();
            cboTitle = new ComboBox();
            cboPosition = new ComboBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnSave = new Button();
            btnClearForm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 33);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "รหัสพนักงาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 78);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "คำนำหน้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 126);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 2;
            label3.Text = "ชื่อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 172);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "นามสกุล";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 215);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 4;
            label5.Text = "ตำแหน่ง";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 263);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 5;
            label6.Text = "ชื่อผู้ใช้";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(109, 312);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 6;
            label7.Text = "รหัสผ่าน";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(76, 362);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 7;
            label8.Text = "รหัสผ่านยืนยัน";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(173, 30);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(210, 27);
            txtEmployeeID.TabIndex = 8;
            // 
            // cboTitle
            // 
            cboTitle.FormattingEnabled = true;
            cboTitle.Location = new Point(173, 75);
            cboTitle.Name = "cboTitle";
            cboTitle.Size = new Size(180, 28);
            cboTitle.TabIndex = 9;
            cboTitle.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cboPosition
            // 
            cboPosition.FormattingEnabled = true;
            cboPosition.Location = new Point(173, 212);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(180, 28);
            cboPosition.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(172, 123);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(211, 27);
            txtFirstName.TabIndex = 11;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(173, 169);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(210, 27);
            txtLastName.TabIndex = 12;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(173, 260);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(210, 27);
            txtUserName.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(172, 309);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(211, 27);
            txtPassword.TabIndex = 14;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(173, 359);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(210, 27);
            txtConfirmPassword.TabIndex = 15;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(172, 450);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 16;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClearForm
            // 
            btnClearForm.Location = new Point(289, 450);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(94, 29);
            btnClearForm.TabIndex = 17;
            btnClearForm.Text = "ล้างฟอร์ม";
            btnClearForm.UseVisualStyleBackColor = true;
            // 
            // frmEditEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(516, 541);
            Controls.Add(btnClearForm);
            Controls.Add(btnSave);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(cboPosition);
            Controls.Add(cboTitle);
            Controls.Add(txtEmployeeID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditEmployees";
            Text = "frmEditEmployees";
            Load += frmEditEmployees_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtEmployeeID;
        private ComboBox cboTitle;
        private ComboBox cboPosition;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnSave;
        private Button btnClearForm;
    }
}