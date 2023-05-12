namespace Colloquim3
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
            string email = email_input.Text;
            string password = password_input.Text;

            ApplicationContext db = new ApplicationContext();

            var users = db.Users.ToList();
            User user = null;
            foreach (User u in users)
            {
                if (u.Email == email && u.Password == password)
                {
                    user = u;
                }
            }
            if (user != null)
            {
                this.Hide();
                Form2 newForm = new Form2();
                newForm.Closed += (s, args) => this.Close();
                newForm.Show();
            }
            else
            {
                MessageBox.Show(
                "Неправильный логин или пароль",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 registration = new Form3();
            registration.Show();
        }
    }
}