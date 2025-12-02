using ClosedXML.Excel;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    public partial class ModuleADMIN : Form
    {
        private string otchetPath_ = "Отчёт.xlsx";
        private string instuctorsPath_ = "Инструкторы.xlsx";
        private string studentsPath_ = "Ученики.xlsx";
        private string carsPath_ = "Автомобили.xlsx";
        private string lessonsPath_ = "Занятия.xlsx";
        private string currentTable_ = "";
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
        private void studentsTSM_Click(object sender, EventArgs e)
        {
            selectedLISTlabel.Text = "Текущий лист: ученики";
            dataGridView1.DataSource = FunctionsXLSXforStudents.SHOW();
            currentTable_ = "students";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            CancelBUTTON.Visible = false;
            DoneBUTTON.Visible = false;
        }
        private void carsTSM_Click(object sender, EventArgs e)
        {
            selectedLISTlabel.Text = "Текущий лист: автомобили";
            dataGridView1.DataSource = FunctionXLSXforCars.SHOW();
            currentTable_ = "cars";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            CancelBUTTON.Visible = false;
            DoneBUTTON.Visible = false;
        }
        private void scheduleTSM_Click(object sender, EventArgs e)
        {
            selectedLISTlabel.Text = "Текущий лист: расписание";
            dataGridView1.DataSource = FunctionXLSXforLessons.SHOW();
            currentTable_ = "lessons";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ScrollBars = ScrollBars.Both;
            CancelBUTTON.Visible = dataGridView1.Rows.Count > 0;
            DoneBUTTON.Visible = dataGridView1.Rows.Count > 0;
        }
        private void instructorsTSM_Click(object sender, EventArgs e)
        {
            selectedLISTlabel.Text = "Текущий лист: инструкторы";
            dataGridView1.DataSource = FunctionXLSXforInstructors.SHOW();
            currentTable_ = "instructors";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            CancelBUTTON.Visible = false;
            DoneBUTTON.Visible = false;
        }
        private void make_statementTSM_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                using (var studentsBook = new XLWorkbook(studentsPath_))
                {
                    studentsBook.Worksheet(1).CopyTo(workbook, "Ученики");
                }
                using (var carsBook = new XLWorkbook(carsPath_))
                {
                    carsBook.Worksheet(1).CopyTo(workbook, "Автомобили");
                }
                using (var instructorsBook = new XLWorkbook(instuctorsPath_))
                {
                    instructorsBook.Worksheet(1).CopyTo(workbook, "Инструкторы");
                }
                using (var lessonsBook = new XLWorkbook(lessonsPath_))
                {
                    lessonsBook.Worksheet(1).CopyTo(workbook, "Занятия");
                }
                workbook.SaveAs(otchetPath_);
                MessageBox.Show("Отчёт создан!");
            }
        }
        private void CancelBUTTON_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int lessonId = Convert.ToInt32(row.Cells["ID"].Value);
                    FunctionXLSXforLessons.statusLESSON(lessonId, "отменено");
                }
                dataGridView1.DataSource = FunctionXLSXforLessons.SHOW();
            }
        }
        private void DoneBUTTON_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int lessonId = Convert.ToInt32(row.Cells["ID"].Value);
                    FunctionXLSXforLessons.statusLESSON(lessonId, "проведено");
                }
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
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
                }
                else if (status == "отменено")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.OrangeRed;
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
        private void logFolder_TSM_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = dialog.SelectedPath;
                    LOGGER.SETLOGFOLDER(selectedPath);
                    Properties.Settings.Default.LogFolderPath = selectedPath;
                    Properties.Settings.Default.Save();  // сохраняем настройки
                    MessageBox.Show($"Путь к логам изменён:\n{LOGGER.logFILEPATH_}");
                }
            }
        }
        private void buttonADD_Click(object sender, EventArgs e)
        {
            switch (currentTable_)
            {
                case "students":
                    using (addSTUDENT form = new addSTUDENT())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            FunctionsXLSXforStudents.SAVE(form.StudentFIO, form.NumberPhone, form.Group);
                            dataGridView1.DataSource = FunctionsXLSXforStudents.SHOW();
                            MessageBox.Show("Ученик добавлен!");
                        }
                    }
                    break;
                case "cars":
                    using (addCARS form = new addCARS())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            FunctionXLSXforCars.SAVE(form.markaCar, form.modelCar, form.numberCar, form.yearOfCar);
                            dataGridView1.DataSource = FunctionXLSXforCars.SHOW();
                            MessageBox.Show("Автомобиль добавлен!");
                        }
                    }
                    break;
                case "instructors":
                    using (addINSTRUCTOR form = new addINSTRUCTOR())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            FunctionXLSXforInstructors.SAVE(form.fioINSTRUCTOR, form.numberINSTRUCTOR);
                            dataGridView1.DataSource = FunctionXLSXforInstructors.SHOW();
                            MessageBox.Show("Инструктор добавлен!");
                        }
                    }
                    break;
                case "lessons":
                    using (addLESSON form = new addLESSON())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            FunctionXLSXforLessons.SAVE(form.Date, form.Time, form.studentFIO, form.instructor, form.car);
                            dataGridView1.DataSource = FunctionXLSXforLessons.SHOW();
                            MessageBox.Show("Занятие добавлено!");
                        }
                    }
                    break;
                default:
                    MessageBox.Show("Сначала выберите таблицу для добавления данных.");
                    break;
            }
        }
        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для удаления!");
                return;
            }
            List<int> idsToDelete = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    int id = Convert.ToInt32(row.Cells["ID"].Value);
                    idsToDelete.Add(id);
                }
            }
            switch (currentTable_)
            {
                case "students":
                    FunctionsXLSXforStudents.DELETE(idsToDelete);
                    dataGridView1.DataSource = FunctionsXLSXforStudents.SHOW();
                    break;
                case "cars":
                    FunctionXLSXforCars.DELETE(idsToDelete);
                    dataGridView1.DataSource = FunctionXLSXforCars.SHOW();
                    break;
                case "instructors":
                    FunctionXLSXforInstructors.DELETE(idsToDelete);
                    dataGridView1.DataSource = FunctionXLSXforInstructors.SHOW();
                    break;
                case "lessons":
                    FunctionXLSXforLessons.DELETE(idsToDelete);
                    dataGridView1.DataSource = FunctionXLSXforLessons.SHOW();
                    break;
                default:
                    MessageBox.Show("Таблица не выбрана.");
                    break;
            }
        }

        private void aboutTSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            @"Информационная система автошколы. Версия: 0.9.5.
Разработчик: Бережецкий К.Т., ФТФ, ИВТ-2, 2 курс. Год: 2025
Данная программа предназначена для работы с модулями администратора и инструктора.",
            "О программе",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
        }
    }
}