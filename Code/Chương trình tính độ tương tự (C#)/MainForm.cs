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

namespace Similar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        List<string> filedata = new List<string>();
        List<string> filepath = new List<string>();
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData(@"E:\PythonTest\Sim_VN\Data");
        }

        public void LoadData(string path)
        {
            DirectoryInfo info = new DirectoryInfo(path);
            FileInfo[] files = info.GetFiles("*.txt");

            foreach(FileInfo file in files)
            {
                list_source.Items.Add(file.Name);
                StreamReader reader = file.OpenText();
                string rs = reader.ReadToEnd();
                filedata.Add(rs);
                filepath.Add(file.FullName);
            }
        }

        private void list_source_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = list_source.SelectedIndex;
            review_box.Text = filedata[index];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                string line, kq = "";

                while((line=reader.ReadLine())!=null)
                {
                    kq += line;
                }
                reader.Close();
                docname.Text = openFileDialog1.SafeFileName;
                ref_box.Text = kq;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(ref_box.Text!="")
            {
                 if (rdo_one.Checked)
                 {
                    if(list_source.SelectedItem == null)
                    {
                        MessageBox.Show("Hãy lựa chọn một văn bản nguồn","Thông báo");
                    }
                    else
                    {
                        string path_source = filepath[list_source.SelectedIndex];
                        string path_ref = openFileDialog1.FileName;
                        new Form1(path_ref, path_source,1).Show();
                    }
                 }
                 else if (rdo_all.Checked)
                 {
                        string path_ref = openFileDialog1.FileName;
                        new Form1(path_ref, filepath, 2).Show();
                 }
                 else
                 {
                     MessageBox.Show("Hãy lựa chọn kiểu tính", "Thông báo");
                 }
            }
            else
            {
                MessageBox.Show("Hãy lựa chọn văn bản tham chiếu","Thông báo");
            }
        }
    }
}
