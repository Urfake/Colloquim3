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
    public partial class Form2 : Form
    {
        public Tasks tasks = new Tasks();


        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string table = "Sofas";
            string label_value = "Диваны";
            this.Hide();
            Form4 form = new Form4(label_value, table);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string table = "Beds";
            string label_value = "Кровати";
            this.Hide();
            Form4 form = new Form4(label_value, table);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string table = "Chairs";
            string label_value = "Стулья";
            this.Hide();
            Form4 form = new Form4(label_value, table);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string table = "Tables";
            string label_value = "Столы";
            this.Hide();
            Form4 form = new Form4(label_value, table);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
