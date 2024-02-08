using System;
using System.Net.Http;
using System.Windows.Forms;

namespace KnjiznjicaUI
{
    public partial class LoginForm : Form
    {
        static HttpClient client = new HttpClient();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var korisnik = new KorisnikVM();
            Uri uri = new Uri("http://localhost:55153/api/login");

            var response = client.PostAsync(uri, korisnik);

            if (response.Result.IsSuccessStatusCode)
            {
                Form main = new MainScreen();
                main.Show();
            }
            else
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Krivi upis!";
                string caption = "Krivo korisničko ime i/ili PIN!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }
    }
}
