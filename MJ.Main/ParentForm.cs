using PlugIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MJ.PlugIn.Core;
using MJ.Common;
using MJ.DAL;
using MJ.DAL.Model;

namespace MJ.Main
{
    public partial class ParentForm : Form
    {
        Sunisoft.IrisSkin.SkinEngine s;

        public ParentForm()
        {
            InitializeComponent();
            s = new Sunisoft.IrisSkin.SkinEngine();
            //s.SkinFile = "Skins/default.ssk";

            Language.InstanceLanguage.LoadLanguage();

            ImageList image = new ImageList();
            image.ImageSize = new Size(1, 35);//设置每次点击view时以图片的形式
            ColumnHeader ch = new ColumnHeader();
            ch.TextAlign = HorizontalAlignment.Center;
            ch.Width = listView1.Width;
            ch.Text = "";

            listView1.Columns.Add(ch);//设置listview的列
            listView1.SmallImageList = image;//设置每个view的显示形式

            FileInfo[] files = new DirectoryInfo("Skins").GetFiles();

            foreach (var file in files)
            {
                ToolStripButton button = new ToolStripButton(Language.InstanceLanguage[file.Name.Split('.')[0]]) { Tag = file };
                button.Click += Button_Click;
                windowsToolStripMenuItem.DropDownItems.Add(button);
            }
            Logger.LogStart();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                s.SkinFile = ((sender as ToolStripButton).Tag as FileInfo).FullName;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            AppContext.Current = new AppContext("铭杰医疗", "V1.0", "admin", "administrator", this);
            AppContext.Current.AppCache["loginDatetime"] = DateTime.Now;
            AppContext.Current.AppCache["baseDir"] = AppDomain.CurrentDomain.BaseDirectory;
            AppContext.Current.AppFormTypes = new Dictionary<string, Type>();
            LoadComponents();
            LoadMenuNodes();

            ChildForm login = new ChildForm();
            login.Dock = this.Dock;
            DialogResult dr = login.ShowDialog();
            if (dr != DialogResult.OK)
            {
                this.Close();
            }
            login.Dispose();
        }

        private void LoadComponents()
        {
            string path = AppContext.Current.AppCache["baseDir"] + "PlugIns\\";
            Type targetFormType = typeof(Form);
            foreach (string filePath in Directory.GetFiles(path, "*.dll"))
            {
                var asy = Assembly.LoadFile(filePath);
                var configType = asy.GetTypes().FirstOrDefault(t => t.GetInterface("ICompoentConfig") != null);
                if (configType != null)
                {
                    ICompoent compoent = null;
                    var config = (ICompoentConfig)Activator.CreateInstance(configType);
                    config.CompoentRegister(AppContext.Current, out compoent);
                    if (compoent != null)
                    {
                        foreach (Type formType in compoent.FormTypes)
                        {
                            if (targetFormType.IsAssignableFrom(formType))
                            {
                                AppContext.Current.AppFormTypes.Add(formType.FullName, formType);
                            }
                        }
                    }
                }
            }
        }

        private void LoadMenuNodes() //实现情况应该是从数据库及用户权限来进行动态创建菜单项
        {
            this.listView1.Items.Clear();
            this.listView1.SmallImageList = imageList1;

            int i = 0;
            foreach (var formType in AppContext.Current.AppFormTypes)
            {
                var node = new ListViewItem(Language.InstanceLanguage[formType.Key.Split('.').Last()]) { Tag = formType.Value };
                node.ImageIndex = i;
                this.listView1.Items.Add(node);
                i++;
            }

            this.listView1.Items[0].Selected = true;
        }

        private void ShowChildForm(Type formType, string name)
        {
            var childForm = Application.OpenForms.Cast<Form>().SingleOrDefault(f => f.GetType() == formType);
            if (childForm == null)
            {
                childForm = AppContext.Current.CreatePlugInForm(formType);  //(Form)Activator.CreateInstance(formType);

                childForm.MdiParent = this;
                childForm.Parent = this.splitContainer1.Panel2;
                //childForm.Dock = DockStyle.Fill;
                childForm.Text = "  " + name;
                childForm.Show();
            }
            else
            {
                childForm.BringToFront();
                childForm.Activate();
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var lstItem = (sender as ListView).SelectedItems;
            if (lstItem.Count > 0)//当非父节点（即：实际的功能节点）
            {
                //ShowChildForm<ChildForm>();
                ShowChildForm(lstItem[0].Tag as Type, lstItem[0].Text);
            }
        }
    }
}
