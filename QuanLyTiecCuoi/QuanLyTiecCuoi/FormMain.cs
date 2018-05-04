using QuanLyTiecCuoi.KetNoiCSDL;
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
            
            showData("select * from NHANVIEN");
       
        }

        //Show data len dataGridView
        public void showData(string sql)
        {
            DataView dv = new DataView(condb.getDataTable(sql));

            dataGridView.DataSource = dv;

            dataGridView.AutoResizeColumns();

        }
    }
}
