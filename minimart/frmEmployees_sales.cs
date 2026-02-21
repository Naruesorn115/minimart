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
    public partial class frmEmployees_sales : Form
    {
        public frmEmployees_sales()
        {
            InitializeComponent();
        }
        SqlConnection? conn = null;
        int employeeID = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmEmployees_sales_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart();
            showEmployees();
            showReceipts(0);
        }

        private void showEmployees()
        {
            string sql = "Select e.EmployeeID,SaleName=title+firstname+space(2)+lastname,"
                        + " SaleRevenue=sum(Totalcash)"
                        + " from Receipts r left outer join Employees e on r.EmployeeID = e.EmployeeID"
                        + " group by e.EmployeeID,title+firstname+space(2)+lastname";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvEmployees.DataSource = ds.Tables[0];
        }

        private void showReceipts(int empID)
        {
            SqlCommand cmd;
            if (employeeID == 0)
            {
                string sql = "Select ReceiptID,"
                            + " FORMAT(ReceiptDate,'dd/MM/yyyy') As ReceiptDate,"
                            + " FORMAT(TotalCash,'N2') AS Totalcase"
                            + " from Receipts r join Employees e on r.EmployeeID = e.EmployeeID";
                cmd = new SqlCommand(sql, conn);
            }
            else
            {
                string sql = "Select ReceiptID,"
                             + " FORMAT(ReceiptDate,'dd/MM/yyyy') As ReceiptDate,"
                             + " FORMAT(TotalCash,'N2') AS Totalcase"
                             + " from Receipts r join Employees e on r.EmployeeID = e.EmployeeID"
                             + " where e.EmployeeID = @employeeID";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@employeeID", empID);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvReceipts.DataSource = ds.Tables[0];
        }

        private void dgvEmployees_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                employeeID = Convert.ToInt32(dgvEmployees.Rows[e.RowIndex].Cells[0].Value);
                showReceipts(employeeID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             showReceipts(0);
            
        }
    }
}
