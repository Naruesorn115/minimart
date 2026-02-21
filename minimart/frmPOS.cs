using Microsoft.Data.SqlClient;
using Minimart;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Minimart
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        // Property สำหรับเก็บข้อมูลพนักงาน (รับมาจากหน้า Login)
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int empID { get; set; } = 0;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string empName { get; set; } = "";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string position { get; set; } = "";

        // ตัวแปรเชื่อมต่อฐานข้อมูล
        SqlConnection conn;

        private void frmReceipt_Details_Load(object sender, EventArgs e)
        {
            // เชื่อมต่อ DB (ดึง Connection String จาก Class ConnectDB)
            conn = connectDB.ConnectMinimart();

            ListViewFormat();
            ClearProductData();

            // แสดงข้อมูลพนักงานที่ส่งมาจากหน้า Login (ถ้ามี)
            if (empID > 0)
            {
                txtEmployeeID.Text = this.empID.ToString();
                txtEmployeeName.Text = this.empName;
            }
        }

        private void ListViewFormat()
        {
            lsvProduct.Columns.Clear();
            lsvProduct.Columns.Add("รหัสสินค้า", 120, HorizontalAlignment.Left);
            lsvProduct.Columns.Add("สินค้า", 200, HorizontalAlignment.Left);
            lsvProduct.Columns.Add("ราคา", 120, HorizontalAlignment.Right);
            lsvProduct.Columns.Add("จำนวน", 80, HorizontalAlignment.Center);
            lsvProduct.Columns.Add("รวมเป็นเงิน", 120, HorizontalAlignment.Right);
            lsvProduct.View = View.Details;
            lsvProduct.GridLines = true;
            lsvProduct.FullRowSelect = true;
        }

        private void ClearProductData()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtUnitPrice.Text = "0.00";
            txtQuantity.Text = "1";
            txtTotal.Text = "0.00";
        }

        private void CalculateTotal()
        {
            if (double.TryParse(txtUnitPrice.Text, out double price) &&
                double.TryParse(txtQuantity.Text, out double qty))
            {
                txtTotal.Text = (price * qty).ToString("#,##0.00");
            }
        }

        private void CalculateNetPrice()
        {
            double netPrice = 0.0;
            foreach (ListViewItem item in lsvProduct.Items)
            {
                // ดึงค่าจาก Column "รวมเป็นเงิน" (Index 4)
                netPrice += Convert.ToDouble(item.SubItems[4].Text);
            }
            lblNetPrice.Text = netPrice.ToString("#,##0.00");
        }

        private void txtEmployeeID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtEmployeeID.Text)) return;

                using (SqlConnection tempConn = new SqlConnection(conn.ConnectionString))
                {
                    string sql = "SELECT EmployeeID, Title + FirstName + ' ' + LastName AS EmpName FROM Employees WHERE EmployeeID = @ID";
                    SqlCommand comm = new SqlCommand(sql, tempConn);
                    comm.Parameters.AddWithValue("@ID", txtEmployeeID.Text);

                    tempConn.Open();
                    using (SqlDataReader dr = comm.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtEmployeeID.Text = dr["EmployeeID"].ToString();
                            txtEmployeeName.Text = dr["EmpName"].ToString();
                            txtProductID.Focus();
                        }
                        else
                        {
                            MessageBox.Show("ไม่พบรหัสพนักงานนี้", "ผิดพลาด");
                            txtEmployeeName.Clear();
                            txtEmployeeID.Focus();
                            txtEmployeeID.SelectAll();
                        }
                    }
                }
            }
        }

        private void txtProductID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtProductID.Text)) return;

                using (SqlConnection tempConn = new SqlConnection(conn.ConnectionString))
                {
                    string sql = "SELECT ProductID, ProductName, UnitPrice FROM Products WHERE ProductID = @ID";
                    SqlCommand comm = new SqlCommand(sql, tempConn);
                    comm.Parameters.AddWithValue("@ID", txtProductID.Text);

                    tempConn.Open();
                    using (SqlDataReader dr = comm.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtProductID.Text = dr["ProductID"].ToString();
                            txtProductName.Text = dr["ProductName"].ToString();
                            txtUnitPrice.Text = Convert.ToDouble(dr["UnitPrice"]).ToString("#,##0.00");
                            CalculateTotal();
                            txtQuantity.Focus();
                            txtQuantity.SelectAll();
                        }
                        else
                        {
                            MessageBox.Show("ไม่พบรหัสสินค้า", "ผิดพลาด");
                            ClearProductData();
                            txtProductID.Focus();
                        }
                    }
                }
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantity.Text) || txtQuantity.Text == "0")
            {
                // ป้องกันค่าว่างหรือ 0
                return;
            }
            CalculateTotal();
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick(); // กด Enter ที่ช่องจำนวนให้เหมือนกดปุ่มเพิ่มรายการ
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductID.Text) || txtProductName.Text == "") return;

            // เช็คว่ามีสินค้านี้ใน ListView หรือยัง ถ้ามีให้บวกจำนวนเพิ่ม
            foreach (ListViewItem item in lsvProduct.Items)
            {
                if (item.SubItems[0].Text == txtProductID.Text)
                {
                    int currentQty = Convert.ToInt32(item.SubItems[3].Text);
                    int newQty = currentQty + Convert.ToInt32(txtQuantity.Text);
                    double unitPrice = Convert.ToDouble(item.SubItems[2].Text);

                    item.SubItems[3].Text = newQty.ToString();
                    item.SubItems[4].Text = (newQty * unitPrice).ToString("#,##0.00");

                    FinishAdding();
                    return;
                }
            }

            // ถ้าเป็นสินค้าใหม่ ให้เพิ่มแถว
            string[] row = { txtProductID.Text, txtProductName.Text, txtUnitPrice.Text, txtQuantity.Text, txtTotal.Text };
            lsvProduct.Items.Add(new ListViewItem(row));
            FinishAdding();
        }

        private void FinishAdding()
        {
            CalculateNetPrice();
            ClearProductData();
            btnSave.Enabled = true;
            txtProductID.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearProductData();
            txtProductID.Focus();
        }

        private void lsvProducts_DoubleClick(object sender, EventArgs e)
        {
            if (lsvProduct.SelectedItems.Count > 0)
            {
                lsvProduct.Items.Remove(lsvProduct.SelectedItems[0]);
                CalculateNetPrice();
                if (lsvProduct.Items.Count == 0) btnSave.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lsvProduct.Items.Clear();
            ClearProductData();
            lblNetPrice.Text = "0.00";
            btnSave.Enabled = false;
            txtProductID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lsvProduct.Items.Count == 0) return;

            if (MessageBox.Show("ยืนยันการบันทึกรายการขาย?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            using (SqlConnection saveConn = new SqlConnection(conn.ConnectionString))
            {
                saveConn.Open();
                SqlTransaction tr = saveConn.BeginTransaction();

                try
                {
                    // 1. บันทึกหัวบิล
                    SqlCommand cmdHead = new SqlCommand("InsertReceipts", saveConn, tr);
                    cmdHead.CommandType = CommandType.StoredProcedure;
                    cmdHead.Parameters.AddWithValue("@ReceiptDate", DateTime.Now);
                    cmdHead.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text);
                    cmdHead.Parameters.AddWithValue("@TotalCash", Convert.ToDouble(lblNetPrice.Text));
                    cmdHead.ExecuteNonQuery();

                    // 2. ดึงรหัส ReceiptID ล่าสุด
                    SqlCommand cmdID = new SqlCommand("SELECT TOP 1 ReceiptID FROM Receipts ORDER BY ReceiptID DESC", saveConn, tr);
                    int lastID = (int)cmdID.ExecuteScalar();

                    // 3. บันทึกรายการสินค้าลง Details
                    foreach (ListViewItem item in lsvProduct.Items)
                    {
                        SqlCommand cmdDet = new SqlCommand("InsertDetails", saveConn, tr);
                        cmdDet.CommandType = CommandType.StoredProcedure;
                        cmdDet.Parameters.AddWithValue("@ReceiptID", lastID);
                        cmdDet.Parameters.AddWithValue("@productID", item.SubItems[0].Text);
                        cmdDet.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(item.SubItems[2].Text));
                        cmdDet.Parameters.AddWithValue("@Quantity", Convert.ToInt32(item.SubItems[3].Text));
                        cmdDet.ExecuteNonQuery();
                    }

                    tr.Commit();
                    MessageBox.Show("บันทึกการขายสำเร็จ! รหัสบิล: " + lastID, "สำเร็จ");
                    btnCancel.PerformClick(); // เคลียร์หน้าจอเริ่มใหม่
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    MessageBox.Show("เกิดข้อผิดพลาดในการบันทึก: " + ex.Message);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lsvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}