using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MJ.DAL;
using MJ.DAL.Model;

namespace MJ.Main
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int x = (int)(0.5 * (this.Width - panel1.Width));
            int y = (int)(0.5 * (this.Height - panel1.Height)) - 100;
            panel1.Location = new System.Drawing.Point(x, y);
        }

        private void ChildForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btnLogin_Click(null, null);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<Permission> permissions = PermissionDAL.Instance.GetPermissions();

            if (permissions.Count == 0)
            {
                PermissionDAL.Instance.SavePermission(new Permission()
                {
                    Level = 0,
                    Password = "admin",
                    UserName = "admin"
                });

                permissions = PermissionDAL.Instance.GetPermissions();
            }

            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            if (permissions.Exists((obj) => { return obj.UserName.Equals(userName) && obj.Password.Equals(password); }))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lblInfo.Text = "用户名或者密码错误！";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
