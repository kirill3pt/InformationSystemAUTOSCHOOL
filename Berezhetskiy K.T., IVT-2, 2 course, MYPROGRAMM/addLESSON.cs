using System;
using ClosedXML.Excel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    public partial class addLESSON : Form
    {
        
        XLSX_FUNC_STUDENTS FunctionsXLSXforStudents = new XLSX_FUNC_STUDENTS();
        XLSX_FUNC_CARS FunctionXLSXforCars = new XLSX_FUNC_CARS();
        XLSX_FUNC_INSTRUCTORS FunctionXLSXforInstructors = new XLSX_FUNC_INSTRUCTORS();
        public string Date {  get; set; }
        public string Time { get; set; }
        public string studentFIO {  get; set; }
        public string car {  get; set; }
        public string instructor { get; set; }
        public addLESSON()
        {
            InitializeComponent();
            FunctionXLSXforCars.MakeCOMBOBOX(CarSELECT);
            FunctionsXLSXforStudents.MakeCOMBOBOX(StudentSELECT);
            FunctionXLSXforInstructors.MakeCOMBOBOX(InstructorSELECT);
        }

        private void addBUTTON_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StudentSELECT.Text))
            {
                MessageBox.Show("Поле 'ФИО' обязательно для заполнения!");
                return;
            }
            Date = SelectDATE.Text;
            Time = SelectTIME.Text;
            studentFIO = StudentSELECT.Text;
            car = CarSELECT.Text;
            instructor = InstructorSELECT.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
