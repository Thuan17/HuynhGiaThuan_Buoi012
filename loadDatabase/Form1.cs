using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loadDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

        private bool isCollapsed;

        private bool isCollapsed2;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        void LoadDGVChuyenXe()
        {

            string ma = "select * from ChuyenXe";

            //var table = connection.GetDataTable(ma, "ChuyenXe");
            //DGVLSv.DataSource = table;



        }

        private void btnQLSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_QLSinhVien());
           
        }
    }
}
