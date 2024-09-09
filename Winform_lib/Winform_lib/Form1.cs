using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lib_phepnhan;

namespace Winform_lib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b;
            String so1 = tb_nhapso1.Text;
            String so2 = tb_nhapso2.Text;
            if (!float.TryParse(so1, out a))
            {
                MessageBox.Show("Giá trị của a không hợp lệ.");
                return;
            }
            if (!float.TryParse(so2, out b))
            {
                MessageBox.Show("Giá trị của b không hợp lệ.");
                return;
            }
            float kq = phepnhan.Phepnhan(a,b);
            String kq2 = kq.ToString();
            kq3.Text = "Gia tri cua phep nhan la: "+kq2;
        }
    }
}
