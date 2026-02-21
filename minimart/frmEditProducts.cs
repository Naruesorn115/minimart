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
    public partial class frmEditProducts : Form
    {
        public frmEditProducts()
        {
            InitializeComponent();
        }
        // --- ส่วนของ Property ที่ขึ้นเส้นแดง ---
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string productID { get; set; } = "";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string productName { get; set; } = "";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double unitPrice { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int unitsInStock { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int categoryID { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string categoryName { get; set; } = "";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int discontinued { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string status { get; set; } = ""; // insert, update
                                                 // ------------------------------------
        SqlConnection? conn;    //ประกาศตัวแปรเชื่อมต่อ

        private void frmEditProducts_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart();

            // โหลดข้อมูลใส่ ComboBox
            string sql = "SELECT CategoryID, CategoryName FROM Categories";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboCategory.DataSource = dt;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryID";

            // ถ้าเป็นโหมดแก้ไข ให้แสดงค่าเดิม
            if (status == "update")
            {
                txtProductID.Text = productID;
                txtProductID.ReadOnly = true; // ห้ามแก้รหัส PK
                txtProductName.Text = productName;
                txtUnitPrice.Text = unitPrice.ToString();
                txtUnitsInStock.Text = unitsInStock.ToString();
                cboCategory.SelectedValue = categoryID;
            }
        }
        private void setCbo()
        {
            string sql = "Select CategoryID,CategoryName from Categories";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cboCategory.DataSource = ds.Tables[0];
            cboCategory.ValueMember = "CategoryID";      //กำหนดคอลัมน์ที่เป็นค่ารหัส
            cboCategory.DisplayMember = "CategoryName";   //กำหนดข้อมูลที่แสดงผล

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (status == "insert")
            {
                insertData();
            }
            else if (status == "update")
            {
                updateData();
            }
            this.Close(); //เมื่อเพิ่มหรือแก้ไขแล้วควรปิดหน้าต่างฟอร์มออกไป
        }

        private void updateData()
        {
            if (!checkInputData())
            {
                return; //หมายความว่า ถ้า checkInputData() มีค่าเป็น False จะจบโค้ดตรงนี้
            }
            string sql = "update products set productName = @productName, UnitPrice= @unitPrice,"
                            + " UnitsInStock =@UnitsInStock,CategoryID=@CategoryID,Discontinued =@Discontinued"
                            + " where productID = @productID";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@productID", txtProductID.Text.Trim());
            comm.Parameters.AddWithValue("@productName", txtProductName.Text.Trim());
            comm.Parameters.AddWithValue("@unitPrice", txtUnitPrice.Text);
            comm.Parameters.AddWithValue("@UnitsInStock", txtUnitsInStock.Text);

            comm.Parameters.AddWithValue("@CategoryID", cboCategory.SelectedValue); //เอาค่ารหัสที่ได้จากการเลือกใน comboBox
            if (radContinued.Checked)
            {
                comm.Parameters.AddWithValue("@Discontinued", 0);
            }
            else if (radDiscontinued.Checked)
            {
                comm.Parameters.AddWithValue("@Discontinued", 1);
            }
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show(msg, "เกิดข้อผิดพลาด");
            }
            conn.Close();
        }

        private bool checkInputData()
        {
            //ตรวจสอบรหัสสินค้าไม่ให้เป็นที่ว่าง
            if (txtProductID.Text.Trim() == "")
            {
                MessageBox.Show("รหัสสินค้าต้องไม่เป็นที่ว่าง", "เกิดข้อผิดพลาด");
                return false;
            }
            //ตรวจสอบชื่อสินค้า
            if (txtProductName.Text.Trim() == "")
            {
                MessageBox.Show("ชื่อสินค้าต้องไม่เป็นที่ว่าง", "เกิดข้อผิดพลาด");
                return false;
            }
            //ตรวจสอบราคากรอกเป็นตัวเลขหรือไม่
            double x = 0.00;
            if (!double.TryParse(txtUnitPrice.Text, out x))
            {
                MessageBox.Show("ราคาสินค้าเกิดข้อผิดพลาด", "เกิดข้อผิดพลาด");
                return false;
            }
            //ตรวจสอบจำนวนว่าเป็นจำนวนเต็มหรือไม่
            int y = 0;
            if (!int.TryParse(txtUnitsInStock.Text, out y))
            {
                MessageBox.Show("จำนวนสินค้าผิดพลาด", "เกิดข้อผิดพลาด");
                return false;
            }
            return true;
        }



        private void insertData()
        {
            if (!checkInputData())
            {
                return; //หมายความว่า ถ ้า checkInputData() มีค่าเป็น False จะจบโค้ดตรงนี้
            }
            string sql = "insert into Products "
                        + "values(@productID, @productName, @unitPrice, @UnitsInStock, @CategoryID, @Discontinued)";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@productID", txtProductID.Text.Trim());
            comm.Parameters.AddWithValue("@productName", txtProductName.Text.Trim());
            comm.Parameters.AddWithValue("@unitPrice", txtUnitPrice.Text);
            comm.Parameters.AddWithValue("@UnitsInStock", txtUnitsInStock.Text);
            comm.Parameters.AddWithValue("@CategoryID", cboCategory.SelectedValue); //เอาค่ารหัสที่ได้จากการเลือกใน comboBox
            if (radContinued.Checked)
            {
                comm.Parameters.AddWithValue("@Discontinued", 0);
            }
            else if (radDiscontinued.Checked)
            {
                comm.Parameters.AddWithValue("@Discontinued", 1);
            }
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show(msg, "เกิดข้อผิดพลาด");
            }
            conn.Close();
        }
    }
}
