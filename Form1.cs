using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yemek
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            control21.Hide();
            control31.Hide();
            control11.Show();
            control11.BringToFront();
        }

        private void control21_Load(object sender, EventArgs e)
        {

        }

        private void control11_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            control11.Hide();
            control31.Hide();
            control21.Show();
            control21.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
;
            control31.Hide();
            control21.Hide();
            control11.Show();
            control11.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            control11.Hide();
            control21.Hide();
            control31.Show();
            control31.BringToFront();
        }
    }
}
