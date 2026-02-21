using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Minimart
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int EmployeeID { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        // ใช้ string.Empty เพื่อให้ค่าเริ่มต้นไม่เป็น null
        public string EmployeeName { get; set; } = string.Empty;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Position { get; set; } = string.Empty;

        SqlConnection? conn = null;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            // 1. ตรวจสอบเบื้องต้นว่ากรอกข้อมูลครบไหม
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("กรุณากรอกชื่อผู้ใช้และรหัสผ่าน", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (conn = connectDB.ConnectMinimart()) // ใช้ using เพื่อจัดการทรัพยากรอัตโนมัติ
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    string sql = "select EmployeeID, SaleName=title+firstname+space(2)+lastname, position"
                               + " from Employees"
                               + " where username = @usr AND password = @pwd";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@usr", username);
                        cmd.Parameters.AddWithValue("@pwd", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                EmployeeID = reader.GetInt32(0);
                                EmployeeName = reader.GetString(1);
                                Position = reader.GetString(2);

                                // ก่อนจะ OK ให้ปิดทุกอย่างให้เรียบร้อย
                                reader.Close();
                                conn.Close();

                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "เข้าสู่ระบบล้มเหลว",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อ: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
