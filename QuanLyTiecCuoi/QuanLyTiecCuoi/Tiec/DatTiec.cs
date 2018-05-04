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

namespace QuanLyTiecCuoi.Tiec
{
    public partial class DatTiec : Form
    {
        ConnectDatabase condb = new ConnectDatabase();

        public DatTiec()
        {
            InitializeComponent();
        }

        private void btDatTiec_Click(object sender, EventArgs e)
        {
            condb.ExecuteNonQuery("");
        }
    }
}
