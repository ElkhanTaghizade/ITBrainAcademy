using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp2
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void register_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string cpassword = textBox3.Text;
            if (username.Length >= 4 && password.Length > 6 && cpassword == password)
            {
                MessageBox.Show("Your account is created.");
            }
            else if (username.Length >= 4 && password.Length >= 6 && password != cpassword)
            {
                MessageBox.Show("Password is not same.");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        public void login_Click(object sender, EventArgs e)
        {
           
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == "elkhan" && password == "1234")
            {
               Form2 form=new Form2();
                form.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password.");
            }
        }
    }
}