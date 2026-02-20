using Microsoft.Data.SqlClient;
using Minimart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimart
{
    public partial class frmEditCategory : Form
    {
        public frmEditCategory()
        {
            InitializeComponent();
        }
        SqlConnection? conn;
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int CategoryID { get; set; }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string CategoryName { get; set; } = "";

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string Description { get; set; } = "";

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string Status { get; set; } = "";
        private void frmEditCategory_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart();
            //นำข้อมูลเริ่มต้นที่ส่งมาจากฟอร์มหลักมาแสดง
            txtCategoryID.Text = CategoryID.ToString();
            txtCategoryName.Text = CategoryName;
            txtDescription.Text = Description;

            txtCategoryID.Enabled = false;
            txtCategoryName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCategoryID.Text = CategoryID.ToString();
            txtCategoryName.Text = CategoryName;
            txtDescription.Text = Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Status == "Insert")
            {
                InsertData();
            }
            else if (Status == "Update")
            {
                UpdateData();
            }
        }

        private void UpdateData()
        {
            string sql = "Update Categories set CategoryName =@CategoryName,"
                       + " Description = @Description "
                       + " Where categoryID = @CategoryID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text.Trim());
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
            cmd.Parameters.AddWithValue("@CategoryID", Convert.ToInt32(txtCategoryID.Text.Trim()));
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("ปรับปรุงข้อมูลเรียบร้อยแล้ว");
            }
            else
            {
                MessageBox.Show("ไม่สามารถปรับปรุงข้อมูลได้");
            }
            this.Close();
        }

        private void InsertData()
        {
            string sql = "INSERT INTO Categories (CategoryName, Description) "
                       + "VALUES (@CategoryName, @Description)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text.Trim());
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้ว");
            }
            else
            {
                MessageBox.Show("ไม่สามารถเพิ่มข้อมูลได้");
            }
            this.Close();
        }
    }
}
