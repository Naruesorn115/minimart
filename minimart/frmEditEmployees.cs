using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Data;

namespace Minimart
{
    public partial class frmEditEmployees : Form
    {
        // --- Properties สำหรับรับค่าจากหน้าหลัก ---
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int EmployeeID { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Title { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Firstname { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Lastname { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Position { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Username { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Password { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Status { get; set; }

        public frmEditEmployees()
        {
            InitializeComponent();
            // ผูก Event ปุ่มกด (ถ้าใน Designer ยังไม่ได้ผูกไว้)
            btnSave.Click += new EventHandler(btnSave_Click);
            btnClearForm.Click += new EventHandler(btnClearForm_Click);
        }

        private void frmEditEmployees_Load(object sender, EventArgs e)
        {
            // นำข้อมูลมาแสดงใน Control
            txtEmployeeID.Text = (Status == "INSERT") ? "AUTO ID" : EmployeeID.ToString();
            txtEmployeeID.ReadOnly = true; // รหัสพนักงานไม่ควรให้แก้เอง

            cboTitle.Text = Title;
            txtFirstName.Text = Firstname;
            txtLastName.Text = Lastname;
            cboPosition.Text = Position;
            txtUserName.Text = Username;
            txtPassword.Text = Password;
            txtConfirmPassword.Text = Password;

            if (Status == "INSERT")
            {
                this.Text = "เพิ่มพนักงานใหม่";
            }
            else
            {
                this.Text = "แก้ไขข้อมูลพนักงาน";
            }
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            // 1. ตรวจสอบรหัสผ่าน
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("ยืนยันรหัสผ่านไม่ตรงกัน!", "ข้อผิดพลาด");
                return;
            }

            // 2. ตรวจสอบข้อมูลจำเป็น
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อและ Username");
                return;
            }

            try
            {
                using (SqlConnection conn = connectDB.ConnectMinimart())
                {
                    conn.Open();
                    string sql = "";
                    if (Status == "INSERT")
                    {
                        sql = "INSERT INTO Employees (Title, FirstName, LastName, Position, Username, Password) " +
                              "VALUES (@t, @f, @l, @p, @u, @pass)";
                    }
                    else
                    {
                        sql = "UPDATE Employees SET Title=@t, FirstName=@f, LastName=@l, Position=@p, " +
                              "Username=@u, Password=@pass WHERE EmployeeID=@id";
                    }

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@t", cboTitle.Text);
                    cmd.Parameters.AddWithValue("@f", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@l", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@p", cboPosition.Text);
                    cmd.Parameters.AddWithValue("@u", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                    if (Status == "UPDATE") cmd.Parameters.AddWithValue("@id", EmployeeID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
        }

        private void btnClearForm_Click(object? sender, EventArgs e)
        {
            cboTitle.SelectedIndex = -1;
            txtFirstName.Clear();
            txtLastName.Clear();
            cboPosition.SelectedIndex = -1;
            txtUserName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}