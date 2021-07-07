using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections.Generic;
namespace Similar
{
    public partial class Form1 : Form
    {
        bool colored = true;
        string doc1 = "", doc2 = "";
        List<string> paths = new List<string>();
        int mark1 = 0,mark2 = 0;
        IDictionary<string, double> dict = new Dictionary<string, double>();
        string executepath = @"E:\PythonTest\Sim_VN";
        public Form1(string path1,string path2,int mark)
        {
            InitializeComponent();
            doc1 = path1;
            doc2 = path2;
            mark1 = mark;
        }
        public Form1(string path1, List<string> listpath,int mark)
        {
            InitializeComponent();
            doc1 = path1;
            paths = listpath;
            mark2 = mark;
        }
        public void ExecuteCommand(string Command)
        {
            ProcessStartInfo ProcessInfo;
            Process Process= new Process();

            ProcessInfo = new ProcessStartInfo("cmd.exe", "/c " + Command);
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.WindowStyle = ProcessWindowStyle.Hidden;
            ProcessInfo.UseShellExecute = true;
            ProcessInfo.WorkingDirectory = executepath;
            Process = Process.Start(ProcessInfo);
            Notice nt = new Notice();
            nt.Show();
            Process.WaitForExit();
            nt.Close();
        }
        public string ReadFile(string path,string mark)
        {
              StreamReader reader=new StreamReader(path);
              string line,kq="";
             while((line=reader.ReadLine())!=null)
             {
                 kq+=line+"\n";
             }
             string[] rs = kq.Split('.');
             string output = "";
             if (mark == "A")
             {
                 for(int i=0;i<rs.Length;i++)
                 {
                     output += "(A" + i + ")" + rs[i]+".";
                 }

             }
             else if (mark == "B")
             {
                 for (int i = 0; i < rs.Length; i++)
                 {
                     output += "(B" + i + ") " + rs[i] + ".";
                 }
             }
             else
             {
                 output = kq;
             }
             reader.Close();
             return output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (similar_rs.Text == "")
                {
                    if (mark1 == 1)
                    {
                        string command = string.Format(@"python3 do_tuong_tu_cau.py {0} {1}", doc1, doc2);
                        ExecuteCommand(command);
                        similar_rs.Clear();
                        similar_rs.Text = ReadFile(executepath+@"\ketqua.txt", "");
                        string phanloai = ReadFile(executepath+@"\phanloai.txt", "");
                        string[] pairs = phanloai.Split('\n');
                        foreach (string pair in pairs)
                        {
                            if (pair.Equals(""))
                            {
                                continue;
                            }
                            if (colored == true)
                            {
                                //doi mau
                                string[] chiso = pair.Split('|');
                                string vitri = chiso[0];
                                string cau1 = chiso[1];
                                string cau2 = chiso[2];
                                string sodo = chiso[3];
                                string[] temp = vitri.Split(',');
                                if (temp[0].Contains("A"))
                                {
                                    int index1 = document1.Text.IndexOf(chiso[1]);
                                    int length1 = chiso[1].Length;
                                    int index2 = document2.Text.IndexOf(chiso[2]);
                                    int length2 = chiso[2].Length;
                                    document1.Select(index1, length1);
                                    document1.SelectionBackColor = Color.Yellow;
                                    document2.Select(index2, length2);
                                    document2.SelectionBackColor = Color.Yellow;
                                }
                                else
                                {
                                    int index1 = document1.Text.IndexOf(chiso[2]);
                                    int length1 = chiso[2].Length;
                                    int index2 = document2.Text.IndexOf(chiso[1]);
                                    int length2 = chiso[1].Length;
                                    document1.Select(index1, length1);
                                    document1.SelectionBackColor = Color.Yellow;
                                    document2.Select(index2, length2);
                                    document2.SelectionBackColor = Color.Yellow;
                                }
                            }
                        }
                    }
                    else if(mark2 == 2)
                    {
                        
                        foreach(string path in paths)
                        {
                            string command = string.Format(@"python3 do_tuong_tu_cau.py {0} {1}", doc1, path);
                            ExecuteCommand(command);
                            string name = Path.GetFileName(path);
                            string similar = ReadFile(executepath+@"\ketqua.txt", "");
                            double number = Convert.ToDouble(similar.Remove(similar.Length - 2));
                            dict.Add(name, number);
                        }
                        double max_ori = dict.Values.Max();
                        double min = dict.Values.Min()-1;
                        double max = dict.Values.Max()+1;
       
                        string keymax = dict.FirstOrDefault(x => x.Value == max_ori).Key;
                        double nvl = (max_ori - min) / (max - min);
                        similar_rs.Text = Math.Round(nvl*100,3) + "%";
                        label_rs.Text = "văn bản tham chiếu giống nhất với văn bản " + keymax;
                        document2.Text = ReadFile(executepath+@"\Data\"+keymax, "");
                    }
                }
            
        }

        private void Reset()
        {
            document1.Clear();
            document2.Clear();
            similar_rs.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (mark1 == 1)
            {
              new Detail().Show();
            }
            else if(mark2 == 2)
            {
                new Detail2(dict).Show();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             if(mark1 == 1)
             {
                document1.Text = ReadFile(doc1, "A");
                document2.Text = ReadFile(doc2, "B");
             }
             else if(mark2 == 2)
             {
                 document1.Text = ReadFile(doc1, "");
                 //btnchitiet.Enabled = false;
             }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            
    }
}
