using System;
using System.IO;
using System.Windows.Forms;

namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    public partial class registerPANEL : Form
    {
        private readonly string instructorsFile = "instructors.txt";
        public registerPANEL()
        {
            InitializeComponent();
        }
        private void registrationBUTTON_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text.Trim();
            string pass = passwordBox.Text.Trim();
            if (login.Length == 0 || pass.Length == 0)
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }
            if (!File.Exists(instructorsFile))
            {
                File.WriteAllLines(instructorsFile, new string[0]);
            }
            var lines = File.ReadAllLines(instructorsFile);
            foreach (var line in lines)
            {
                var parts = line.Split(':');
                if (parts.Length == 2 && parts[0] == login)
                {
                    MessageBox.Show("Такой логин уже существует!");
                    return;
                }
            }
            File.AppendAllText(instructorsFile, $"{login}:{pass}\n");
            MessageBox.Show("Регистрация успешна!");
            this.Close();
        }

        private void cancelBUTTON_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
