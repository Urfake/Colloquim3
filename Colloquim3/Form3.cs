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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string email = email_input.Text;
            string password = password_input.Text;

            this.Hide();
            Form1 form = new Form1();

            using (ApplicationContext db = new ApplicationContext())
            {
                User user = new User { Email = email, Password = password };

                db.Users.Add(user);
                db.SaveChanges();
            }          
            form.Closed += (s, args) => this.Close();
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
