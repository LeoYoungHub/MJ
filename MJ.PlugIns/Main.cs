using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MJ.DAL.EF;
using MJ.DAL;
using MJ.DAL.Model;

namespace MJ.PlugIns
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PermissionDAL.Instance.SavePermission(new Permission()
            {
                Level = 0,
                Password = "admin",
                UserName = "admin"
            });
        }
    }
}
