﻿using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoiUI.FormFeature.ConfigDatabase
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            SetFormStart();
        }
        private void txtUser_MouseEnter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username...")
            {
                txtUser.Text = string.Empty;
                txtUser.ForeColor = Color.Black;
            }
        }
        public void SetFormStart()
        {
            txtUser.Text = "Username...";
            txtUser.ForeColor = Color.LightGray;
            txtPassword.PasswordChar = '\0';
            txtPassword.Text = "Password...";
            txtPassword.ForeColor = Color.LightGray;
        }
        private void txtUser_MouseLeave(object sender, EventArgs e)
        {
            if (txtUser.Text == string.Empty)
            {
                txtUser.Text = "Username...";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password...")
            {
                txtPassword.Text = string.Empty;
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Password...";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
                txtUser.Text = string.Empty;
                txtUser.ForeColor = Color.Black;
            }
            else
                e.Handled = false;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
                txtPassword.Text = string.Empty;
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.Black;
            }
            else
                e.Handled = false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username..." || txtUser.Text == "")
            {
                lblNotification.Text = "Tên đăng nhập còn trống" + Environment.NewLine;
                return;
            }
            if (txtPassword.Text == "Password..." || txtPassword.Text == "")
            {
                lblNotification.Text = "Mật khẩu còn trống" + Environment.NewLine;
                return;
            }

            DTO_DangNhap dangnhap = new DTO_DangNhap(txtUser.Text,txtPassword.Text);

            if (BUS_DangNhap.KiemTraDangNhap(dangnhap))
            {
                lblNotification.Text = "Đăng nhập thành công !!";
                frmQuanLyTiecCuoi frmQLTC = new frmQuanLyTiecCuoi();
                frmQLTC.ShowDialog();
                frmQLTC.maNV = BUS_DangNhap.GetMaNV(dangnhap);
                this.Close();
            }
            else
            {
                lblNotification.Text = "Đăng nhập không thành công.";
            }
        }
    }

}
