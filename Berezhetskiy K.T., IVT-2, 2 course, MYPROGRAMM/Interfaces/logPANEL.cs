using System;
using System.IO;
using System.Windows.Forms;

namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    public partial class loginPanel : Form
    {
        private readonly IAUTH iauth;
        public loginPanel()
        {
            InitializeComponent();
            iauth = new AUTH();
            passwordBox.UseSystemPasswordChar = true;
            registrationBUTTON.Enabled = false;
        }

        private void goToProgramm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserRoleChoice.Text))
            {
                MessageBox.Show("Выберите роль!");
                return;
            }

            bool isAuthenticated = iauth.Authenticate(
                UserRoleChoice.Text,
                loginBox.Text,
                passwordBox.Text
            );

            if (!isAuthenticated)
            {
                MessageBox.Show("Неверный логин или пароль!");
                return;
            }

            if (UserRoleChoice.Text == "Администратор")
            {
                new ModuleADMIN().ShowDialog();
                Close();
                return;
            }

            if (UserRoleChoice.Text == "Инструктор")
            {
                new ModuleINSTRUCTOR().ShowDialog();
                Close();
                return;
            }
        }

        private void goToProgramm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                goToProgramm_Click(sender, e);
            }
        }

        private void registrationBUTTON_Click(object sender, EventArgs e)
        {
            registerPANEL registerForm = new registerPANEL();
            registerForm.ShowDialog();
        }

        private void UserRoleChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            registrationBUTTON.Enabled = (UserRoleChoice.Text == "Инструктор");
        }
    }
}
