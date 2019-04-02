using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvilDICOM.Core;
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
        Dictionary<string, string> keyToGender = new Dictionary<string, string>()
        {
            { "m","男性"},
            { "f","女性"},
            {"o","其他" }
        };

        private string showGender(string genderCode)
        {
            if (keyToGender.ContainsKey(genderCode.ToLower()))
            {
                return keyToGender[genderCode.ToLower()];
            }

            return "null";
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPicker = new OpenFileDialog();
            openPicker.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openPicker.Filter = "dcm|*.dcm";
            openPicker.FilterIndex = 1;
            if (openPicker.ShowDialog() == DialogResult.OK)
            {
                lblDcmPath.Text = openPicker.FileName;
                var dcm = await DICOMObject.ReadAsync(openPicker.FileName);

                var dcmName = dcm.FindFirst("00100010");
                lblName.Text = dcmName == null ? "null" : dcmName.DData.ToString();

                var dcmID = dcm.FindFirst("00100020");
                lblID.Text = dcmID == null ? "null" : dcmID.DData.ToString();

                var dcmAge = dcm.FindFirst("00101010");
                lblAge.Text = dcmAge == null ? "null" : dcmAge.DData.ToString();

                var dcmGender = dcm.FindFirst("00100040");
                lblGender.Text = dcmGender == null ? "null" : showGender(dcmGender.DData.ToString());
            }
        }
    }
}
