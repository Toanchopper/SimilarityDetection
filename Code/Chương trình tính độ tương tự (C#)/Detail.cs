using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Similar
{
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
            ReadFile();
        }
        public void ReadFile()
        {
            var fileLines = File.ReadAllLines(@"E:\PythonTest\Sim_VN\phanloai.txt");
            
            for (int i = 0; i < fileLines.Length; i++)
            {
                string[] rs = fileLines[i].Split('|');
                double s= Convert.ToDouble(rs[3]);
                double s1 = Math.Round(s, 3);
                listView2.Items.Add(
                new ListViewItem(new[]
                {
                    rs[0],
                    rs[1],
                    rs[2],
                    s1.ToString()
                }));
            }

            // Resize the columns
            /*for (int i = 0; i < listView2.Columns.Count; i++)
            {
                listView2.Columns[i].Width = -2;
            }    */
        }
    }
}
