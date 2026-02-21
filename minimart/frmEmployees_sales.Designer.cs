namespace Minimart
{
    partial class frmEmployees_sales
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
            dgvEmployees = new DataGridView();
            dgvReceipts = new DataGridView();
            btnALL = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReceipts).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(12, 12);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(450, 542);
            dgvEmployees.TabIndex = 0;
            dgvEmployees.CellContentClick += dataGridView1_CellContentClick;
            dgvEmployees.CellMouseUp += dgvEmployees_CellMouseUp;
            // 
            // dgvReceipts
            // 
            dgvReceipts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReceipts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReceipts.Location = new Point(468, 12);
            dgvReceipts.Name = "dgvReceipts";
            dgvReceipts.RowHeadersWidth = 51;
            dgvReceipts.Size = new Size(490, 542);
            dgvReceipts.TabIndex = 1;
            // 
            // btnALL
            // 
            btnALL.Location = new Point(1054, 231);
            btnALL.Name = "btnALL";
            btnALL.Size = new Size(94, 29);
            btnALL.TabIndex = 2;
            btnALL.Text = "ShowALL";
            btnALL.UseVisualStyleBackColor = true;
            btnALL.Click += button1_Click;
            // 
            // frmEmployees_sales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 566);
            Controls.Add(btnALL);
            Controls.Add(dgvReceipts);
            Controls.Add(dgvEmployees);
            Name = "frmEmployees_sales";
            Text = "frmEmployees_sales";
            Load += frmEmployees_sales_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReceipts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmployees;
        private DataGridView dgvReceipts;
        private Button btnALL;
    }
}