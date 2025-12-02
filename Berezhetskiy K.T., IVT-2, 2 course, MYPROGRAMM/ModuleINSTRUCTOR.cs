using System;
using System.Windows.Forms;


namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    public partial class ModuleINSTRUCTOR : Form
    {
        public string lessonsPath = "Занятия.xlsx";
        XLSX_FUNC_LESSONS FunctionXLSXforLessons = new XLSX_FUNC_LESSONS();
        public ModuleINSTRUCTOR()
        {
            InitializeComponent();
        }
        private void scheduleTSM_ButtonClick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FunctionXLSXforLessons.SHOW();
            if (dataGridView1.Rows.Count > 0)
            {
                CancelBUTTON.Visible = true;
                DoneBUTTON.Visible = true;
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
        private void exitTSM_Click(object sender, EventArgs e)
        {
            this.Close();
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
