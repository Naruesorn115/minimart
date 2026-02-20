
namespace Minimart
{
    partial class frmEditCategory
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
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            txtDescription = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 66);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 0;
            label1.Text = "รหัสหมวดหมู่สินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 118);
            label2.Name = "label2";
            label2.Size = new Size(146, 28);
            label2.TabIndex = 1;
            label2.Text = "ชื่อหมวดหมู่สินค้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 170);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 2;
            label3.Text = "รายละเอียด";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(204, 69);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(125, 34);
            txtCategoryID.TabIndex = 3;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(203, 118);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(125, 34);
            txtCategoryName.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(200, 169);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(242, 101);
            txtDescription.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(183, 297);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 41);
            btnSave.TabIndex = 6;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(293, 297);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 42);
            btnClear.TabIndex = 7;
            btnClear.Text = "ล้างฟอร์ม";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmEditCategory
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(639, 400);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmEditCategory";
            Text = "frmEditCategory";
            Load += frmEditCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
        private TextBox txtDescription;
        private Button btnSave;
        private Button btnClear;
    }
}