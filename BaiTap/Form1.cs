﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtMatKhau.Text;
            if(userName == "admin" && passWord == "admin")
            {
                MessageBox.Show("Successful");
            }
        }
    }
}
