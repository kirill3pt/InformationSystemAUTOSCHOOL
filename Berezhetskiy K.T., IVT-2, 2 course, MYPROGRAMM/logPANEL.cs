using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    public partial class loginPanel : Form
    {
        private string RightLOGINforADM = "1234";
        private string RightPASSforADM = "1234";
        private string RightLOGINforINST = "0000";
        private string RightPASSforINST = "0000";
        public loginPanel()
        {
            InitializeComponent();
            passwordBox.UseSystemPasswordChar = true;
        }

        private void goToProgramm_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == RightPASSforADM && loginBox.Text == RightLOGINforADM)
            {
                if (UserRoleChoice.Text == "Администратор")
                {
                    ModuleADMIN moduleADMIN = new ModuleADMIN();
                    moduleADMIN.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин и/или пароль!");
            }
            if (passwordBox.Text == RightPASSforINST && loginBox.Text == RightLOGINforINST)
            {
               
            }
        }
    }
}
