using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MJ.PlugIn.Core;

namespace MJ.PlugIns
{
    public partial class Treat : Form, IPlugin
    {
        public Treat()
        {
            InitializeComponent();
        }

        public string PluginName
        {
            get { return "治疗运行"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CompoentConfig.AppContext.AppFormContainer.FormClosing += AppFormContainer_FormClosing;
        }

        void AppFormContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CompoentConfig.AppContext.AppFormContainer.FormClosing -= AppFormContainer_FormClosing;
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //SolidBrush _Brush = new SolidBrush(Color.Black);//单色画刷
            //RectangleF _TabTextArea = (RectangleF)tabControl1.GetTabRect(e.Index);//绘制区域
            //StringFormat _sf = new StringFormat();//封装文本布局格式信息
            //_sf.LineAlignment = StringAlignment.Center;
            //_sf.Alignment = StringAlignment.Center;
            //e.Graphics.DrawString(tabControl1.Controls[e.Index].Text, SystemInformation.MenuFont, _Brush, _TabTextArea, _sf);

            Font fntTab;
            Brush bshBack;
            Brush bshFore;
            if (e.Index != this.tabControl1.SelectedIndex)    //当前Tab页的样式 
            {
                fntTab = e.Font;
                bshBack = new SolidBrush(Color.AliceBlue); //new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, SystemColors.ActiveCaption, SystemColors.Control, System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal);
                bshFore = Brushes.Black;
            }
            else    //其余Tab页的样式 
            {
                fntTab = new Font(e.Font, FontStyle.Bold);
                bshBack = new SolidBrush(Color.CornflowerBlue);
                bshFore = new SolidBrush(Color.Blue);
            }
            //画样式 
            string tabName = this.tabControl1.TabPages[e.Index].Text;
            StringFormat sftTab = new StringFormat();
            e.Graphics.FillRectangle(bshBack, e.Bounds);
            sftTab.LineAlignment = StringAlignment.Center;
            sftTab.Alignment = StringAlignment.Center;
            Rectangle recTab = e.Bounds;
            recTab = new Rectangle(recTab.X, recTab.Y + 4, recTab.Width, recTab.Height - 4);
            e.Graphics.DrawString(tabName, fntTab, bshFore, recTab, sftTab);
        }
    }
}
