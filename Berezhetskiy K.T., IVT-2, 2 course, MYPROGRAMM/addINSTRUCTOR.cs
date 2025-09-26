using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    public partial class addINSTRUCTOR : Form
    {
        XLSX_FUNC_STUDENTS FunctionsXLSXforStudents = new XLSX_FUNC_STUDENTS();
        XLSX_FUNC_CARS FunctionXLSXforCars = new XLSX_FUNC_CARS();
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
