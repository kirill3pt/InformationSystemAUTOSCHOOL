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
    public partial class addCARS : Form
    {
        public string markaCar { get; set; }
        public string modelCar { get; set; }
        public string numberCar { get; set; }
        public string yearOfCar { get; set; }
        public string AccessCar { get; set; }

        public addCARS()
        {
            InitializeComponent();
        }

        private void addBUTTON_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modelBOX.Text))
            {
                MessageBox.Show("Поле 'Модель' обязательно для заполнения!");
                return;
            }
            else if (string.IsNullOrWhiteSpace(numberBOX.Text))
            {
                MessageBox.Show("Поле 'Гос. номер' обязательно для заполнения!");
            }
            else if (string.IsNullOrWhiteSpace(markaBOX.Text))
            {
                MessageBox.Show("Поле 'Марка' обязательно для заполнения!");
            }
            else if (string.IsNullOrWhiteSpace(yearBOX.Text))
            {
                MessageBox.Show("Поле 'Год выпуска' обязательно для заполнения!");
            }
            markaCar = markaBOX.Text;
            numberCar = numberBOX.Text;
            modelCar = modelBOX.Text;
            yearOfCar = yearBOX.Text;
            AccessCar = AccessChoice.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
