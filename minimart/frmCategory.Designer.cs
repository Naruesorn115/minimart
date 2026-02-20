
namespace Minimart
{
    partial class frmCategory
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
            dgvCategory = new DataGridView();
            label1 = new Label();
            txtSearch = new TextBox();
            btnInsert = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // dgvCategory
            // 
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AllowUserToDeleteRows = false;
            dgvCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(31, 130);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.Size = new Size(796, 407);
            dgvCategory.TabIndex = 0;
            dgvCategory.CellDoubleClick += dgvCategory_CellDoubleClick;
            dgvCategory.CellMouseUp += dgvCategory_CellMouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 70);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 1;
            label1.Text = "ค้นหาหมวดหมู่";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(203, 67);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(319, 34);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(559, 62);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(117, 36);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "เพิ่ม";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(720, 63);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 36);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "ลบ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(850, 558);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dgvCategory);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmCategory";
            Text = "frmCategory";
            Load += frmCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategory;
        private Label label1;
        private TextBox txtSearch;
        private Button btnInsert;
        private Button btnDelete;
    }
}