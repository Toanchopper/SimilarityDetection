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
    public partial class Detail2 : Form
    {
        IDictionary<string, double> dict = new Dictionary<string, double>();
        public Detail2()
        {

        }
        public Detail2(IDictionary<string,double> dictionary)
        {
            InitializeComponent();
            dict = dictionary;
            ReadFile();
        }
        public void ReadFile()
        {
            double min = dict.Values.Min() - 1;
            double max = dict.Values.Max() + 1;
            List<KeyValuePair<string, double>> myList = dict.ToList();
            myList.Sort(
                delegate(KeyValuePair<string, double> pair1,
                KeyValuePair<string, double> pair2)
                {
                    return pair1.Value.CompareTo(pair2.Value);
                }
                );
            foreach(KeyValuePair<string,double> item in myList)
            {
                double vl = item.Value;
                double newval = (vl - min) / (max - min);
                string[] val = { item.Key, Math.Round(newval*100,3) + "%" };
                ListViewItem lvitem = new ListViewItem(val);
                listView2.Items.Add(lvitem);
            }

        }
    }
}
