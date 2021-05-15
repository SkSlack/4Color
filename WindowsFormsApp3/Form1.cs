using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Former : Form
    {
        public Former()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Former.ActiveForm.BackColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Former.ActiveForm.BackColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Former.ActiveForm.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Former.ActiveForm.BackColor = Color.Yellow;
        }
    }
}
