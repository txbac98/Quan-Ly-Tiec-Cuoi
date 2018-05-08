using QuanLyTiecCuoi.KetNoiCSDL;
using QuanLyTiecCuoi.Tiec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoi
{
    
    public partial class FormMain : Form
    {

        ConnectDatabase condb = new ConnectDatabase();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            condb.connect();
            
       
        }

        
         //Tiec 

        DatTiec datTiec = new DatTiec();
        TimTiec timTiec = new TimTiec();
       
        
        private void btThemTiec_Click(object sender, EventArgs e)
        {
            datTiec.Show();
            datTiec = new DatTiec();
        }

        private void btTimTiec_Click(object sender, EventArgs e)
        {

            timTiec.Show();
            timTiec = new TimTiec();
        }

        private void tpTiec_Click(object sender, EventArgs e)
        {
            //Show data len dataGridView
            
            DataView dv = new DataView(condb.getDataTable("select* from HOPDONGDATTIEC"));

            dgvTiec.DataSource = dv;

            dgvTiec.AutoResizeColumns();
        }

        private void btDanhSachTiec_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(condb.getDataTable("select* from HOPDONGDATTIEC"));

            dgvTiec.DataSource = dv;

            dgvTiec.AutoResizeColumns();
        }



        //Dich vu
        private void btDanhSachDichVu_Click(object sender, EventArgs e)
        {

        }

        private void tpThemDichVu_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void trvDichVu_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btThucDon_Click_1(object sender, EventArgs e)
        {
            tcMonAn.Visible = true;
        }
    }
}
