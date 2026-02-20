using Microsoft.Data.SqlClient;
using Minimart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimart
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        SqlConnection? conn;
        //ประกาศตัวแปรเพื่อเก็บข้อมูลสินค้าที่เลือกทำงาน
        string productID = string.Empty;
        string productName = string.Empty;
        double unitPrice = 0;
        int unitsInStock = 0;
        int categoryID = 0;
        string categoryName = string.Empty;
        int discontinued = 0;

        private void frmProducts_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart(); //เรียกใช้ฟังก์ชันเชื่อมต่อฐานข้อมูล
            string sql = "select productID,ProductName,UnitPrice,UnitsInStock"
                             + " ,c.CategoryID,CategoryName,discontinued "
                             + " from products p join Categories c "
                             + " on p.CategoryID = c.CategoryID"; //คำสั่ง SQL สำหรับดึงข้อมูลจากตาราง Products
            showdata(sql, dgvProducts);

        }

        private void showdata(string sql, DataGridView dgv)
        {
            SqlCommand cmd = new SqlCommand(sql, conn); //สร้างคำสั่ง SQL
            SqlDataAdapter da = new SqlDataAdapter(cmd); //สร้างตัวดึงข้อมูล
            DataSet ds = new DataSet(); //สร้างตัวเก็บข้อมูล
            da.Fill(ds); //ดึงข้อมูลใส่ตัวเก็บข้อมูล
            dgv.DataSource = ds.Tables[0]; //แสดงข้อมูลใน DataGridView
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchProduct(txtSearch.Text);
        }

        private void searchProduct(string text)
        {
            string sql = "Select productID,productName,UnitPrice,UnitsInStock,"
                + " p.CategoryID, CategoryName,Discontinued"
                + " from products p inner join Categories c on p.CategoryID = c.CategoryID"
                + " where productName  like '%'+@str+'%'  "
                + " or CategoryName like '%'+@str+'%'";
            SqlCommand cmd = new SqlCommand(sql, conn); //สร้างคำสั่ง SQL
            cmd.Parameters.AddWithValue("@str", text);
            SqlDataAdapter da = new SqlDataAdapter(cmd); //สร้างตัวดึงข้อมูล
            DataSet ds = new DataSet(); //สร้างตัวเก็บข้อมูล
            da.Fill(ds); //ดึงข้อมูลใส่ตัวเก็บข้อมูล
            dgvProducts.DataSource = ds.Tables[0]; //แสดงข้อมูลใน DataGridView
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEditProducts f = new frmEditProducts();
            f.status = "insert";
            f.ShowDialog();

            //โหลดข้อมูลใหม่หลังจากเพิ่มข้อมูลส มิฉะนั้นข้อมูลตัวใหม่จะไม่แสดง
            string sql = "select productID,ProductName,UnitPrice,UnitsInStock"
                             + " ,c.CategoryID,CategoryName,discontinued"
                             + " from products p join Categories c "
                             + " on p.CategoryID = c.CategoryID"; //คำสั่ง SQL สำหรับดึงข้อมูลจากตาราง Products
            showdata(sql, dgvProducts);
        }

        private void dgvProducts_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            productID = dgvProducts.CurrentRow.Cells[0].Value.ToString();
            productName = dgvProducts.CurrentRow.Cells[1].Value.ToString();
            unitPrice = Convert.ToDouble(dgvProducts.CurrentRow.Cells[2].Value);
            unitsInStock = Convert.ToInt16(dgvProducts.CurrentRow.Cells[3].Value);
            categoryID = Convert.ToInt16(dgvProducts.CurrentRow.Cells[4].Value);
            categoryName = dgvProducts.CurrentRow.Cells[5].Value.ToString();
            discontinued = Convert.ToInt16(dgvProducts.CurrentRow.Cells[6].Value);

        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            productID = dgvProducts.CurrentRow.Cells[0].Value.ToString();
            productName = dgvProducts.CurrentRow.Cells[1].Value.ToString();
            unitPrice = Convert.ToDouble(dgvProducts.CurrentRow.Cells[2].Value);
            unitsInStock = Convert.ToInt16(dgvProducts.CurrentRow.Cells[3].Value);
            categoryID = Convert.ToInt16(dgvProducts.CurrentRow.Cells[4].Value);
            categoryName = dgvProducts.CurrentRow.Cells[5].Value.ToString();
            discontinued = Convert.ToInt16(dgvProducts.CurrentRow.Cells[6].Value);

            frmEditProducts f = new frmEditProducts();
            f.productID = productID;
            f.productName = productName;
            f.unitPrice = unitPrice;
            f.unitsInStock = unitsInStock;
            f.categoryID = categoryID;
            f.categoryName = categoryName;
            f.discontinued = discontinued;
            f.status = "update";
            f.ShowDialog();

            string sql = "Select productID, productName, UnitPrice, UnitsInStock, "
                        + " p.CategoryID, CategoryName, Discontinued"
                        + " from products p inner join Categories c on p.CategoryID = c.CategoryID";
            showdata(sql, dgvProducts);

        }
    }
}
