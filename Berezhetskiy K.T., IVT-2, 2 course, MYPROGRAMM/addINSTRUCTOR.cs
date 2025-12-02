using System;

using System.Windows.Forms;

namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    public partial class addINSTRUCTOR : Form
    {
        public string fioINSTRUCTOR {  get; set; }
        public string numberINSTRUCTOR {  get; set; }

        public addINSTRUCTOR()
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
            if (string.IsNullOrWhiteSpace(numberBOX.Text))
            {
                MessageBox.Show("Поле 'Телефон' обязательно для заполнения!");
            }
            fioINSTRUCTOR = fioBOX.Text;
            numberINSTRUCTOR = numberBOX.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
