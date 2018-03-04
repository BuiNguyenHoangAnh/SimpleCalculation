using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FirstNumber.Text.Trim();
            this.SecondNumber.Text.Trim();
            int x, y, z;
            x = Convert.ToInt32(this.FirstNumber.Text);
            y = Convert.ToInt32(this.SecondNumber.Text);
            z = x * y;
            this.Result.Text = Convert.ToString(z);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.FirstNumber.Clear();
            this.SecondNumber.Clear();
            this.Result.Clear();
            this.FirstNumber.Focus();
            this.SecondNumber.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.FirstNumber.Text.Trim();
            this.SecondNumber.Text.Trim();
            int x, y, z;
            x = Convert.ToInt32(this.FirstNumber.Text);
            y = Convert.ToInt32(this.SecondNumber.Text);
            z = x / y;
            this.Result.Text = Convert.ToString(z);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.FirstNumber.Text.Trim();
            this.SecondNumber.Text.Trim();
            int x, y, z;
            x = Convert.ToInt32(this.FirstNumber.Text);
            y = Convert.ToInt32(this.SecondNumber.Text);
            z = x + y;
            this.Result.Text = Convert.ToString(z);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.FirstNumber.Text.Trim();
            this.SecondNumber.Text.Trim();
            int x, y, z;
            x = Convert.ToInt32(this.FirstNumber.Text);
            y = Convert.ToInt32(this.SecondNumber.Text);
            z = x - y;
            this.Result.Text = Convert.ToString(z);
        }
    }
}
