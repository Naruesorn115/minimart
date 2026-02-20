using Microsoft.Data.SqlClient;
using Minimart;
using System.Data;
namespace Minimart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection? conn;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart(); //เรียกใช้ฟังก์ชันเชื่อมต่อฐานข้อมูล
            //showdata(); //เรียกใช้ฟังก์ชันแสดงข้อมูล
            string sql = "Select * from Products";
            showdata1(sql, dataGridView1);
        }

        private void showdata1(string sql, DataGridView dgv)
        {
            SqlCommand cmd = new SqlCommand(sql, conn); //สร้างคำสั่ง SQL
            SqlDataAdapter da = new SqlDataAdapter(cmd); //สร้างตัวดึงข้อมูล
            DataSet ds = new DataSet(); //สร้างตัวเก็บข้อมูล
            da.Fill(ds, "products"); //ดึงข้อมูลใส่ตัวเก็บข้อมูล
            dgv.DataSource = ds.Tables["products"]; //แสดงข้อมูลใน DataGridView
        }

        private void showdata()
        {
            string sql = "select productID,ProductName,UnitPrice,UnitsInStock"
                            + " ,c.CategoryID,CategoryName "
                            + " from products p join Categories c "
                            + " on p.CategoryID = c.CategoryID"; //คำสั่ง SQL สำหรับดึงข้อมูลจากตาราง Products
            SqlCommand cmd = new SqlCommand(sql, conn); //สร้างคำสั่ง SQL
            SqlDataAdapter da = new SqlDataAdapter(cmd); //สร้างตัวดึงข้อมูล
            DataSet ds = new DataSet(); //สร้างตัวเก็บข้อมูล
            da.Fill(ds, "products"); //ดึงข้อมูลใส่ตัวเก็บข้อมูล
            dgvProducts.DataSource = ds.Tables["products"]; //แสดงข้อมูลใน DataGridView
        }
    }
}
