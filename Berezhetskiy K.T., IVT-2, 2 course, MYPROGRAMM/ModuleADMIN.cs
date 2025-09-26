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
    public partial class ModuleADMIN : Form
    {
        public string otchetPath = "Отчёт.xlsx";
        public string instuctorsPath = "Инструкторы.xlsx";
        public string studentsPath = "Ученики.xlsx";
        public string carsPath = "Автомобили.xlsx";
        public string lessonsPath = "Занятия.xlsx";
        XLSX_FUNC_STUDENTS FunctionsXLSXforStudents = new XLSX_FUNC_STUDENTS();
        XLSX_FUNC_CARS FunctionXLSXforCars = new XLSX_FUNC_CARS();
        XLSX_FUNC_LESSONS FunctionXLSXforLessons = new XLSX_FUNC_LESSONS();
        XLSX_FUNC_INSTRUCTORS FunctionXLSXforInstructors = new XLSX_FUNC_INSTRUCTORS();
        private void ModuleADMIN_Load(object sender, EventArgs e)
        {
        }
        public ModuleADMIN()
        {
            InitializeComponent();
        }
        private void exitTSM_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void add_studentsTSM_Click(object sender, EventArgs e)
        {
            using (addSTUDENT addStudents = new addSTUDENT())
            {
                if (addStudents.ShowDialog() == DialogResult.OK)
                {
                    FunctionsXLSXforStudents.SAVE(addStudents.StudentFIO, addStudents.NumberPhone, addStudents.Group, addStudents.Paid);
                    MessageBox.Show("Ученик добавлен!");
                }
            }
        }
        private void studentsTSM_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FunctionsXLSXforStudents.SHOW();
        }
        private void add_carsTSM_Click(object sender, EventArgs e)
        {
            using (addCARS addCars = new addCARS())
            {
                if (addCars.ShowDialog() == DialogResult.OK)
                {
                    FunctionXLSXforCars.SAVE(addCars.markaCar, addCars.modelCar, addCars.numberCar, addCars.yearOfCar, addCars.AccessCar);
                    MessageBox.Show("Автомобиль добавлен!");
                }
            }
        }
        private void carsTSM_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FunctionXLSXforCars.SHOW();
        }
        private void scheduleTSM_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FunctionXLSXforLessons.SHOW();
            if (dataGridView1.Rows.Count > 0)
            {
                CancelBUTTON.Visible = true;
                DoneBUTTON.Visible = true;
            }
        }
        private void add_lessonTSM_Click(object sender, EventArgs e)
        {
            using (addLESSON addLesson = new addLESSON())
            {
                if (addLesson.ShowDialog() == DialogResult.OK)
                {
                    FunctionXLSXforLessons.SAVE(addLesson.Date, addLesson.Time, addLesson.studentFIO, addLesson.instructor, addLesson.car);
                    MessageBox.Show("Занятие создано!");
                }
                dataGridView1.DataSource = FunctionXLSXforLessons.SHOW();
            }
        }
        private void add_instructorTSM_Click(object sender, EventArgs e)
        {
            using (addINSTRUCTOR addINSTRUCTOR = new addINSTRUCTOR())
            {
                if (addINSTRUCTOR.ShowDialog() == DialogResult.OK)
                {
                    FunctionXLSXforInstructors.SAVE(addINSTRUCTOR.fioINSTRUCTOR, addINSTRUCTOR.numberINSTRUCTOR);
                    MessageBox.Show("Инструктор добавлен!");
                }
                dataGridView1.DataSource = FunctionXLSXforInstructors.SHOW();
            }
        }
        private void instructorsTSM_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FunctionXLSXforInstructors.SHOW();
        }
        private void make_statementTSM_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                using (var studentsBook = new XLWorkbook(studentsPath))
                {
                    studentsBook.Worksheet(1).CopyTo(workbook, "Ученики");
                }
                using (var carsBook = new XLWorkbook(carsPath))
                {
                    carsBook.Worksheet(1).CopyTo(workbook, "Автомобили");
                }
                using (var instructorsBook = new XLWorkbook(instuctorsPath))
                {
                    instructorsBook.Worksheet(1).CopyTo(workbook, "Инструкторы");
                }
                using (var lessonsBook = new XLWorkbook(lessonsPath))
                {
                    lessonsBook.Worksheet(1).CopyTo(workbook, "Занятия");
                }
                workbook.SaveAs(otchetPath);
                MessageBox.Show("Отчёт создан!");
            }
        }
        private void CancelBUTTON_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int lessonId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                FunctionXLSXforLessons.statusLESSON(lessonId, "отменено");
                dataGridView1.DataSource = FunctionXLSXforLessons.SHOW();
            }
        }
        private void DoneBUTTON_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int lessonId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                FunctionXLSXforLessons.statusLESSON(lessonId, "проведено");
                dataGridView1.DataSource = FunctionXLSXforLessons.SHOW();
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Статус")
            {
                string status = e.Value?.ToString();

                if (status == "запланировано")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                }
                else if (status == "отменено")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
                else if (status == "проведено")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }
            }
        }
    }
}