using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using txtReadWrite.model;

namespace txtReadWrite
{
    public partial class Form1 : Form
    {
        Login lg = new Login();
        public Form1()
        {
            InitializeComponent();
            DisplayUserInfo();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        /// <summary>
        /// 登录
        /// </summary>
        private void Login()
        {
            var model = new UserLogin();
            if (!string.IsNullOrWhiteSpace(txtUname.Text))
            {
                model.userName = txtUname.Text;
            }
            if (!string.IsNullOrWhiteSpace(txtPwd.Text))
            {
                model.userPwd = txtPwd.Text;
            }
            if (ckxRem.Checked)
            {
                model.isRemPwd = true;
            }
            if (lg.userLogin(model))
            {
                MessageBox.Show("登录成功");
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }
        /// <summary>
        /// 获取用户登录信息
        /// </summary>
        private void DisplayUserInfo()
        {
            var result = lg.GetInfo();
            if(result!=null)
            {
                txtUname.Text = result.userName;
                txtPwd.Text = result.userPwd;
                ckxRem.Checked = result.isRemPwd;
            }
         
        }
    }
}
