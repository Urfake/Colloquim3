using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colloquim3
{
    public partial class Form4 : Form
    {
        public Tasks tasks = new Tasks();
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(string label, string table)
        {
            InitializeComponent();
            label1.Text = label;
            dgv1.DataSource = tasks.getTable(table);

        }
        public void Form4_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
