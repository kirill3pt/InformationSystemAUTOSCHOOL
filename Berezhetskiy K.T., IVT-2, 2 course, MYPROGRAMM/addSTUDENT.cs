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
    public partial class addSTUDENT : Form
    {
        public string StudentFIO { get; set; }
        public string NumberPhone { get; set; }
        public string Group {  get; set; }
        public string Paid { get; set; }

        public addSTUDENT()
        {
            InitializeComponent();
        }

        private void addBUTTON_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fioBOX.Text))
            {
                MessageBox.Show("Поле 'ФИО' обязательно для заполнения!");
                return;
            }
            StudentFIO = fioBOX.Text;
            NumberPhone = numberBOX.Text;
            Group = groupBOX.Text;
            Paid = paidOrNot.Checked ? "Оплачено" : "Не оплачено";

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
