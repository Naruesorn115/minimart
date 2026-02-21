using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Minimart
{
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart(); // ใช้ class เชื่อมต่อตัวเดียวกับที่คุณใช้
            showEmployees(""); // โหลดข้อมูลทั้งหมดครั้งแรก
        }

        // ฟังก์ชันแสดงข้อมูลและค้นหา
        private void showEmployees(string keyword)
        {
            string sql = "SELECT EmployeeID, Title, FirstName, LastName, Position FROM Employees";

            // ถ้ามีการพิมพ์ค้นหา ให้เพิ่มเงื่อนไข WHERE
            if (!string.IsNullOrEmpty(keyword))
            {
                sql += " WHERE FirstName LIKE @keyword OR LastName LIKE @keyword OR EmployeeID LIKE @keyword";
            }

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEmployees.DataSource = dt;
        }

        // Event เมื่อพิมพ์ในช่อง Textbox (ค้นหา Real-time)
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            showEmployees(txtSearch.Text);
        }

        // Event ปุ่มลบ
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null) return;

            // ดึง ID จาก Column แรกของแถวที่เลือก
            string empID = dgvEmployees.CurrentRow.Cells[0].Value.ToString();
            string empName = dgvEmployees.CurrentRow.Cells[2].Value.ToString();

            DialogResult result = MessageBox.Show($"คุณต้องการลบคุณ {empName} ใช่หรือไม่?",
                "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string sql = "DELETE FROM Employees WHERE EmployeeID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", empID);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ลบข้อมูลเรียบร้อย");
                    showEmployees(""); // Refresh ตาราง
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
        }
        // เพิ่มอันนี้เข้าไปเพื่อให้ Error หาย
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // โค้ดสำหรับเปิดหน้าฟอร์มเพิ่มพนักงาน (ตัวอย่าง)
            // frmEmployeeAdd f = new frmEmployeeAdd();
            // f.ShowDialog();
            // showEmployees(""); // เมื่อปิดหน้าเพิ่ม ให้ Refresh ตาราง
            MessageBox.Show("ส่วนนี้ไว้สำหรับใส่โค้ดเปิดหน้าเพิ่มข้อมูลพนักงานครับ");
        }
    }
}