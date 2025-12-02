using System;
using System.IO;
using System.Windows.Forms;

namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    public partial class loginPanel : Form
    {
        private readonly string instructorsFile = "instructors.txt";
        private string RightLOGINforADM = "Login";
        private string RightPASSWORDforADM = "Password";
        public loginPanel()
        {
            InitializeComponent();
            passwordBox.UseSystemPasswordChar = true;
            registrationBUTTON.Enabled = false;
        }

        private void goToProgramm_Click(object sender, EventArgs e)
        {
            if (UserRoleChoice.Text == "Администратор")
            {
                if (loginBox.Text == RightLOGINforADM && passwordBox.Text == RightPASSWORDforADM)
                {
                    ModuleADMIN moduleADMIN = new ModuleADMIN();
                    moduleADMIN.ShowDialog();
                    this.Close();
                    return;
                }

                MessageBox.Show("Неверный логин или пароль администратора!");
                return;
            }
            if (UserRoleChoice.Text == "Инструктор")
            {
                if (!File.Exists(instructorsFile))
                {
                    MessageBox.Show("Нет зарегистрированных инструкторов!");
                    return;
                }

                var lines = File.ReadAllLines(instructorsFile);

                foreach (var line in lines)
                {
                    var parts = line.Trim().Split(':');
                    if (parts.Length == 2)
                    {
                        string log = parts[0];
                        string pass = parts[1];

                        if (log == loginBox.Text && pass == passwordBox.Text)
                        {
                            ModuleINSTRUCTOR moduleINSTRUCTOR = new ModuleINSTRUCTOR();
                            moduleINSTRUCTOR.ShowDialog();
                            this.Close();
                            return;
                        }
                    }
                }

                MessageBox.Show("Неверный логин или пароль инструктора!");
                return;
            }
            MessageBox.Show("Выберите роль!");
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
