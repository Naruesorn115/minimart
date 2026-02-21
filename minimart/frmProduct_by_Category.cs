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
    public partial class frmProduct_by_Category : Form
    {
        public frmProduct_by_Category()
        {
            InitializeComponent();
        }
        SqlConnection? conn = null;
        int categoryID = 0;
        private void frmProduct_by_Category_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart();
            showCategory();
            showProducts(0);
        }
        private void showCategory()
        {
            string sql = "select categoryID,CategoryName from Categories";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvCategory.DataSource = ds.Tables[0];
        }

        private void showProducts(int cateID)
        {
            SqlCommand cmd;
            if (categoryID == 0)
            {
                string sql = "Select ProductID,ProductName,UnitPrice,UnitsInStock"
                          + " from Products";
                cmd = new SqlCommand(sql, conn);
            }
            else
            {
                string sql = "Select ProductID,ProductName,UnitPrice,UnitsInStock"
                            + " from Products"
                            + " where CategoryID = @categoryID";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@categoryID", cateID);


            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvProducts.DataSource = ds.Tables[0];
        }

        private void dgvCategory_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            { 
                categoryID = Convert.ToInt32(dgvCategory.Rows[e.RowIndex].Cells[0].Value);
                showProducts(categoryID);
            }
        }
    }
}
