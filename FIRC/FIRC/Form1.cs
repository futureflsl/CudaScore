using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIRC
{
    public partial class Form1 : Form
    {
        private CudaManager cm = new CudaManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cm.LoadCudaData();
            var source = new AutoCompleteStringCollection();
            source.AddRange(cm.CudaDeviceNameList);
            textBox1.AutoCompleteCustomSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            if(cm.dicCudaName2Score.ContainsKey(textBox1.Text))
            {
                textBox2.Text =string.Format("compute_{0},sm_{0}",cm.dicCudaName2Score[textBox1.Text].Replace(".",""));
            }
        }
    }
}
