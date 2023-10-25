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
            LoadDGVSinhVien();
            LoadCbxLop();
        }

        private void DGVLSv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = DGVLSv.CurrentRow.Index;
            txtMSSV.Text = DGVLSv.Rows[i].Cells[0].Value.ToString();
            txtName.Text = DGVLSv.Rows[i].Cells[1].Value.ToString();

            txtClass.Text = DGVLSv.Rows[i].Cells[3].Value.ToString();
            
        }

        void LoadDGVSinhVien()
        {
            try {
                string ma = "select * From SinhVien";
                var table = connection.GetDataTable(ma, "SinhVien");
                DGVLSv.DataSource = table;
            }
            catch(Exception ex) {
                MessageBox.Show("Lỗi");
            } 
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimSinhVien();
        }

        public void LoadCbxLop() 
        {
            try
            {
                string selection = "select * from Lop";
                var table = connection.GetDataTable(selection, "Lop");
                cbxLop.DataSource = table;

                cbxLop.DisplayMember = "Malop";
            }
            catch
            {
                MessageBox.Show("Không Load được dữ liệu");
            }

        }


        public void ThemSinhVien()
        {
            try
            {
               

                    if (string.IsNullOrEmpty(txtName.Text))
                    {
                        MessageBox.Show("Vui Lòng Nhập Tên Sinh Viên ");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(cbxLop.Text))
                        {
                            MessageBox.Show("Vui Lòng Chọn Lớp !", "Thông Báo");
                        }
                        else
                        {
                            Random rand = new Random();
                            string kytu = "SV";
                            string s = "";
                            int temp = 9;
                            string number;
                            int num = 9;
                            number = num.ToString();
                            List<int> list = new List<int>();
                            for (int i = 0; i <= 8; i++)
                            {
                                list.Add(i);
                                //list.Add(rand.Next(a));
                            }
                            //random
                            for (int i = 0; i <= 8; i++)
                            {
                                temp = rand.Next(list.Count);
                                s += list[temp];
                                list.RemoveAt(temp);

                            }
                            string MSSV = kytu + s;
                        LoadDGVSinhVien();
                            DialogResult dlr = MessageBox.Show("MSSV :" + MSSV + "\nTên Sinh Viên: " + txtName.Text + "\n Mã Lơp :" + cbxLop.Text +"","",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dlr == DialogResult.Yes)
                            {
                            string MuaVe = "insert into SinhVien values('"+ MSSV + "',N'"+txtName.Text+"','2002/08/13','"+ cbxLop.Text+ "')";
                                var table = connection.GetDataTable(MuaVe, "Ve");
                                DGVLSv.AllowUserToAddRows = true;
                                DGVLSv.DataSource = table;
                                LoadDGVSinhVien();
                            }
                            else
                            {

                            }
                        }
                    }
                
            }
            catch (Exception ex) 
            { 
            
            }

        }

        public void XoaSinhVien()
        {
            try
            {
                string HVe = "Delete from SinhVien where Masv like'%" + txtMSSV.Text + "%'";
                var table = connection.GetDataTable(HVe, "SinhVien");
                DGVLSv.DataSource = table;
                LoadDGVSinhVien();

            }
            catch (Exception ex)
            {

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemSinhVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaSinhVien();
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
                    string selection = "SELect * from SinhVien where Masv like '" + txtMSSV.Text + "'";
                    var table = connection.GetDataTable(selection, "SinhVien");
                    DGVLSv.DataSource = table;
                    DGVLSv.Columns[0].HeaderText = "Mã SV";
                    DGVLSv.Columns[1].HeaderText = "Họ Tên";
                    DGVLSv.Columns[2].HeaderText = "Ngày Sinh";
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
