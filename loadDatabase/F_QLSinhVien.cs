using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace loadDatabase
{
    public partial class F_QLSinhVien : Form
    {
        DB connection;
        DataColumn[] primaryKey;
        SqlDataAdapter adapter1, adapter2;


        //SqlConnection con;
        //SqlCommand cmd;
        //string str = " Data Source=LAPTOP-ALA9RHJO\\SQLEXPRESS; Initial Catalog=QLSinhVien ;Integrated Security=True ";
        //SqlDataAdapter adapter = new SqlDataAdapter();
        //DataTable table = new DataTable();
        public F_QLSinhVien()
        {
            InitializeComponent();
           

            connection = new DB();
            primaryKey = new DataColumn[1];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void F_QLSinhVien_Load(object sender, EventArgs e)
        {
            //LoadDGVChuyenXe();
        }

        private void DGVLSv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = DGVLSv.CurrentRow.Index;
            txtName.Text = DGVLSv.Rows[i].Cells[0].Value.ToString();

            txtClass.Text = DGVLSv.Rows[i].Cells[1].Value.ToString();
            
        }

        void LoadDGVChuyenXe()
        {
            try {
                string ma = "select * From SinhVien";
                var table = connection.GetDataTable(ma, "SinhVien");
                DGVLSv.DataSource = table;
            }
            catch(Exception ex) {
                MessageBox.Show("ooix");
            } 
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimSinhVien();
        }

        void TimSinhVien()
        {
            //cmd = con.CreateCommand();
            //cmd.CommandText = "SELect * from SinhVien where Masv like N'" + txtMSSV.Text + "'";
            //adapter.SelectCommand = cmd;
            //table.Clear();
            //adapter.Fill(table);
            //DGVLSv.DataSource = table;



            void loadDGView()
            {

                try
                {
                    string selection = "SELect * from SinhVien where Masv like N'" + txtMSSV.Text + "'";
                    var table = connection.GetDataTable(selection, "Ve");
                    DGVLSv.DataSource = table;
                    DGVLSv.Columns[0].HeaderText = "Mã SV";
                    DGVLSv.Columns[1].HeaderText = "Ho Tên";
                    DGVLSv.Columns[2].HeaderText = "Ngày SInh";
                    DGVLSv.Columns[3].HeaderText = "Ma Lop";
                   

                }
                catch
                {
                    MessageBox.Show("Không Load được dữ liệu");
                }
            }


        }



    }
}
