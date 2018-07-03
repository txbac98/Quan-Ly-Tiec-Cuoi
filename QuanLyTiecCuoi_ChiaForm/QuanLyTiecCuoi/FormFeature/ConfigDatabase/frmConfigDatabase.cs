using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoiUI.FormFeature.ConfigDatabase
{
    public partial class frmConfigDatabase : Form
    {
        public frmConfigDatabase()
        {
            InitializeComponent();
        }

        private void btnConfigDatabase_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("DataSource.txt"))
            {
                string data = @"Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDatabase.Text + ";Integrated Security=True";
                sw.WriteLine(data);
                MessageBox.Show("Thay đổi cơ sở dữ liệu thành công. Vui lòng khởi động lại ứng dụng.");
                this.Close();
            }

            //string data = @"Data Source="+txtServer.Text+";Initial Catalog="+txtDatabase.Text+";Integrated Security=True";
            //Debug.WriteLine(data);
        }
    }
}
